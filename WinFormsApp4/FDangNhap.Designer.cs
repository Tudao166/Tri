using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp4
{
    partial class FDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtTK = new TextBox();
            pictureBoxTK = new PictureBox();
            txtMK = new TextBox();
            pictureBox2 = new PictureBox();
            linkLabelDangki = new LinkLabel();
            buttonDangNhap = new Button();
            panelDangNhap = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.White;
            txtTK.Font = new System.Drawing.Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.ForeColor = SystemColors.InactiveCaption;
            txtTK.Location = new Point(224, 69);
            txtTK.Margin = new Padding(3, 2, 3, 2);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(311, 28);
            txtTK.TabIndex = 3;
            // 
            // pictureBoxTK
            // 
            pictureBoxTK.Image = (System.Drawing.Image)resources.GetObject("pictureBoxTK.Image");
            pictureBoxTK.Location = new Point(190, 69);
            pictureBoxTK.Margin = new Padding(3, 2, 3, 2);
            pictureBoxTK.Name = "pictureBoxTK";
            pictureBoxTK.Size = new Size(28, 28);
            pictureBoxTK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTK.TabIndex = 4;
            pictureBoxTK.TabStop = false;
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.White;
            txtMK.Font = new System.Drawing.Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.ForeColor = SystemColors.InactiveCaption;
            txtMK.Location = new Point(224, 114);
            txtMK.Margin = new Padding(3, 2, 3, 2);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(311, 28);
            txtMK.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 114);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // linkLabelDangki
            // 
            linkLabelDangki.AutoSize = true;
            linkLabelDangki.Location = new Point(471, 172);
            linkLabelDangki.Name = "linkLabelDangki";
            linkLabelDangki.Size = new Size(64, 20);
            linkLabelDangki.TabIndex = 8;
            linkLabelDangki.TabStop = true;
            linkLabelDangki.Text = "Đăng kí ";
            linkLabelDangki.LinkClicked += linkLabelDangkiLinkClicked;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.BackColor = SystemColors.ActiveCaption;
            buttonDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            buttonDangNhap.Location = new Point(310, 148);
            buttonDangNhap.Margin = new Padding(3, 4, 3, 4);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(121, 48);
            buttonDangNhap.TabIndex = 9;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.UseVisualStyleBackColor = false;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // panelDangNhap
            // 
            panelDangNhap.Controls.Add(radioButton2);
            panelDangNhap.Controls.Add(radioButton1);
            panelDangNhap.Controls.Add(buttonDangNhap);
            panelDangNhap.Controls.Add(linkLabelDangki);
            panelDangNhap.Controls.Add(pictureBox2);
            panelDangNhap.Controls.Add(txtMK);
            panelDangNhap.Controls.Add(pictureBoxTK);
            panelDangNhap.Controls.Add(txtTK);
            panelDangNhap.Controls.Add(pictureBox1);
            panelDangNhap.Controls.Add(label1);
            panelDangNhap.Location = new Point(6, 1);
            panelDangNhap.Margin = new Padding(3, 2, 3, 2);
            panelDangNhap.Name = "panelDangNhap";
            panelDangNhap.Size = new Size(547, 207);
            panelDangNhap.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(337, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(147, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Người Ứng Tuyển";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(212, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Công Ty";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 216);
            Controls.Add(panelDangNhap);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDangNhap.ResumeLayout(false);
            panelDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtTK;
        private PictureBox pictureBoxTK;
        private TextBox txtMK;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelDangki;
        private Button buttonDangNhap;
        private Panel panelDangNhap;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}