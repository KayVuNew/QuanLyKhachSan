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
    public partial class Form1 : Form
    {
        QLKSEntities QLKS = new QLKSEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var result = from p in QLKS.Phong
                         join LP in QLKS.LoaiPhong on p.MaLoai equals LP.MaLoai
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenPhong = txtTim.Text.Trim(); // Lọc dựa trên tên phòng

            try
            {
                var ketQua = (from p in QLKS.Phong
                              join LP in QLKS.LoaiPhong on p.MaLoai equals LP.MaLoai
                              where p.TenPhong.Contains(tenPhong)
                              select new
                              {
                                  MaPhong = p.MaPhong,
                                  TenLoai = LP.TenLoai,
                                  TenPhong = p.TenPhong,
                                  TinhTrang = p.TinhTrang,
                                  DienTich = p.DienTich,
                                  GiaThue = p.GiaThue,

                              }).ToList();

                if (ketQua.Any())
                {
                    dvThongTin.DataSource = ketQua;
                    MessageBox.Show("Đã tìm thấy phòng");
                }
                else
                {
                    dvThongTin.DataSource = null;
                    MessageBox.Show("Không tìm thấy phòng có tên chứa " + tenPhong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                // Thực hiện đăng nhập lỗi hoặc các hành động cần thiết khác
            }
        }
    }
}
