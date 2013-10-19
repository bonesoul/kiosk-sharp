namespace kiosksharp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.webbrowser_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.webbrowser_scroll = new DevExpress.XtraEditors.VScrollBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progress_navigate = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.webbrowser = new System.Windows.Forms.WebBrowser();
            this.flash_keyboard = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.flash_control = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.progress_navigate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flash_keyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flash_control)).BeginInit();
            this.SuspendLayout();
            // 
            // webbrowser_menu
            // 
            this.webbrowser_menu.Name = "webbrowser_menu";
            this.webbrowser_menu.Size = new System.Drawing.Size(61, 4);
            // 
            // webbrowser_scroll
            // 
            this.webbrowser_scroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webbrowser_scroll.Location = new System.Drawing.Point(189, -3);
            this.webbrowser_scroll.Name = "webbrowser_scroll";
            this.webbrowser_scroll.Size = new System.Drawing.Size(50, 131);
            this.webbrowser_scroll.TabIndex = 4;
            this.webbrowser_scroll.Visible = false;
            this.webbrowser_scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.webbrowser_scroll_Scroll);
            // 
            // progress_navigate
            // 
            this.progress_navigate.EditValue = 0;
            this.progress_navigate.Location = new System.Drawing.Point(28, 149);
            this.progress_navigate.Name = "progress_navigate";
            this.progress_navigate.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.progress_navigate.Properties.Appearance.Options.UseBackColor = true;
            this.progress_navigate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.progress_navigate.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.progress_navigate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progress_navigate.Properties.MarqueeAnimationSpeed = 75;
            this.progress_navigate.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
            this.progress_navigate.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progress_navigate.Properties.Stopped = true;
            this.progress_navigate.Size = new System.Drawing.Size(261, 18);
            this.progress_navigate.TabIndex = 6;
            this.progress_navigate.Visible = false;
            // 
            // webbrowser
            // 
            this.webbrowser.ContextMenuStrip = this.webbrowser_menu;
            this.webbrowser.IsWebBrowserContextMenuEnabled = false;
            this.webbrowser.Location = new System.Drawing.Point(312, 22);
            this.webbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser.Name = "webbrowser";
            this.webbrowser.Size = new System.Drawing.Size(155, 106);
            this.webbrowser.TabIndex = 1;
            this.webbrowser.Visible = false;
            this.webbrowser.WebBrowserShortcutsEnabled = false;
            this.webbrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webbrowser_Navigating);
            this.webbrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webbrowser_NewWindow);
            this.webbrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webbrowser_DocumentCompleted);
            // 
            // flash_keyboard
            // 
            this.flash_keyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flash_keyboard.Enabled = true;
            this.flash_keyboard.Location = new System.Drawing.Point(28, 265);
            this.flash_keyboard.Name = "flash_keyboard";
            this.flash_keyboard.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flash_keyboard.OcxState")));
            this.flash_keyboard.Size = new System.Drawing.Size(1272, 276);
            this.flash_keyboard.TabIndex = 2;
            this.flash_keyboard.Visible = false;
            this.flash_keyboard.FSCommand += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler(this.flash_keyboard_FSCommand);
            this.flash_keyboard.Enter += new System.EventHandler(this.flash_keyboard_Enter);
            // 
            // flash_control
            // 
            this.flash_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flash_control.ContextMenuStrip = this.webbrowser_menu;
            this.flash_control.Enabled = true;
            this.flash_control.Location = new System.Drawing.Point(28, 12);
            this.flash_control.Name = "flash_control";
            this.flash_control.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flash_control.OcxState")));
            this.flash_control.Size = new System.Drawing.Size(981, 578);
            this.flash_control.TabIndex = 0;
            this.flash_control.FSCommand += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler(this.flash_control_FSCommand);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.webbrowser_scroll);
            this.Controls.Add(this.progress_navigate);
            this.Controls.Add(this.webbrowser);
            this.Controls.Add(this.flash_keyboard);
            this.Controls.Add(this.flash_control);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Türkiye";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progress_navigate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flash_keyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flash_control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxShockwaveFlashObjects.AxShockwaveFlash flash_control;
        public AxShockwaveFlashObjects.AxShockwaveFlash flash_keyboard;
        public System.Windows.Forms.WebBrowser webbrowser;
        private System.Windows.Forms.ContextMenuStrip webbrowser_menu;
        public DevExpress.XtraEditors.VScrollBar webbrowser_scroll;
        public System.Windows.Forms.Timer timer;
        public DevExpress.XtraEditors.MarqueeProgressBarControl progress_navigate;
        


    }
}

