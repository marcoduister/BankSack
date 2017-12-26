using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSack.form;

namespace BankSack
{
    class Logincode
    {
        public static void Login_app(Form_start_login loginform)
        {
            if (Getinfo.login_Email_textbox == Getinfo.Email && Getinfo.login_password_textbox == Getinfo.Password)
            {
                Main_menu mainapp = new Main_menu(loginform);
                mainapp.Show();
                loginform.Hide();
            }
            else
            {
                MessageBox.Show("you informasion is not correct");
            }

        }
    }
}
