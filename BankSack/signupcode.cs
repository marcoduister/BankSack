using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    class Signupcode
    {
        public static string iban = "NL64MAZE";
        public static int accountnum;
        public static Random random = new Random();
        public static bool emailbool = false;
        public static bool nummerbool = false;

        public static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\marco\\source\\repos\\BankSack\\BankSack\\bank.mdf;Integrated Security=True");
        public static void Signup_app(string firstname, string lastname, string Email, string Password)
        {
            Accountnummer();
            Existinguser(firstname, lastname, Email, Password);

            if (emailbool && nummerbool)
            {
                try
                { conn.Open(); }
                catch
                { MessageBox.Show("can't connect to server"); }

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("INSERT users (FirstName,LastName," + "Email,Password,Iban,AccountNummer) VALUES ("
                + "'" + firstname + "'" + "," + "'" + lastname + "'" + "," + "'" + Email + "'" + "," + "'" + Password + "'" + "," + "'" + iban + "'"
                + "," + "'" + accountnum + "'" + ")", conn);

                myReader = myCommand.ExecuteReader();
                conn.Close();
                MessageBox.Show("your account is made");
                Form_start_login.clean = true;
            }
        }

        public static void Accountnummer()
        {
            for (int i = 0; i < 100000; i++)
            {
                Random r = new Random();
                int e1 = r.Next(100000);
                accountnum = accountnum + e1;
            }
        }

        private static List<string> firstName = new List<string>();
        private static List<string> lastName = new List<string>();
        private static List<string> AccountNummer = new List<string>();
        private static List<string> email = new List<string>();
        private static List<string> password = new List<string>();
        private static List<string> money = new List<string>();
        private static void Existinguser(string firstname, string lastname, string Email, string Password)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("can't connect to server");
            }

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT * from Users ", conn);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                firstName.Add(myReader["FirstName"].ToString());
                lastName.Add(myReader["LastName"].ToString());
                AccountNummer.Add(myReader["AccountNummer"].ToString());
                password.Add(myReader["Password"].ToString());
                email.Add(myReader["Email"].ToString());
            }
            conn.Close();


            string accnum = accountnum.ToString();

            for (int i = 0; i < AccountNummer.Count; i++)
            {
                if (AccountNummer[i] == accnum && accnum != null)
                {
                    Accountnummer();
                }
                if (AccountNummer[i] != accnum)
                { nummerbool = true; }
            }
            for (int i = 0; i < email.Count; i++)
            {
                if (email[i] == Email && Email != null)
                {
                    MessageBox.Show("this email is already registered");
                }
                if (email[i] != Email && Email != null)
                { emailbool = true; }
                if (Email == null)
                {
                    MessageBox.Show("you forgot to fill in Email");
                }

            }

        }
    }
}
    

