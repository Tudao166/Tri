namespace WinFormsApp4
{
    partial class FCongTy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCongTy));
            sidebar = new Panel();
            btnMenu = new Button();
            button4 = new Button();
            button10 = new Button();
            button12 = new Button();
            button9 = new Button();
            button3 = new Button();
            button11 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lblTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            homeTimer = new System.Windows.Forms.Timer(components);
            homeTimer2 = new System.Windows.Forms.Timer(components);
            homeTimer3 = new System.Windows.Forms.Timer(components);
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            timer1 = new System.Windows.Forms.Timer(components);
            sidebarTime = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackgroundImage = (Image)resources.GetObject("sidebar.BackgroundImage");
            sidebar.BackgroundImageLayout = ImageLayout.Stretch;
            sidebar.Controls.Add(btnMenu);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button10);
            sidebar.Controls.Add(button12);
            sidebar.Controls.Add(button9);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button11);
            sidebar.Controls.Add(button2);
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(190, 653);
            sidebar.MinimumSize = new Size(43, 653);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(190, 653);
            sidebar.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.White;
            btnMenu.BackgroundImageLayout = ImageLayout.Center;
            btnMenu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(193, 77);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(22, 517);
            button4.Name = "button4";
            button4.Size = new Size(149, 46);
            button4.TabIndex = 7;
            button4.Text = "   Log Out";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(22, 450);
            button10.Name = "button10";
            button10.Size = new Size(149, 46);
            button10.TabIndex = 2;
            button10.Text = "      Lịch Sử";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(22, 164);
            button12.Name = "button12";
            button12.Size = new Size(149, 46);
            button12.TabIndex = 9;
            button12.Text = "       Thông Tin";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(22, 307);
            button9.Name = "button9";
            button9.Size = new Size(149, 46);
            button9.TabIndex = 1;
            button9.Text = "      Ứng Tuyển";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(22, 379);
            button3.Name = "button3";
            button3.Size = new Size(149, 46);
            button3.TabIndex = 2;
            button3.Text = "Đăng Việc";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(22, 88);
            button11.Name = "button11";
            button11.Size = new Size(149, 46);
            button11.TabIndex = 8;
            button11.Text = "Trang Chủ";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(22, 237);
            button2.Name = "button2";
            button2.Size = new Size(149, 46);
            button2.TabIndex = 1;
            button2.Text = "         Tìm Việc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblTaiKhoan);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(191, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 586);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1143, 586);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.ForeColor = Color.Transparent;
            lblTaiKhoan.Location = new Point(0, 164);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(121, 22);
            lblTaiKhoan.TabIndex = 7;
            lblTaiKhoan.Text = "guna2HtmlLabel4";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1143, 586);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(guna2HtmlLabel5);
            panel2.Location = new Point(192, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 77);
            panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.Black;
            guna2HtmlLabel5.Location = new Point(191, 12);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(756, 37);
            guna2HtmlLabel5.TabIndex = 6;
            guna2HtmlLabel5.Text = "chỉ những người dám thất bại mới đạt được thành công lớn";
            // 
            // homeTimer
            // 
            homeTimer.Interval = 10;
            // 
            // homeTimer2
            // 
            homeTimer2.Interval = 10;
            // 
            // homeTimer3
            // 
            homeTimer3.Interval = 10;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(80, 12);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(260, 27);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "Các Ngành Nhu Cầu Cao";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(136, 10);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(144, 27);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Top Việc Làm";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(101, 10);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(206, 27);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Hướng Dẫn Viết CV";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            // 
            // FCongTy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 648);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FCongTy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCongTy";
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button9;
        private Button button10;
        private Button btnMenu;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Timer homeTimer2;
        private System.Windows.Forms.Timer homeTimer3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Button button11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer sidebarTime;
        private Button button4;
        private Panel homeConterner3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button12;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaiKhoan;
    }
}