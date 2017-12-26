using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    public partial class Transfer : UserControl
    {
        private Panel panel;
        private Form Main;
        private Form_start_login loginform;
        public Transfer(Panel panel,Form Main,Form_start_login loginform)
        {
            this.panel = panel;
            this.Main = Main;
            this.loginform = loginform;
            InitializeComponent();

        }
        private List<string> klantencount = Getinfo.userslist;
        private void Transfer_Load(object sender, EventArgs e)
        {
            label_accountnummer.Text = Getinfo.Iban + " " + Getinfo.Accountnummer;
            label_balans_transfer.TextAlign = ContentAlignment.MiddleRight;
            string getal = string.Format("{0:C}", Getinfo.Balans);
            label_balans_transfer.Text = getal;
            label_user.Text = Getinfo.FirstName + " " + Getinfo.LastName;
            if (Getinfo.userslist.Count ==0)
            {
                Getinfo.infobool = true;
                Getinfo.Getinfodatabe();
            }
            Dropdown_users.Clear();
            for (int i = 0; i < Getinfo.userslist.Count; i++)
            {
                Dropdown_users.AddItem(klantencount[i]);
            }
            
        }
        

        private decimal amount;
        private int account_reciever;
        private int Payment_Refrence;
        private int tell = 0;

        private void Button_Send_Money_Click(object sender, EventArgs e)
        {
            string strselectacc = Dropdown_users.selectedIndex.ToString();
            tell = Convert.ToInt32(strselectacc);
            int account = Convert.ToInt32(Textbox_reciever_Account_Nummer.Text);
            string moneystring = textbox_Amount_dollar.Text + "." + textbox_Amount_pennys.Text;
            amount = Convert.ToDecimal(moneystring);
            account_reciever = account;
            if (amount ==0 || amount > Getinfo.Balans)
            {
                MessageBox.Show("the ammount is not correct Transfer is getting canceled");
                return;
            }
            if (Textbox_reciever_Account_Nummer.Text == "")
            {
                MessageBox.Show("reciever does not exist "+ " and is getting canceled");
                return;
            }
            else if (account == Getinfo.AcountNummerList[tell])
            {   setinfo.Transfer_Account = account_reciever;    }
            else { account_reciever = Convert.ToInt32(Textbox_reciever_Account_Nummer.Text); }
            if (textbox_Payment_Refrence.Text == "")
            {   Payment_Refrence = 0;   }
            else { try { Payment_Refrence = Convert.ToInt16(textbox_Payment_Refrence.Text); } catch { Payment_Refrence = Convert.ToInt32(textbox_Payment_Refrence.Text); } }
            setinfo.Payment_Refrence = Payment_Refrence;
            
            Getinfo.Balans -= amount;
            setinfo.Transfer_Balans = amount;
            setinfo.amount = amount;

            setinfo.Transfer = true;
            setinfo.setinfodatabe();

            panelcontrol.Panelcontroler(panel,Main,loginform);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panelcontrol.Panelcontroler(panel,Main,loginform);
        }

        private void Dropdown_users_onItemSelected(object sender, EventArgs e)
        {
            string nummer = Dropdown_users.selectedIndex.ToString();
            int nummermain = Convert.ToInt32(nummer);
            Textbox_reciever_Account_Nummer.Text = Convert.ToString(Getinfo.AcountNummerList[nummermain]);
        }
    }
}
