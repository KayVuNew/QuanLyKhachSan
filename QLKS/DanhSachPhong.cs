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
    public partial class DanhSachPhong : Form
    {
        public DanhSachPhong()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            var result = from p in QLKS.Phongs
                         join LP in QLKS.LoaiPhongs on p.MaLoai equals LP.MaLoai
                         select new
                         {
                             MaPhong = p.MaPhong,
                             TenLoai = LP.TenLoai,
                             TenPhong = p.TenPhong,
                             TinhTrang = p.TinhTrang,
                             DienTich = p.DienTich,
                             GiaThue = p.GiaThue,
                         };

            dvThongTin.DataSource = result.ToList();

            dvThongTin.Columns["MaPhong"].HeaderText = "Mã phòng";
            dvThongTin.Columns["TenPhong"].HeaderText = "Tên phòng";
            dvThongTin.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dvThongTin.Columns["DienTich"].HeaderText = "Diện tích";
            dvThongTin.Columns["GiaThue"].HeaderText = "Giá thuê";
            dvThongTin.Columns["TenLoai"].HeaderText = "Tên loại";
        }
    }
}
