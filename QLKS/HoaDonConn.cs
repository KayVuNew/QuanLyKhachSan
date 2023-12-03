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
    public partial class HoaDonConn : Form
    {
        public HoaDonConn()
        {
            InitializeComponent();
        }
        private string maHD, tenPG, KH, hthuc, gchu, nvien;
        private int  ttien,tienDV,tienPg;
        private DateTime ngthanhtoan;
        public HoaDonConn(string maHD,string KH,string hthuc,string tenPg,string gchu, string nvien, int ttien,int tienDV,int tienPg,DateTime ngthanht)
        {
            InitializeComponent();
            this.maHD = maHD;
            this.KH = KH;
            this.hthuc = hthuc;
            this.tenPG = tenPg;
            this.gchu = gchu;
            this.nvien = nvien;
            this.ttien = ttien;
            this.tienDV = tienDV;
            this.tienPg = tienPg;
            this.ngthanhtoan = ngthanht;
        }
        private void HoaDonConn_Load(object sender, EventArgs e)
        {
            mahoadon.Text = maHD;
            khachhang.Text = KH;
            tiendichvu.Text = tienDV.ToString();
            tienphong.Text = tienPg.ToString();
            nhanvien.Text = nvien;
            ghichu.Text = gchu;
            tongtien.Text = ttien.ToString();
            hinhthuc.Text = hthuc;
            phong.Text = tenPG;
            lblngaythanhtoan.Text = ngthanhtoan.ToString();
        }
    }
}
