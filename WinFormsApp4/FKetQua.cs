using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FKetQua : Form
    {
        CongTyDAO ctDAO; // Declare the variable for CongTyDAO

        public FKetQua(string idtd)
        {
            InitializeComponent();
            lblIDTinDang.Text = idtd;

            // Create an instance of CongTyDAO (assuming it has a default constructor)
            ctDAO = new CongTyDAO();

            LoadData();
        }

        private void LoadData()
        {
            if (ctDAO != null) // Check if ctDAO is initialized before using it
            {
                List<LichSuUngTuyen> lichSus = ctDAO.LoadKetQua(lblIDTinDang.Text);
                if (lichSus.Count > 0)
                {
                    foreach (LichSuUngTuyen ls in lichSus)
                    {
                        PanelKetQua.Controls.Add(new UserControlKetQua(ls));
                    }
                }
            }
            else
            {
                // Handle the case where ctDAO initialization failed (e.g., show error message)
                MessageBox.Show("Failed to initialize CongTyDAO. Data loading unavailable.");
            }
        }
    }
}