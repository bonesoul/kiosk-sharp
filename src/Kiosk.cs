using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace kiosksharp
{
    public static class Kiosk
    {
        /// <summary>
        /// Kiosk Mode Initilization
        /// </summary>
        public static void init()
        {
            try
            {
                Program.MainForm = new frmMain(); // main form
                SystemLock.lock_system(); // lock the system; special keyboard functions, windows functionalities..
                XMLConfig.init(); // read the configuration 
                Application.Run(Program.MainForm);
                SystemLock.unlock_system(); // system may be still in locked mode, so try to unlock it if so..
                KioskMenu.Dispose();
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
            finally
            {
                Program.MainForm.Dispose();
            }
        }

        /// <summary>
        /// Developer Mode Support
        /// </summary>
        public static void developer_mode()
        {
            try
            {
                if (Program.PasswordForm != null) // close the password form
                    Program.PasswordForm.Close();

                frmDeveloper d = new frmDeveloper(); // open the developer mode form 
                d.ShowDialog();
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }
    }
}
