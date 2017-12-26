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
    public partial class main_frame : UserControl
    {
        Main_menu foo = new Main_menu();
        public main_frame()
        {
            InitializeComponent();
        }
        
        #region button

        private void Button_Deposit_Click(object sender, EventArgs e)
        {
            Control choice = new Deposit();
            Usercontrolset(choice);
        }

        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            Control choice = new Withdraw();
            Usercontrolset(choice);
        }

        private void button_Transfer_Click(object sender, EventArgs e)
        {
            Control choice = new Transfer();
            Usercontrolset(choice);
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            Control choice = new Info();
            Usercontrolset(choice);
        }

        private void Usercontrolset(Control choice)
        {
            foo.Usercontrolset(choice);
        }
        #endregion

        // dit werk
        private void main_frame_Load(object sender, EventArgs e)
        {
            string getal = string.Format("{0:C}", Getinfo.Balans);
            label_balans_main.Text = getal;
        }
    }
}
