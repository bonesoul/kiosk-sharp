using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace kiosksharp
{
    public partial class frmException : Form
    {
        private Exception unhandled_exception;

        private enum form_height // form mode, minimal and detailed error view
        {
            minimal=220,
            detailed=520
        }

        public frmException()
        {
            InitializeComponent();
        }

        public void set_unhandled_exception(Exception _unhandled_exception)
        {
            this.unhandled_exception = _unhandled_exception; // set the provided exception
        }

        private void frmException_Load(object sender, EventArgs e)
        {
                this.Height = (int)form_height.minimal; // set to minimal view on load 

                // Exception details:
                txtMore.Text = "Tarih: " + DateTime.Now.ToString() + "\r\n";
                txtMore.Text += "Dosya: " + Application.ExecutablePath + "\r\n";
                txtMore.Text += "Yol:" + Application.StartupPath + "\r\n";
                txtMore.Text += "MachineName: " + Process.GetCurrentProcess().MachineName + "\r\n";
                txtMore.Text += "NonPagedSystemMemory: " + Process.GetCurrentProcess().NonpagedSystemMemorySize64 + "\r\n";
                txtMore.Text += "PagedMemory: " + Process.GetCurrentProcess().PagedMemorySize64 + "\r\n";
                txtMore.Text += "Source: " + unhandled_exception.Source + "\r\n";
                txtMore.Text += "Exception: " + unhandled_exception.Message + "\r\n";
                txtMore.Text += "Stack Trace: " + unhandled_exception.StackTrace + "\r\n";
        }

        private void cmd_OK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmException_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // exit the application
        }

        private void cmd_more_Click(object sender, EventArgs e)
        {
            // in minimal view, the detailed error is not shown
            // with detailed view, the stack trace and exception details are avaible
            if (this.Height == (int)form_height.minimal)
                this.Height = (int)form_height.detailed;
            else if (this.Height == (int)form_height.detailed)
                this.Height = (int)form_height.minimal;
        }
    }
}
