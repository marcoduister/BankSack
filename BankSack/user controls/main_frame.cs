using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSack.form;

namespace BankSack
{
    public partial class main_frame : UserControl
    {
        
        private Panel panel;
        private Form Main;
        private Form_start_login loginform;

        public main_frame(Panel panel, Form main, Form_start_login loginform)
        {
            this.Main = main;
            this.panel = panel;
            this.loginform = loginform;
            InitializeComponent();
        }
        
        #region button

        private void Button_Deposit_Click(object sender, EventArgs e)
        {
            Control choice = new Deposit(panel,Main,loginform);
            Usercontrolset(choice);
        }

        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            Control choice = new Withdraw(panel,Main,loginform);
            Usercontrolset(choice);
        }

        private void button_Transfer_Click(object sender, EventArgs e)
        {
            Control choice = new Transfer(panel,Main,loginform);
            Usercontrolset(choice);
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            Control choice = new Info(panel,Main,loginform);
            Usercontrolset(choice);
        }

        private void Usercontrolset(Control choice)
        {
            panel.Controls.Clear();
            panel.Controls.Add(choice);
        }
        #endregion
        
        private void main_frame_Load(object sender, EventArgs e)
        {
            string getal = string.Format("{0:C}", Getinfo.Balans);
            label_balans_main.Text = getal;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main.Close();
            loginform.Show();
        }
    }
}
