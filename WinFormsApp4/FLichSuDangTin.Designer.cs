namespace WinFormsApp4
{
    partial class FLichSuDangTin
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(39, 102);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1007, 538);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(453, 15);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(179, 27);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Lịch Sử Đăng Tin";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.ForeColor = Color.Black;
            lblTaiKhoan.Location = new Point(308, 12);
            lblTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(36, 22);
            lblTaiKhoan.TabIndex = 3;
            lblTaiKhoan.Text = "label";
            // 
            // FLichSuDangTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1090, 811);
            Controls.Add(lblTaiKhoan);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FLichSuDangTin";
            Text = "n";
            Load += FLichSuDangTin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnDaDau;
        private Guna.UI2.WinForms.Guna2Button btnDaRot;
        private Guna.UI2.WinForms.Guna2Button btnDaUngTuyen;
        private Guna.UI2.WinForms.Guna2Button btnAll;
    }
}