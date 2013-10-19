namespace kiosksharp
{
    partial class frmException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmException));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_status_error = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_task = new System.Windows.Forms.Label();
            this.lbl_task_message = new System.Windows.Forms.Label();
            this.lbl_solution = new System.Windows.Forms.Label();
            this.lbl_solution_message = new System.Windows.Forms.Label();
            this.lbl_more = new System.Windows.Forms.Label();
            this.cmd_OK = new System.Windows.Forms.Button();
            this.cmd_more = new System.Windows.Forms.Button();
            this.txtMore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_status_error
            // 
            this.lbl_status_error.Location = new System.Drawing.Point(48, 22);
            this.lbl_status_error.Name = "lbl_status_error";
            this.lbl_status_error.Size = new System.Drawing.Size(287, 26);
            this.lbl_status_error.TabIndex = 1;
            this.lbl_status_error.Text = "Programda beklenmeyen bir hata oluştu. Sorun eksik dosyalar veya bug olabilir.";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.Location = new System.Drawing.Point(48, 8);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 14);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Durum";
            // 
            // lbl_task
            // 
            this.lbl_task.AutoSize = true;
            this.lbl_task.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_task.Location = new System.Drawing.Point(7, 62);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(163, 14);
            this.lbl_task.TabIndex = 4;
            this.lbl_task.Text = "Çalışmayı nasıl etkileyecek?";
            // 
            // lbl_task_message
            // 
            this.lbl_task_message.Location = new System.Drawing.Point(7, 80);
            this.lbl_task_message.Name = "lbl_task_message";
            this.lbl_task_message.Size = new System.Drawing.Size(328, 29);
            this.lbl_task_message.TabIndex = 3;
            this.lbl_task_message.Text = "Hata ile bağlantılı bilinen bir çözüm olmadığı için program sonlandırılacak";
            // 
            // lbl_solution
            // 
            this.lbl_solution.AutoSize = true;
            this.lbl_solution.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_solution.Location = new System.Drawing.Point(7, 117);
            this.lbl_solution.Name = "lbl_solution";
            this.lbl_solution.Size = new System.Drawing.Size(135, 14);
            this.lbl_solution.TabIndex = 6;
            this.lbl_solution.Text = "Ne yapmam gerekiyor?";
            // 
            // lbl_solution_message
            // 
            this.lbl_solution_message.Location = new System.Drawing.Point(7, 134);
            this.lbl_solution_message.Name = "lbl_solution_message";
            this.lbl_solution_message.Size = new System.Drawing.Size(325, 29);
            this.lbl_solution_message.TabIndex = 5;
            this.lbl_solution_message.Text = "Programı yeniden çalıştırmayı deneyebilirsiniz. Eğer hata devam ederse, sistem yö" +
                "neticinize hatayı bildiriniz";
            // 
            // lbl_more
            // 
            this.lbl_more.AutoSize = true;
            this.lbl_more.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_more.Location = new System.Drawing.Point(7, 172);
            this.lbl_more.Name = "lbl_more";
            this.lbl_more.Size = new System.Drawing.Size(87, 14);
            this.lbl_more.TabIndex = 7;
            this.lbl_more.Text = "Daha fazla bilgi";
            // 
            // cmd_OK
            // 
            this.cmd_OK.Location = new System.Drawing.Point(261, 166);
            this.cmd_OK.Name = "cmd_OK";
            this.cmd_OK.Size = new System.Drawing.Size(74, 25);
            this.cmd_OK.TabIndex = 8;
            this.cmd_OK.Text = "Tamam";
            this.cmd_OK.UseVisualStyleBackColor = true;
            this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
            // 
            // cmd_more
            // 
            this.cmd_more.Location = new System.Drawing.Point(100, 165);
            this.cmd_more.Name = "cmd_more";
            this.cmd_more.Size = new System.Drawing.Size(28, 26);
            this.cmd_more.TabIndex = 9;
            this.cmd_more.Text = ">>";
            this.cmd_more.UseVisualStyleBackColor = true;
            this.cmd_more.Click += new System.EventHandler(this.cmd_more_Click);
            // 
            // txtMore
            // 
            this.txtMore.Location = new System.Drawing.Point(10, 208);
            this.txtMore.Multiline = true;
            this.txtMore.Name = "txtMore";
            this.txtMore.ReadOnly = true;
            this.txtMore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMore.Size = new System.Drawing.Size(325, 282);
            this.txtMore.TabIndex = 10;
            // 
            // frmException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 496);
            this.Controls.Add(this.txtMore);
            this.Controls.Add(this.lbl_status_error);
            this.Controls.Add(this.cmd_more);
            this.Controls.Add(this.cmd_OK);
            this.Controls.Add(this.lbl_more);
            this.Controls.Add(this.lbl_solution);
            this.Controls.Add(this.lbl_solution_message);
            this.Controls.Add(this.lbl_task);
            this.Controls.Add(this.lbl_task_message);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hata";
            this.Load += new System.EventHandler(this.frmException_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmException_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_status_error;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.Label lbl_task_message;
        private System.Windows.Forms.Label lbl_solution;
        private System.Windows.Forms.Label lbl_solution_message;
        private System.Windows.Forms.Label lbl_more;
        private System.Windows.Forms.Button cmd_OK;
        private System.Windows.Forms.Button cmd_more;
        private System.Windows.Forms.TextBox txtMore;
    }
}