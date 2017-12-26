using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSack
{
    class panelcontrol
    {
        public static void Panelcontroler(Panel panel,Form main, Form_start_login loginform)
        {
            main_frame choice = new main_frame(panel,main,loginform);
            panel.Controls.Clear();
            panel.Controls.Add(choice);
        }
    }
}
