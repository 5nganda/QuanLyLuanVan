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
    public partial class FDangKyLuanVan : Form
    {
        private SinhVienDao sinhVienDao;
        public FDangKyLuanVan()
        {
            InitializeComponent();
            sinhVienDao = new SinhVienDao();
        }

        private void FDangKyLuanVan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSinhVien = sinhVienDao.Load();
                gvDKLV.DataSource = dtSinhVien;
                // Xử lý sự kiện khi nút được click
                //dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            gvDKLV.Rows.Add(10);
            gvDKLV.Rows[0].Cells[0].Value = "Linh An";
            gvDKLV.Rows[0].Cells[1].Value = "Lam giao dien web de tot nghiep chu de ve moi truong cong ngh the he 4.0 hay cho biet em la ai trong khi ddo";
            gvDKLV.Rows[0].Cells[2].Value = "Web";
            gvDKLV.Rows[0].Cells[3].Value = "Lam giao dien web de tot nghiep chu de ve ";
            gvDKLV.Rows[0].Cells[4].Value = "12/3/2024";
            gvDKLV.Rows[0].Cells[5].Value = "5";

            gvDKLV.Rows[1].Cells[0].Value = "Thuy Linh";
            gvDKLV.Rows[1].Cells[1].Value = "Bao ve";
            gvDKLV.Rows[1].Cells[2].Value = "App";
            gvDKLV.Rows[1].Cells[3].Value = "IU";
            gvDKLV.Rows[1].Cells[4].Value = "13/4/2024";
            gvDKLV.Rows[1].Cells[5].Value = "6";
            //guna2DataGridView1.Rows[1].Cells[6].Value = "Con cho";

            gvDKLV.Rows[2].Cells[0].Value = "123";
            gvDKLV.Rows[2].Cells[1].Value = "123";
            gvDKLV.Rows[2].Cells[2].Value = "123";
            gvDKLV.Rows[2].Cells[3].Value = "123";
            gvDKLV.Rows[2].Cells[4].Value = "123";
            gvDKLV.Rows[2].Cells[5].Value = "123";

            gvDKLV.Rows[3].Cells[0].Value = "123";
            gvDKLV.Rows[3].Cells[1].Value = "123";
            gvDKLV.Rows[3].Cells[2].Value = "123";
            gvDKLV.Rows[3].Cells[3].Value = "123";
            gvDKLV.Rows[3].Cells[4].Value = "123";
            gvDKLV.Rows[3].Cells[5].Value = "123";

            gvDKLV.Rows[4].Cells[0].Value = "123";
            gvDKLV.Rows[4].Cells[1].Value = "123";
            gvDKLV.Rows[4].Cells[2].Value = "123";
            gvDKLV.Rows[4].Cells[3].Value = "123";
            gvDKLV.Rows[4].Cells[4].Value = "123";
            gvDKLV.Rows[4].Cells[5].Value = "123";

            gvDKLV.Rows[5].Cells[0].Value = "123";
            gvDKLV.Rows[5].Cells[1].Value = "321";
            gvDKLV.Rows[5].Cells[2].Value = "123";
            gvDKLV.Rows[5].Cells[3].Value = "123";
            gvDKLV.Rows[5].Cells[4].Value = "145";
            gvDKLV.Rows[5].Cells[5].Value = "123";

            gvDKLV.Rows[6].Cells[0].Value = "123";
            gvDKLV.Rows[6].Cells[1].Value = "123";
            gvDKLV.Rows[6].Cells[2].Value = "123";
            gvDKLV.Rows[6].Cells[3].Value = "123";
            gvDKLV.Rows[6].Cells[4].Value = "123";
            gvDKLV.Rows[6].Cells[5].Value = "123";

            gvDKLV.Rows[7].Cells[0].Value = "123";
            gvDKLV.Rows[7].Cells[1].Value = "123";
            gvDKLV.Rows[7].Cells[2].Value = "123";
            gvDKLV.Rows[7].Cells[3].Value = "123";
            gvDKLV.Rows[7].Cells[4].Value = "123";
            gvDKLV.Rows[7].Cells[5].Value = "123";

            gvDKLV.Rows[8].Cells[0].Value = "123";
            gvDKLV.Rows[8].Cells[1].Value = "123";
            gvDKLV.Rows[8].Cells[2].Value = "123";
            gvDKLV.Rows[8].Cells[3].Value = "123";
            gvDKLV.Rows[8].Cells[4].Value = "123";
            gvDKLV.Rows[8].Cells[5].Value = "123";

            gvDKLV.Rows[9].Cells[0].Value = "123";
            gvDKLV.Rows[9].Cells[1].Value = "123";
            gvDKLV.Rows[9].Cells[2].Value = "123";
            gvDKLV.Rows[9].Cells[3].Value = "123";
            gvDKLV.Rows[9].Cells[4].Value = "123";
            gvDKLV.Rows[9].Cells[5].Value = "123";
            gvDKLV.Rows[9].Cells[0].Value = "123";
        }

        private void btnDeXuat_Click(object sender, EventArgs e)
        {
            ItThemLuanVanSV x = new ItThemLuanVanSV();
            x.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (gvDKLV.SelectedRows.Count > 0)
            {
                string tenLuanvan = gvDKLV.SelectedRows[0].Cells["TênLuậnVăn"].Value.ToString();
                string tenGiangVien = gvDKLV.SelectedRows[0].Cells["TênGiảngViên"].Value.ToString();
                string phanLoai = gvDKLV.SelectedRows[0].Cells["PhânLoại"].Value.ToString();
                string noiDung = gvDKLV.SelectedRows[0].Cells["NộiDung"].Value.ToString();
                string soluongthanhvien = gvDKLV.SelectedRows[0].Cells["SốLượngThànhViên"].Value.ToString();

                //It1 x = new It1();
                //x.Showw(tenLuanvan, tenGiangVien, phanLoai, noiDung, soluongthanhvien);
                //x.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để đăng kí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
