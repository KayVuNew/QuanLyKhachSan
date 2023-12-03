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
    public partial class FromDoanhThu : Form
    {
        public FromDoanhThu()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void FromDoanhThu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            var result =
            from HD in QLKS.HoaDons
            join ptp in QLKS.Phieuthuephongs on HD.MaPhieuThuePhong equals ptp.MaPhieuThuePhong
            join ctp in QLKS.ChiTietPhieuThues on ptp.MaPhieuThuePhong equals ctp.Maphieuthuephong
            group HD by new
            {
                ptp.KhachHang.TenKH,
                ptp.NhanVien.HoTen,
                ctp.Phong.TenPhong
            } into g
            select new
            {
                TienPhong = g.Sum(x => x.TienPhong),
                TienDV = g.Sum(x => x.TienDV),
                TongTien = g.Sum(x => x.TienPhong + x.TienDV),
                KhachHang = g.Key.TenKH,
                NhanVien = g.Key.HoTen,
                Phong = g.Key.TenPhong
            };

         dvDoanhthu.DataSource = result.ToList();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Excel mới
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Tạo một Workbook mới
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Tạo một Worksheet mới
            Microsoft.Office.Interop.Excel.Worksheet sheet = null;
            sheet = workbook.Sheets["Sheet1"];
            sheet = workbook.ActiveSheet;

            // Đặt tiêu đề cho các cột
            for (int i = 1; i <= dvDoanhthu.Columns.Count; i++)
            {
                sheet.Cells[1, i] = dvDoanhthu.Columns[i - 1].HeaderText;
            }

            // Thêm dữ liệu từ DataGridView vào Worksheet
            for (int i = 0; i < dvDoanhthu.Rows.Count; i++)
            {
                for (int j = 0; j < dvDoanhthu.Columns.Count; j++)
                {
                    if (dvDoanhthu.Rows[i].Cells[j].Value != null)
                    {
                        sheet.Cells[i + 2, j + 1] = dvDoanhthu.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            // Lưu Workbook vào một tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Đóng Workbook và Excel
            workbook.Close();
            excel.Quit();
        }
    }
}
