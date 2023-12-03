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
    public partial class HoaDonKeToan : Form
    {
        public HoaDonKeToan()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void HoaDonKeToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            var result = from HD in QLKS.HoaDons
                         join ptp in QLKS.Phieuthuephongs on HD.MaPhieuThuePhong equals ptp.MaPhieuThuePhong
                         join ctp in QLKS.ChiTietPhieuThues on ptp.MaPhieuThuePhong equals ctp.Maphieuthuephong
                         select new
                         {
                             MaHoaDon = HD.MaHoaDon,
                             TienPhong = HD.TienPhong,
                             TienDV = HD.TienDV,
                             TongTien = HD.TongTien,
                             HinhThucThanhToan = HD.HinhThucThanhToan,
                             NgayThanhToan = HD.NgayThanhToan,
                             GhiChu = HD.GhiChu,
                             KhachHang = ptp.KhachHang.TenKH,
                             NhanVien = ptp.NhanVien.HoTen,
                             Phong = ctp.Phong.TenPhong  // Room name from ChiTietPhieuThue
                         };
            dvThongTin.DataSource = result.ToList();
            // Set the column headers as needed
        }
    }
}
