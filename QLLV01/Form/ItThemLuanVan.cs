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
    public partial class ItThemLuanVan : Form
    {
        private GiangVienDao giangVienDao;
        public ItThemLuanVan(GiangVienDao dao)
        {
            InitializeComponent();
            giangVienDao = dao;
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLuanVan = txtTenLuanVan.Text;
            string phanLoai = txtPhanLoai.Text;
            string soLuong = txtSoLuong.Text;
            string sltv = txtSoLuongTV.Text;
            string noiDung = txtNoiDung.Text;
            DateTime hanCuoiDangKi = dtpHanCuoi.Value.Date;

            giangVienDao.ThemLuanVan(tenLuanVan, phanLoai, soLuong, sltv, noiDung, hanCuoiDangKi);
            MessageBox.Show("Thêm luận văn thành công!");
            // Sau khi thêm xong, đóng form
            this.Close();
        }
    }
}
