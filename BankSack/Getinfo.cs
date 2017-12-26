using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    class Getinfo
    {

        #region variable

        public static string login_Email_textbox;
        public static string login_password_textbox;
        private static int id;
        private static string firstname;
        private static string lastname;
        private static string email;
        private static string password;
        private static string iban;
        private static string accountnummer;
        private static decimal balans;
        public static bool loginbool;
        public static bool infobool;
        public static bool data;
        public static List<string> userslist = new List<string>();
        public static List<int> AcountNummerList = new List<int>();
        public static List<string> Main_AccountNummer = new List<string>();
        public static List<string> Date = new List<string>();
        public static List<string> receiver_AccountNummer = new List<string>();
        public static List<int> Payment_reference = new List<int>();
        public static List<decimal> Amount = new List<decimal>();
        public static List<string> type = new List<string>();
        public static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\marco\\source\\repos\\BankSack\\BankSack\\bank.mdf;Integrated Security=True");

        #endregion

        #region sql info-opvragen

        public static void Getinfodatabe()
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                string wtf = ex.ToString();
                MessageBox.Show(wtf);
                
                return;
            }

            SqlDataReader myReader = null;
            if (loginbool)
            {

                SqlCommand login = new SqlCommand("SELECT * from Users where Email=" + "'" + login_Email_textbox + "'" + "AND Password=" + "'" + login_password_textbox + "'", conn);

                myReader = login.ExecuteReader();
                // bij nieuwen gebruikers moet een warden in gefuld worden
                while (myReader.Read())
                {
                    id = Convert.ToInt16(myReader["Id"]);
                    email = myReader["Email"].ToString();
                    password = myReader["Password"].ToString();
                    firstname = myReader["FirstName"].ToString();
                    lastname = myReader["LastName"].ToString();
                    iban = myReader["Iban"].ToString();
                    accountnummer = myReader["AccountNummer"].ToString();
                    balans = Convert.ToDecimal(myReader["balans"]);
                }
                loginbool = false;
                conn.Close();
            }

            if (infobool)
            {
                SqlCommand info = new SqlCommand("SELECT * from Users", conn);
                myReader = info.ExecuteReader();
                while (myReader.Read())
                {
                    int account = Convert.ToInt32(myReader["AccountNummer"]);
                    string name = myReader["FirstName"].ToString() + " " + myReader["LastName"].ToString();
                    if (AcountNummerList.Contains(account))
                    {   return; }
                    else { AcountNummerList.Add(account); }
                    if (userslist.Contains(name))
                    {   return; }
                    else { userslist.Add(myReader["FirstName"].ToString() + " " + myReader["LastName"].ToString()); }                    
                }
                infobool = false;
                conn.Close();
            }

            if (data)
            {
                SqlCommand info = new SqlCommand("SELECT * from transactionn where Main_AccountNummer="+Getinfo.Accountnummer+ " or (receiver_AccountNummer ="+ Getinfo.Accountnummer+" AND type= 'transfer');", conn);
                myReader = info.ExecuteReader();
                while (myReader.Read())
                {
                    Main_AccountNummer.Add(myReader["Main_AccountNummer"].ToString());
                    Date.Add(myReader["Date"].ToString());
                    if (myReader["receiver_AccountNummer"] ==DBNull.Value)
                    {   receiver_AccountNummer.Add("0");  }
                    else { receiver_AccountNummer.Add(myReader["receiver_AccountNummer"].ToString()); }
                    if (myReader["payment_reference"] == DBNull.Value)
                    {   Payment_reference.Add(0);   }
                    else
                    {   Payment_reference.Add(Convert.ToInt32(myReader["payment_reference"]));}
                    //Payment_reference.Add(Convert.ToInt16(myReader["payment_reference"]));
                    Amount.Add(Convert.ToDecimal(myReader["amount"]));
                    type.Add(myReader["type"].ToString());
                }
                data = false;
                conn.Close();
            }

            conn.Close();
        }

        #endregion

        #region getinfo variable
        public static int ID
        {
            get { return id; }
        }
        public static string FirstName
        {
            get { return firstname; }
        }
        public static string LastName
        {
            get { return lastname; }
        }
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static string Iban
        {
            get { return iban; }
        }
        public static string Accountnummer
        {
            get { return accountnummer; }
        }
        public static decimal Balans
        {
            get { return balans; }
            set { balans = value; }
        }
        #endregion

    }
}