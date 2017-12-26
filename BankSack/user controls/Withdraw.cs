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
    public partial class Withdraw : UserControl
    {
        private Panel panel;
        private Form Main;
        private Form_start_login loginform;
        public Withdraw(Panel panel,Form Main,Form_start_login loginform)
        {
            this.panel = panel;
            this.Main = Main;
            this.loginform = loginform;
            InitializeComponent();
            textbox_amount.TextAlign = HorizontalAlignment.Center;
        }

        #region diffrent shit
        private void button_diffrent_dollar_Click(object sender, EventArgs e)
        {
            bool value = true;
            panelact(value);
        }

        private void Button_agreed_Click(object sender, EventArgs e)
        {
            decimal amount;
            try { amount = Convert.ToInt16(textbox_amount.Text); }
            catch { amount = 0; }
            Getmoneyout(amount);

            bool value = false;
            panelact(value);
        }

        private void Getmoneyout(decimal amount)
        {
            if (amount < Getinfo.Balans && amount < 251)
            {
                if (amount >1)
                {
                    Getinfo.Balans -= amount;
                    setinfo.amount = amount;
                    setinfo.withdraw = true;
                    setinfo.setinfodatabe();
                }
                else { MessageBox.Show("you didnt enter any number that you want to withdraw"); return; }
            }
            else if (amount < 250)
            { MessageBox.Show("you cant take of more than $ 250"); return; }
            else if (amount > Getinfo.Balans) { MessageBox.Show("you have only $ " + Getinfo.Balans); return; }
            panelcontrol.Panelcontroler(panel,Main,loginform);
        }
        private void panelact(bool value)
        {
            panel_diffrent_dollar.Visible = value;
            panel_diffrent_dollar.BringToFront();
        }
        #endregion


        #region money buttons

        private void button_10_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 10;
            Getmoneyout(amount);
        }

        private void button_20_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 20;
            Getmoneyout(amount);
        }

        private void button_50_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 50;
            Getmoneyout(amount);
        }

        private void button_70_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 70;
            Getmoneyout(amount);
        }

        private void button_100_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 100;
            Getmoneyout(amount);
        }

        private void button_150_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 150;
            Getmoneyout(amount);
        }

        private void button_250_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 250;
            Getmoneyout(amount);
        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panelcontrol.Panelcontroler(panel ,Main,loginform);
        }
    }
}
