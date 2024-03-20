using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLV01
{
    public partial class FQuanLyLuanVan : Form
    {
        private GiangVienDao giangVienDao;
        public FQuanLyLuanVan()
        {
            InitializeComponent();
            giangVienDao = new GiangVienDao();
            DataTable dtGiangVien = giangVienDao.LoadQLLV();
            gvQLLV.DataSource = dtGiangVien;
            AddButtonColumn();
        }

        private void AddButtonColumn()
        {
            // Tạo một cột button mới
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Click Here";
            buttonColumn.UseColumnTextForButtonValue = true; // Đặt giá trị của nút bằng văn bản cột
            // Thêm cột button vào cuối DataGridView
            gvQLLV.Columns.Add(buttonColumn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ItThemLuanVan a = new ItThemLuanVan();
            a.ShowDialog();
            FQuanLyLuanVan_Load(sender, e);
        }

        private void FQuanLyLuanVan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtGiangVien = giangVienDao.LoadQLLV();
                gvQLLV.DataSource = dtGiangVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (gvQLLV.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn Yes
                if (result == DialogResult.Yes)
                {
                    // Lấy giá trị khóa chính của dòng được chọn (ví dụ: Mã luận văn)
                    string TenLuanVan = gvQLLV.SelectedRows[0].Cells["TênLuậnVăn"].Value.ToString();


                    giangVienDao.XoaLuanVan(TenLuanVan);

                    MessageBox.Show("Xóa luận văn thành công!");
                    FQuanLyLuanVan_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            ItDuyet x = new ItDuyet();
            x.ShowDialog();
        }
    }
}
