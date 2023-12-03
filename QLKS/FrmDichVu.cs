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
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }
        int makhoachinh;
        public static List<DichVu> laydsdichvu()
        {
            List<DichVu> dsLoai = new List<DichVu>();
            using (Nhom3_Duan1_QuanLiKhachSanEntities csharpDB = new Nhom3_Duan1_QuanLiKhachSanEntities())
            {
                dsLoai = csharpDB.DichVus.ToList();
            }
            return dsLoai;
        }
        public static List<LoaiDichVu> laydsloaidv()
        {
            List<LoaiDichVu> dsLoai = new List<LoaiDichVu>();
            using (Nhom3_Duan1_QuanLiKhachSanEntities csharpDB = new Nhom3_Duan1_QuanLiKhachSanEntities())
            {
                dsLoai = csharpDB.LoaiDichVus.ToList();
            }
            return dsLoai;
        }
        List<LoaiDichVu> dsloaidv;
        List<DichVu> dsdichvu;
        private void btthem_Click(object sender, EventArgs e)
        {
            if (txttdv.Text == "")
            {
                MessageBox.Show("Tên dịch vụ không hợp lệ vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (double.Parse(txtdongia.Text) <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (Nhom3_Duan1_QuanLiKhachSanEntities csharpDB = new Nhom3_Duan1_QuanLiKhachSanEntities())
                {
                    DichVu pmAdd = new DichVu();
                    pmAdd.TenDV = txttdv.Text;
                    pmAdd.DonGia = double.Parse(txtdongia.Text);
                    var loaiDV = csharpDB.LoaiDichVus.FirstOrDefault(dv => dv.TenLoaiDV == cmxloaidv.Text);
                    pmAdd.MaLoaiDV = loaiDV.MaLoaiDV;
                    csharpDB.DichVus.Add(pmAdd);
                    csharpDB.SaveChanges();
                }
                MessageBox.Show("Thêm thành công");
                this.updateDataGridView();
            }
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void updateDataGridView()
        {
            var result = from kh in QLKS.DichVus
                         select new
                         {
                             MaDV = kh.MaDV,
                             TenDV = kh.TenDV,
                             DonGia = kh.DonGia,
                             TenLoaiDV = kh.LoaiDichVu.TenLoaiDV,
                         };
            metroGrid1.DataSource = result.ToList();

            metroGrid1.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            metroGrid1.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            metroGrid1.Columns["DonGia"].HeaderText = "Đơn giá";
            metroGrid1.Columns["TenLoaiDV"].HeaderText = "Loại dịch vụ";
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            using (Nhom3_Duan1_QuanLiKhachSanEntities csharpDB = new Nhom3_Duan1_QuanLiKhachSanEntities())
            {
                DichVu found = csharpDB.DichVus
                      .FirstOrDefault(sp => sp.MaDV == makhoachinh);
                found.TenDV = txttdv.Text;
                found.DonGia = double.Parse(txtdongia.Text);
                found.MaLoaiDV = int.Parse(cmxloaidv.Text);

                csharpDB.SaveChanges();
            }
            this.updateDataGridView();
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            using (Nhom3_Duan1_QuanLiKhachSanEntities csharpDB = new Nhom3_Duan1_QuanLiKhachSanEntities())
            {
                DichVu found = csharpDB.DichVus
                      .FirstOrDefault(sp => sp.MaDV == makhoachinh);
                csharpDB.DichVus.Remove(found);
                csharpDB.SaveChanges();
            }
            this.updateDataGridView();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            dsloaidv = laydsloaidv();
            dsloaidv.ForEach(x => cmxloaidv.Items.Add(x.TenLoaiDV));
            this.updateDataGridView();
        }

        private void metroGrid1_Click_1(object sender, EventArgs e)
        {
            int list = metroGrid1.CurrentRow.Index;
            txttdv.Text = metroGrid1.Rows[list].Cells[1].Value.ToString();
            txtdongia.Text = metroGrid1.Rows[list].Cells[2].Value.ToString();
            cmxloaidv.Text = metroGrid1.Rows[list].Cells[3].Value.ToString();
        }
    }
}
