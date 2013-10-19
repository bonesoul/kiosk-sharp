using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


namespace kiosksharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((bool)Properties.Settings.Default["disable_cursor"] == true) // hide the cursor if set so
                Cursor.Hide();

            UIControl.UI_Load(); // prepare the user interface
            UIControl.resize_flash_control();
        }

        private void flash_control_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
        {
            CommandHandler.handle(e.command.ToString(), e.args.ToString()); // handle FSCommand
        }

        private void flash_keyboard_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
        {
            CommandHandler.handle(e.command.ToString(), e.args.ToString()); // handle FSCommand
        }

        private void flash_keyboard_Enter(object sender, EventArgs e)
        {
            if (!Program.MainForm.webbrowser.Focused)
            {
                Program.MainForm.ActiveControl = Program.MainForm.webbrowser;   // focus the webbrowser to let SendKeys() goes to browser
                Program.MainForm.webbrowser.Document.Focus();
            }
        }

        private void webbrowser_NewWindow(object sender, CancelEventArgs e) // fires up when a link with targeted new window is clicked
        {
            e.Cancel = true; // we're on kiosk mode and do not want a new browser window.
            HtmlElement active_link = webbrowser.Document.ActiveElement; // instead intercept the URL and open it on our internal browser control
            string url = active_link.GetAttribute("href");
            webbrowser.Navigate(url);
        }

        private void webbrowser_scroll_Scroll(object sender, ScrollEventArgs e) // default webbroswer control's scrollbars are to small for touchscreen
        {
            int y = webbrowser_scroll.Value;    // so use a custom scroll bar
            // As our scrollbar is set to a maximum (UIControl.SCROLLBAR_MAX) we have calculated a ratio to use while scrolling
            webbrowser.Document.Window.ScrollTo(new Point(0, y * UIControl.SCROLL_RATIO));
        }

        private void webbrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e) 
        {
            UIControl.browser_navigation_start(); // show progress bar
        }

        private void webbrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            UIControl.browser_navigation_complete(); // hide the progressbar, navigation is complete
        }
    }
}
