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
    public partial class Info : UserControl
    {
        private static list_Control change = new list_Control();
        private Panel panel;
        private Form Main;
        private Form_start_login loginform;
        public Info(Panel panel, Form Main, Form_start_login loginform)
        {
            this.panel = panel;
            this.Main = Main;
            this.loginform = loginform;
            InitializeComponent();
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
            panelcontrol.Panelcontroler(panel,Main,loginform);
        }
        private void Info_Load(object sender, EventArgs e)
        {
            
            label_accountnummer.Text = Getinfo.Iban + " " + Getinfo.Accountnummer;
            label_balans_transfer.TextAlign = ContentAlignment.MiddleRight;
            string getal = string.Format("{0:C}", Getinfo.Balans);
            label_balans_transfer.Text = getal;
            label_user.Text = Getinfo.FirstName + " " + Getinfo.LastName;
            Getinfo.Amount.Clear();
            if (Getinfo.Amount.Count ==0)
            {
                Getinfo.data = true;
                Getinfo.Getinfodatabe();
            }
            infolist();
            
        }

        private void Button_settings_Click(object sender, EventArgs e)
        {
            settings Settings = new settings(this);
            Settings.Show();
        }

        private int onthoud;
        private int namelist =0;
        private void infolist()
        {
            List<string> temp = Getinfo.Main_AccountNummer;
            List<string> temp2 = Getinfo.receiver_AccountNummer;
            List<string> type1 = Getinfo.type;
            int count = temp.Count;
            onthoud = count * 77;
            string type;
            for (int i = 0; i < temp.Count; i++)
            {
                string getal = string.Format("{0:C}", Getinfo.Amount[namelist]);

                list_Control change = new list_Control();

                if (Getinfo.type[namelist]== "Deposit")
                {
                    change.label_amount.Text = "+" + getal;
                    change.label_Name.Text = Getinfo.FirstName + " " + Getinfo.LastName;
                }
                else if(Getinfo.type[namelist] == "Withdraw")
                {
                    type = "-" + getal; change.label_amount.Text = type;
                    change.label_Name.Text = Getinfo.FirstName + " " + Getinfo.LastName;
                }
                else if (Getinfo.type[namelist] == "transfer" && temp2[namelist] == Getinfo.Accountnummer)
                {
                    change.label_Name.Text = temp[namelist];
                    change.label_amount.Text = "+" + getal;
                }
                else if (Getinfo.type[namelist] == "transfer" && temp[namelist] == Getinfo.Accountnummer)
                {
                    change.label_Name.Text = temp2[namelist];
                    change.label_amount.Text = "-" + getal;
                }

                string datum = Getinfo.Date[namelist];
                change.label_datum.Text = datum;

                namelist += 1;
                panel1.Controls.Add(change);
                change.Show();
                
                change.Location = new Point(10,onthoud);

                onthoud -= 90;
            }

            temp.Clear();
            temp2.Clear();
            type1.Clear();
            Getinfo.Amount.Clear();
        }

    }
}
