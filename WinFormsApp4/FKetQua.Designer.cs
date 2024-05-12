namespace WinFormsApp4
{
    partial class FKetQua
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
            label1 = new Label();
            PanelKetQua = new FlowLayoutPanel();
            lblIDCongTy = new Label();
            lblIDTinDang = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Kết Quả";
            // 
            // PanelKetQua
            // 
            PanelKetQua.BackColor = Color.FromArgb(255, 224, 192);
            PanelKetQua.Location = new Point(29, 78);
            PanelKetQua.Name = "PanelKetQua";
            PanelKetQua.Size = new Size(997, 540);
            PanelKetQua.TabIndex = 1;
            // 
            // lblIDCongTy
            // 
            lblIDCongTy.AutoSize = true;
            lblIDCongTy.Location = new Point(127, 9);
            lblIDCongTy.Name = "lblIDCongTy";
            lblIDCongTy.Size = new Size(73, 20);
            lblIDCongTy.TabIndex = 2;
            lblIDCongTy.Text = "IDCongTy";
            // 
            // lblIDTinDang
            // 
            lblIDTinDang.AutoSize = true;
            lblIDTinDang.Location = new Point(16, 9);
            lblIDTinDang.Name = "lblIDTinDang";
            lblIDTinDang.Size = new Size(79, 20);
            lblIDTinDang.TabIndex = 3;
            lblIDTinDang.Text = "IDTinDang";
            // 
            // FKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 651);
            Controls.Add(lblIDTinDang);
            Controls.Add(lblIDCongTy);
            Controls.Add(PanelKetQua);
            Controls.Add(label1);
            Name = "FKetQua";
            Text = "FKetQua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel PanelKetQua;
        private Label lblIDCongTy;
        private Label lblIDTinDang;
    }
}