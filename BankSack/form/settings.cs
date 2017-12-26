using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    public partial class settings : Form
    {
        Control info;
        public settings(Control info)
        {
            this.info = info;
            InitializeComponent();
        }

        #region uper panel

        private void button_Close_Click(object sender, EventArgs e)
        { close(); }

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

        private void Button_save_Click(object sender, EventArgs e)
        { close(); }

        private void close()
        {
            this.Close();
            info.Enabled = true;
        }
        private void settings_Load(object sender, EventArgs e)
        {
            label_AccountNum.Text = Getinfo.Accountnummer;
            label_FirstName.Text = Getinfo.FirstName;
            label_LastName.Text = Getinfo.LastName;
            label_Iban.Text = Getinfo.Iban;
            info.Enabled = false;
        }
    }
}
