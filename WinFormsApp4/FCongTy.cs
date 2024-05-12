using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class FCongTy : Form
    {
        private int pictureSlide = 1;
        public FCongTy(string taikhoan)
        {
            InitializeComponent();
            pictureBox2.Hide();
            lblTaiKhoan.Text = taikhoan;
        }
        private void Slider()
        {
            if (pictureSlide % 2 == 1)
            {
                pictureBox1.Show();
                pictureBox2.Hide();
            }
            else
            {
                pictureBox1.Hide();
                pictureBox2.Show();
            }
            pictureSlide++;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCongTy ct = new FCongTy(lblTaiKhoan.Text);
            ct.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTimViec(lblTaiKhoan.Text));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAddTinDang(lblTaiKhoan.Text));
        }
        private void button7_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FAddCV(lblTaiKhoan.Text));

        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCVGide(null,null,null));
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAddCongTy(lblTaiKhoan.Text));
        }
        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuDangTin(lblTaiKhoan.Text));

        }
   

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuUngTuyen(null,lblTaiKhoan.Text));
        }
    }
}
