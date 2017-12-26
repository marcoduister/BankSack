using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    public partial class Form_start_login : Form
    {
        public Form_start_login()
        {
            InitializeComponent();
        }

        #region boven paneel

        private void Close_Click(object sender, EventArgs e)
        { Environment.Exit(0); }

        private void button_minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        #region drag bar

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #endregion

        #region signin
        private void Button_signin_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_signup.Location = new Point(397, 106);
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            Getinfo.login_Email_textbox = textbox_Email_login.Text;
            Getinfo.login_password_textbox = textbox_password_login.Text;
            Getinfo.loginbool = true;
            Getinfo.Getinfodatabe();
            Logincode.Login_app(this);
        }

        #endregion

        #region Signup
        
        private void button_signup_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_signup.Location = new Point(12, 106);
        }
        public static bool clean;
        private void button_signup_acc_Click(object sender, EventArgs e)
        {
            string firstname = textbox_Signup_FirstName.Text;
            string lastname = textbox_Signup_LastName.Text;
            string Email = textbox_signup_Email.Text;
            string Password = textbox_signup_Password.Text;

            Signupcode.Signup_app(firstname, lastname, Email, Password);

            if (clean)
            {
                textbox_Signup_FirstName.Text = String.Empty;
                textbox_Signup_LastName.Text = String.Empty;
                textbox_signup_Email.Text = String.Empty;
                textbox_signup_Password.Text = String.Empty;
            }
        }

        #endregion

    }
}
