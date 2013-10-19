using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kiosksharp
{
    public partial class frmDeveloper : Form
    {
        public frmDeveloper()
        {
            InitializeComponent();
        }

        private void frmDeveloper_Load(object sender, EventArgs e)
        {
            Cursor.Show(); // show the cursor for developer mode
            show_info(); // gather system information
            // show the xml config in browser
            webBrowser.Navigate(Application.StartupPath + "\\" + Properties.Settings.Default["XmlConfig"].ToString());
        }

        private void frmDeveloper_FormClosed(object sender, FormClosedEventArgs e)
        {
            if((bool)Properties.Settings.Default["disable_cursor"]) // if cursor is disabled already, hide it again
                Cursor.Hide();
        }

        private void show_info()
        {
            // version
            lblVersion.Text  = Application.ProductName + " " + Application.ProductVersion;

            // settings
            foreach (System.Configuration.SettingsProperty i in Properties.Settings.Default.Properties)
            {
                lst_properties.Items.Add(i.Name + "=>" + Properties.Settings.Default[i.Name]);
            }
            
            // Resources folder's contents
            DirectoryInfo di = new DirectoryInfo(Utils.get_movies_path());
            foreach (FileInfo f in di.GetFiles())
            {
                lst_resources.Items.Add(f.Name);
            }          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            SystemLock.unlock_system(); // first unlock the system or it'll be non-usable
            Application.Exit();
        }


    }
}
