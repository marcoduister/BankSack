using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankSack.form
{
    public partial class Main_menu : Form
    {
        main_frame main_frame1;
        private Form_start_login loginform;

        public Main_menu(Form_start_login loginform)
        {
            this.loginform = loginform;
            InitializeComponent();
        }

        #region uper panel

        private void button_Close_Click(object sender, EventArgs e)
        {Environment.Exit(0);}

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

        private void Main_menu_Load(object sender, EventArgs e)
        {
            main_frame1 = new main_frame(panel_main,this, loginform);
            panel_main.Controls.Add(main_frame1);
            this.Refresh();
        }

    }
}
