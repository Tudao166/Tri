namespace WinFormsApp4
{
    partial class FDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangKi));
            buttonDangKi = new Button();
            pictureBox2 = new PictureBox();
            txtMK1 = new TextBox();
            pictureBoxTK = new PictureBox();
            txtTK = new TextBox();
            panelDangKi = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            txtGmail = new TextBox();
            pictureBox3 = new PictureBox();
            txtMK2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTK).BeginInit();
            panelDangKi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDangKi
            // 
            buttonDangKi.BackColor = SystemColors.ActiveCaption;
            buttonDangKi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDangKi.ForeColor = SystemColors.ActiveCaptionText;
            buttonDangKi.Location = new Point(204, 245);
            buttonDangKi.Margin = new Padding(3, 4, 3, 4);
            buttonDangKi.Name = "buttonDangKi";
            buttonDangKi.Size = new Size(121, 38);
            buttonDangKi.TabIndex = 17;
            buttonDangKi.Text = "Đăng kí";
            buttonDangKi.UseVisualStyleBackColor = false;
            buttonDangKi.Click += buttonDangKi_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 129);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtMK1
            // 
            txtMK1.BackColor = Color.White;
            txtMK1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK1.ForeColor = SystemColors.InactiveCaption;
            txtMK1.Location = new Point(90, 127);
            txtMK1.Margin = new Padding(3, 2, 3, 2);
            txtMK1.Name = "txtMK1";
            txtMK1.Size = new Size(397, 28);
            txtMK1.TabIndex = 13;
            // 
            // pictureBoxTK
            // 
            pictureBoxTK.Image = (Image)resources.GetObject("pictureBoxTK.Image");
            pictureBoxTK.Location = new Point(56, 88);
            pictureBoxTK.Margin = new Padding(3, 2, 3, 2);
            pictureBoxTK.Name = "pictureBoxTK";
            pictureBoxTK.Size = new Size(28, 28);
            pictureBoxTK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTK.TabIndex = 12;
            pictureBoxTK.TabStop = false;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.White;
            txtTK.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.ForeColor = SystemColors.InactiveCaption;
            txtTK.Location = new Point(90, 86);
            txtTK.Margin = new Padding(3, 2, 3, 2);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(397, 28);
            txtTK.TabIndex = 11;
            txtTK.Leave += textBoxTaiKhoan_Leave;
            // 
            // panelDangKi
            // 
            panelDangKi.Controls.Add(radioButton2);
            panelDangKi.Controls.Add(radioButton1);
            panelDangKi.Controls.Add(button1);
            panelDangKi.Controls.Add(txtGmail);
            panelDangKi.Controls.Add(pictureBox3);
            panelDangKi.Controls.Add(txtMK2);
            panelDangKi.Controls.Add(pictureBox1);
            panelDangKi.Controls.Add(txtTK);
            panelDangKi.Controls.Add(buttonDangKi);
            panelDangKi.Controls.Add(pictureBoxTK);
            panelDangKi.Controls.Add(txtMK1);
            panelDangKi.Controls.Add(pictureBox2);
            panelDangKi.Location = new Point(12, 4);
            panelDangKi.Margin = new Padding(3, 4, 3, 4);
            panelDangKi.Name = "panelDangKi";
            panelDangKi.Size = new Size(537, 290);
            panelDangKi.TabIndex = 18;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(39, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(147, 24);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Người Ứng Tuyển";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(39, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Công Ty";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(494, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 43);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtGmail
            // 
            txtGmail.BackColor = Color.White;
            txtGmail.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGmail.ForeColor = SystemColors.InactiveCaption;
            txtGmail.Location = new Point(90, 211);
            txtGmail.Margin = new Padding(3, 2, 3, 2);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(397, 28);
            txtGmail.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 213);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // txtMK2
            // 
            txtMK2.BackColor = Color.White;
            txtMK2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK2.ForeColor = SystemColors.InactiveCaption;
            txtMK2.Location = new Point(90, 169);
            txtMK2.Margin = new Padding(3, 2, 3, 2);
            txtMK2.Name = "txtMK2";
            txtMK2.Size = new Size(397, 28);
            txtMK2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 171);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FDangKi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 310);
            ControlBox = false;
            Controls.Add(panelDangKi);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(6, 1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FDangKi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKi";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTK).EndInit();
            panelDangKi.ResumeLayout(false);
            panelDangKi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonDangKi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMK1;
        private System.Windows.Forms.PictureBox pictureBoxTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Panel panelDangKi;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}