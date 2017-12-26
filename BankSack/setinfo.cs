using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    class setinfo
    {

        #region variable

        private static decimal transfer_balans;
        private static int transfer_account;
        public static bool Transfer;
        public static bool info;
        public static bool withdraw;
        public static bool deposit;
        public static decimal amount;
        public static string deposit_type = "Deposit";
        public static string withdraw_type = "Withdraw";
        public static string transfar_type = "transfer";
        public static int Payment_Refrence;
        private static SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\marco\\source\\repos\\BankSack\\BankSack\\bank.mdf;Integrated Security = True");
        #endregion

        #region sql info-opvragen

        public static void setinfodatabe()
        {
            try
            { conn.Open(); }
            catch
            {
               MessageBox.Show("can't connect to server");
            }

            SqlCommand withdrawCommand = new SqlCommand("UPDATE users SET balans = " + Getinfo.Balans + " WHERE AccountNummer = " + Getinfo.Accountnummer + "INSERT INTO[transactionn](Main_AccountNummer,[Date],amount,type) VALUES(" + Getinfo.Accountnummer + ", '" + DateTime.Now + "'," + amount +",'"+withdraw_type+ "');", conn);
            SqlCommand depositCommand = new SqlCommand("UPDATE users SET balans = " + Getinfo.Balans + " WHERE AccountNummer = " + Getinfo.Accountnummer + "INSERT INTO[transactionn](Main_AccountNummer,[Date],amount,type) VALUES(" + Getinfo.Accountnummer + ", '" + DateTime.Now + "'," + amount + ",'" + deposit_type + "');", conn);
            SqlCommand TransferCommand = new SqlCommand("UPDATE users SET balans = " + Getinfo.Balans + " WHERE AccountNummer = " + Getinfo.Accountnummer + "UPDATE users SET balans = balans +" + transfer_balans + " WHERE AccountNummer = " + transfer_account + "INSERT INTO[transactionn](Main_AccountNummer, receiver_AccountNummer,[Date],amount,type,payment_reference) VALUES(" + Getinfo.Accountnummer + "," + transfer_account + ", '" + DateTime.Now + "'," + amount  + ",'" + transfar_type + "',"+ Payment_Refrence + ");", conn);

            SqlCommand infoCommand = new SqlCommand("UPDATE users SET Email = '" + Getinfo.Email + "', password = '" + Getinfo.Password + "', balans = " + Getinfo.Balans + " WHERE AccountNummer = " + Getinfo.Accountnummer + ";", conn);

            SqlDataReader myReader = null;

            if (withdraw)
            { myReader = withdrawCommand.ExecuteReader(); withdraw = false; conn.Close(); }
            if (deposit)
            { myReader = depositCommand.ExecuteReader(); deposit = false; conn.Close(); }
            if (Transfer)
            { myReader = TransferCommand.ExecuteReader(); Transfer = false; conn.Close(); }
            if (info)
            {   myReader = infoCommand.ExecuteReader(); info = false; conn.Close(); }

            conn.Close();
        }

        #endregion

        #region set

        public static int Transfer_Account
        {
            set { transfer_account = value;  }
        }
        public static decimal Transfer_Balans
        {
            set { transfer_balans = value; }
        }

        #endregion

    }
}
