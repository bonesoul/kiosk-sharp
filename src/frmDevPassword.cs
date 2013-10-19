using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kiosksharp
{
    public partial class frmDevPassword : Form
    {
        public frmDevPassword()
        {
            InitializeComponent();
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text == "29062906") // check the password
                    Kiosk.developer_mode();
            }
        }
    }
}
