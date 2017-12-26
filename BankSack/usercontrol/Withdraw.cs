using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Withdraw : UserControl
    {
        public Withdraw()
        {
            InitializeComponent();
            textbox_amount.TextAlign = HorizontalAlignment.Center;
        }

        #region diffrent shit
        private void button_diffrent_dollar_Click(object sender, EventArgs e)
        {
            bool value = true;
            panelact(value);
        }

        private void button_agreed_Click(object sender, EventArgs e)
        {
            decimal amount;
            try { amount = Convert.ToInt16(textbox_amount.Text); }
            catch { amount = 0; }
            getmoneyout(amount);

            bool value = false;
            panelact(value);
        }

        private void getmoneyout(decimal amount)
        {
            if (amount < Getinfo.Balans && amount < 251)
            {
                Getinfo.Balans -= amount;
                setinfo.setinfodatabe();
            }
            else if (amount < 250)
            { MessageBox.Show("you cant take of more than $ 250"); }
            else if (amount > Getinfo.Balans) { MessageBox.Show("you have only $ " + Getinfo.Balans); }
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
            getmoneyout(amount);
        }

        private void button_20_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 20;
            getmoneyout(amount);
        }

        private void button_50_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 50;
            getmoneyout(amount);
        }

        private void button_70_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 70;
            getmoneyout(amount);
        }

        private void button_100_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 100;
            getmoneyout(amount);
        }

        private void button_150_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 150;
            getmoneyout(amount);
        }

        private void button_250_dollar_Click(object sender, EventArgs e)
        {
            decimal amount = 250;
            getmoneyout(amount);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string getal = string.Format("{0:C}", Getinfo.Balans);
            label_balans_main.Text = getal;
        }

    }
}
