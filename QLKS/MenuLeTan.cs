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
    public partial class MenuLeTan : Form
    {
        public MenuLeTan()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang KH = new FrmKhachHang();

            // Thêm Winform vào container control của Winform chính
            KH.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(KH);
            KH.Show();
            btnKhachHang.FillColor2 = Color.SlateGray;
            btnHoaDon.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDSPhong.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDKDV.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDatPhong.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void btnDSPhong_Click(object sender, EventArgs e)
        {
            DanhSachPhong dsp = new DanhSachPhong();

            // Thêm Winform vào container control của Winform chính
            dsp.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(dsp);
            dsp.Show();
            btnKhachHang.FillColor2 = Color.FromArgb(40, 42, 52);
            btnHoaDon.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDSPhong.FillColor2 = Color.SlateGray;
            btnDKDV.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDatPhong.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FrmPhieuThuePhong ptp = new FrmPhieuThuePhong();

            // Thêm Winform vào container control của Winform chính
            ptp.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(ptp);
            ptp.Show();
            btnKhachHang.FillColor2 = Color.FromArgb(40, 42, 52);
            btnHoaDon.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDSPhong.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDKDV.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDatPhong.FillColor2 = Color.SlateGray;
        }

        private void btnDKDV_Click(object sender, EventArgs e)
        {
            DangKyDichVu dkdv = new DangKyDichVu();

            // Thêm Winform vào container control của Winform chính
            dkdv.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(dkdv);
            dkdv.Show();
            btnKhachHang.FillColor2 = Color.FromArgb(40, 42, 52);
            btnHoaDon.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDSPhong.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDKDV.FillColor2 = Color.SlateGray;
            btnDatPhong.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon hd = new FrmHoaDon();

            // Thêm Winform vào container control của Winform chính
            hd.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(hd);
            hd.Show();
            btnKhachHang.FillColor2 = Color.FromArgb(40, 42, 52);
            btnHoaDon.FillColor2 = Color.SlateGray;
            btnDSPhong.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDKDV.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDatPhong.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void MenuLeTan_Load(object sender, EventArgs e)
        {
            FrmKhachHang KH = new FrmKhachHang();

            // Thêm Winform vào container control của Winform chính
            KH.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(KH);
            KH.Show();
            btnKhachHang.FillColor2 = Color.SlateGray;
            btnHoaDon.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDSPhong.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDKDV.FillColor2 = Color.FromArgb(40, 42, 52);
            btnDatPhong.FillColor2 = Color.FromArgb(40, 42, 52);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FrmTranglogin login = new FrmTranglogin();
            login.Show();
            this.Hide();
        }
    }
}
