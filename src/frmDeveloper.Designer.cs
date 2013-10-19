namespace kiosksharp
{
    partial class frmDeveloper
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
            this.lst_properties = new System.Windows.Forms.ListBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_resources = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_properties
            // 
            this.lst_properties.BackColor = System.Drawing.Color.White;
            this.lst_properties.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_properties.FormattingEnabled = true;
            this.lst_properties.ItemHeight = 14;
            this.lst_properties.Location = new System.Drawing.Point(7, 22);
            this.lst_properties.Margin = new System.Windows.Forms.Padding(4);
            this.lst_properties.Name = "lst_properties";
            this.lst_properties.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_properties.Size = new System.Drawing.Size(362, 46);
            this.lst_properties.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVersion.Location = new System.Drawing.Point(10, 4);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(50, 18);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_properties);
            this.groupBox1.Location = new System.Drawing.Point(8, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özellikler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_resources);
            this.groupBox2.Location = new System.Drawing.Point(390, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kaynaklar";
            // 
            // lst_resources
            // 
            this.lst_resources.BackColor = System.Drawing.Color.White;
            this.lst_resources.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_resources.FormattingEnabled = true;
            this.lst_resources.ItemHeight = 14;
            this.lst_resources.Location = new System.Drawing.Point(7, 22);
            this.lst_resources.Margin = new System.Windows.Forms.Padding(4);
            this.lst_resources.Name = "lst_resources";
            this.lst_resources.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_resources.Size = new System.Drawing.Size(362, 46);
            this.lst_resources.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(7, 21);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(744, 353);
            this.webBrowser.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser);
            this.groupBox3.Location = new System.Drawing.Point(8, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 380);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Konfigurasyon";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(649, 492);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 31);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Programı Kapat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVersion);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeveloper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yöneticisi";
            this.Load += new System.EventHandler(this.frmDeveloper_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeveloper_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_properties;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_resources;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_exit;
    }
}