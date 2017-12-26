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
    public partial class Deposit : UserControl
    {
        private Panel panel;
        private Form Main;
        private Form_start_login loginform;
        public Deposit(Panel panel,Form main ,Form_start_login loginform)
        {
            this.panel = panel;
            this.Main = main;
            this.loginform = loginform; 
            InitializeComponent();
            textbox_amount.TextAlign = HorizontalAlignment.Center;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            panel_deposit_dollar.Visible = true;
            panel_deposit_dollar.BringToFront();
        }

        private void button_agreed_Click(object sender, EventArgs e)
        {
            decimal amount;
            try { amount = Convert.ToInt16(textbox_amount.Text); }
            catch { amount = 0; }
            getmoneyout(amount);
        }
        private void getmoneyout(decimal amount)
        {
            if ( amount < 251)
            {
                if (amount > 1)
                {
                    Getinfo.Balans += amount;
                    setinfo.amount = amount;
                    setinfo.deposit = true;
                    setinfo.setinfodatabe();
                }
                else { MessageBox.Show("you didnt enter any number that you want to deposit"); return; }

            }
            else if (amount > 250)
            { MessageBox.Show("you cant Deposit more than $ 250"); return; }
            panelcontrol.Panelcontroler(panel,Main,loginform);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panelcontrol.Panelcontroler(panel,Main,loginform);
        }
    }
}
