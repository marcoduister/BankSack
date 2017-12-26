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
    public partial class Deposit : UserControl
    {
        public Deposit()
        {
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
                Getinfo.Balans += amount;
                setinfo.setinfodatabe();
            }
            else if (amount > 250)
            { MessageBox.Show("you cant Deposit more than $ 250"); }
        }
    }
}
