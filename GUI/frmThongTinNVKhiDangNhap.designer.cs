namespace GUI
{
    partial class frmThongTinNVKhiDangNhap
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
            this.picHinhAnh.ErrorImage = global::GUI.Properties.Resources.manager;
            this.picHinhAnh.Image = global::GUI.Properties.Resources.manager;
            this.picHinhAnh.InitialImage = null;
            this.picHinhAnh.Location = new System.Drawing.Point(34, 11);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(70, 76);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 11;
            this.picHinhAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(108, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(108, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên NV:";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblma.ForeColor = System.Drawing.Color.Blue;
            this.lblma.Location = new System.Drawing.Point(168, 28);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(53, 18);
            this.lblma.TabIndex = 14;
            this.lblma.Text = "Mã NV";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblten.ForeColor = System.Drawing.Color.Blue;
            this.lblten.Location = new System.Drawing.Point(169, 55);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(57, 18);
            this.lblten.TabIndex = 15;
            this.lblten.Text = "Tên NV";
            // 
            // frmThongTinNVKhiDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
            this.BackgroundImage = global::GUI.Properties.Resources.from;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 95);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lblma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHinhAnh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(379, 95);
            this.Name = "frmThongTinNVKhiDangNhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmThongTinNVKhiDangNhap";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmThongTinNVKhiDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label lblten;
    }
}