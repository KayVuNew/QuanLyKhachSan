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
    public partial class MenuKeToan : Form
    {
        public MenuKeToan()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FromDoanhThu form2 = new FromDoanhThu();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
            btnDoanhThu.FillColor2 = Color.SlateGray;
            btnHoadon.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            HoaDonKeToan form2 = new HoaDonKeToan();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
            btnDoanhThu.FillColor2 = Color.FromArgb(40, 42, 52);
            btnHoadon.FillColor2 = Color.SlateGray;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FrmTranglogin login = new FrmTranglogin();
            login.Show();
            this.Hide();
        }

        private void MenuKeToan_Load(object sender, EventArgs e)
        {
            FromDoanhThu form2 = new FromDoanhThu();

            // Thêm Winform vào container control của Winform chính
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
            btnDoanhThu.FillColor2 = Color.SlateGray;
            btnHoadon.FillColor2 = Color.FromArgb(40, 42, 52);
        }
    }
}
