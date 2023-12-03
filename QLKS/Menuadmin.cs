using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Menuadmin : Form
    {
        public Menuadmin()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            QLNV form2 = new QLNV();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
            guna2GradientButton1.FillColor2 = Color.SlateGray;
            guna2GradientButton2.FillColor2 = Color.FromArgb(40, 42, 52);

        }

        private void Menuadmin_Load(object sender, EventArgs e)
        {
            QLNV form2 = new QLNV();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FrmDichVu form2 = new FrmDichVu();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
            guna2GradientButton2.FillColor2 = Color.SlateGray;
            guna2GradientButton1.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FrmTranglogin login = new FrmTranglogin();
            login.Show();
            this.Hide();
        }
    }
}
