namespace WinFormsApp4
{
    partial class UserControlTinDang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTinDang));
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            lblLuongMax = new Label();
            label1 = new Label();
            lblChucVu = new Label();
            lblLike = new Label();
            pictureBox1 = new PictureBox();
            lblIDCongTy = new Label();
            lblTaiKhoan = new Label();
            lblIDTinDang = new Label();
            lblNgayDang = new Label();
            lblNganhNghe = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblViTRi = new Label();
            btnDetail = new Button();
            lblLuongMin = new Label();
            labelHVT = new Label();
            pictureBox6 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel6
            // 
            guna2Panel6.BorderColor = Color.FromArgb(255, 128, 0);
            guna2Panel6.BorderRadius = 30;
            guna2Panel6.BorderThickness = 3;
            guna2Panel6.Controls.Add(label3);
            guna2Panel6.Controls.Add(lblLuongMax);
            guna2Panel6.Controls.Add(label1);
            guna2Panel6.Controls.Add(lblChucVu);
            guna2Panel6.Controls.Add(lblLike);
            guna2Panel6.Controls.Add(pictureBox1);
            guna2Panel6.Controls.Add(lblIDCongTy);
            guna2Panel6.Controls.Add(lblTaiKhoan);
            guna2Panel6.Controls.Add(lblIDTinDang);
            guna2Panel6.Controls.Add(lblNgayDang);
            guna2Panel6.Controls.Add(lblNganhNghe);
            guna2Panel6.Controls.Add(pictureBox3);
            guna2Panel6.Controls.Add(pictureBox2);
            guna2Panel6.Controls.Add(lblViTRi);
            guna2Panel6.Controls.Add(btnDetail);
            guna2Panel6.Controls.Add(lblLuongMin);
            guna2Panel6.Controls.Add(labelHVT);
            guna2Panel6.Controls.Add(pictureBox6);
            guna2Panel6.CustomizableEdges = customizableEdges1;
            guna2Panel6.FillColor = Color.FromArgb(255, 224, 192);
            guna2Panel6.Location = new Point(0, 7);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel6.Size = new Size(348, 283);
            guna2Panel6.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(120, 191);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 25;
            label3.Text = "Triệu";
            // 
            // lblLuongMax
            // 
            lblLuongMax.AutoSize = true;
            lblLuongMax.BackColor = Color.Transparent;
            lblLuongMax.Location = new Point(89, 191);
            lblLuongMax.Name = "lblLuongMax";
            lblLuongMax.Size = new Size(33, 20);
            lblLuongMax.TabIndex = 24;
            lblLuongMax.Text = "150";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(81, 191);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 23;
            label1.Text = "-";
            // 
            // lblChucVu
            // 
            lblChucVu.AllowDrop = true;
            lblChucVu.AutoSize = true;
            lblChucVu.BackColor = Color.Transparent;
            lblChucVu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(16, 140);
            lblChucVu.MaximumSize = new Size(330, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(93, 20);
            lblChucVu.TabIndex = 16;
            lblChucVu.Text = "Nhân viên ";
            // 
            // lblLike
            // 
            lblLike.AutoSize = true;
            lblLike.BackColor = Color.Transparent;
            lblLike.Location = new Point(57, 258);
            lblLike.Name = "lblLike";
            lblLike.Size = new Size(63, 20);
            lblLike.TabIndex = 22;
            lblLike.Text = "lượt like";
            lblLike.Click += lblLike_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 25);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // lblIDCongTy
            // 
            lblIDCongTy.AutoSize = true;
            lblIDCongTy.BackColor = Color.Transparent;
            lblIDCongTy.ForeColor = Color.FromArgb(255, 224, 192);
            lblIDCongTy.Location = new Point(225, 123);
            lblIDCongTy.Name = "lblIDCongTy";
            lblIDCongTy.Size = new Size(77, 20);
            lblIDCongTy.TabIndex = 20;
            lblIDCongTy.Text = "ID CôngTy";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.ForeColor = Color.FromArgb(255, 224, 192);
            lblTaiKhoan.Location = new Point(198, 131);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(21, 20);
            lblTaiKhoan.TabIndex = 19;
            lblTaiKhoan.Text = "tk";
            // 
            // lblIDTinDang
            // 
            lblIDTinDang.AutoSize = true;
            lblIDTinDang.BackColor = Color.Transparent;
            lblIDTinDang.ForeColor = Color.FromArgb(255, 224, 192);
            lblIDTinDang.Location = new Point(239, 123);
            lblIDTinDang.Name = "lblIDTinDang";
            lblIDTinDang.Size = new Size(79, 20);
            lblIDTinDang.TabIndex = 18;
            lblIDTinDang.Text = "IDTinDang";
            // 
            // lblNgayDang
            // 
            lblNgayDang.AutoSize = true;
            lblNgayDang.BackColor = Color.Transparent;
            lblNgayDang.Location = new Point(239, 253);
            lblNgayDang.Name = "lblNgayDang";
            lblNgayDang.Size = new Size(97, 20);
            lblNgayDang.TabIndex = 17;
            lblNgayDang.Text = "lblNgayDang";
            // 
            // lblNganhNghe
            // 
            lblNganhNghe.AutoSize = true;
            lblNganhNghe.BackColor = Color.Transparent;
            lblNganhNghe.Location = new Point(167, 237);
            lblNganhNghe.Name = "lblNganhNghe";
            lblNganhNghe.Size = new Size(52, 20);
            lblNganhNghe.TabIndex = 15;
            lblNganhNghe.Text = "Cơ Khí";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(18, 186);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 25);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(18, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 25);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblViTRi
            // 
            lblViTRi.AutoSize = true;
            lblViTRi.BackColor = Color.Transparent;
            lblViTRi.ImageAlign = ContentAlignment.MiddleLeft;
            lblViTRi.Location = new Point(54, 227);
            lblViTRi.Name = "lblViTRi";
            lblViTRi.Size = new Size(83, 20);
            lblViTRi.TabIndex = 10;
            lblViTRi.Text = "Bình Phước";
            // 
            // btnDetail
            // 
            btnDetail.BackgroundImage = (Image)resources.GetObject("btnDetail.BackgroundImage");
            btnDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = SystemColors.ButtonHighlight;
            btnDetail.Location = new Point(167, 186);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(104, 49);
            btnDetail.TabIndex = 9;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // lblLuongMin
            // 
            lblLuongMin.AutoSize = true;
            lblLuongMin.BackColor = Color.Transparent;
            lblLuongMin.Location = new Point(50, 191);
            lblLuongMin.Name = "lblLuongMin";
            lblLuongMin.Size = new Size(33, 20);
            lblLuongMin.TabIndex = 8;
            lblLuongMin.Text = "150";
            // 
            // labelHVT
            // 
            labelHVT.AutoSize = true;
            labelHVT.BackColor = Color.Transparent;
            labelHVT.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHVT.ForeColor = Color.Gray;
            labelHVT.Location = new Point(16, 123);
            labelHVT.Name = "labelHVT";
            labelHVT.Size = new Size(102, 17);
            labelHVT.TabIndex = 7;
            labelHVT.Text = "Ô Tô Mercedes";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(14, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(322, 111);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = pictureBox6;
            // 
            // UserControlTinDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel6);
            Name = "UserControlTinDang";
            Size = new Size(359, 313);
            guna2Panel6.ResumeLayout(false);
            guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label lblViTRi;
        private Button btnDetail;
        private Label lblLuongMin;
        private Label labelHVT;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblChucVu;
        private Label lblNganhNghe;
        private Label lblNgayDang;
        private Label lblIDTinDang;
        private Label lblTaiKhoan;
        private Label lblIDCongTy;
        private Label lblLike;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblLuongMax;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
