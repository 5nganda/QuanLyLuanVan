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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void container(object _form)
        {
            if (pn_Container.Controls.Count > 0) pn_Container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pn_Container.Controls.Add(fm);
            pn_Container.Tag = fm;
            fm.Show();
        }

        private void btnQuanLyLuanVan_Click(object sender, EventArgs e)
        {
            lblVal.Text = "Quản lý luận văn";
            picVal.Image = Properties.Resources.manage;
            container(new FQuanLyLuanVan());
            txtTimKiem.Visible = true;
            btnTimKiem.Visible = true;
            rbChuaHoanThanh.Visible = false;
            rbDaHoanThanh.Visible = false;
        }

        private void btnKiemTraTienDo_Click(object sender, EventArgs e)
        {
            lblVal.Text = "Kiểm tra tiến độ";
            picVal.Image = Properties.Resources.check;
            container(new FKiemTraTienDo());
            txtTimKiem.Visible = true;
            btnTimKiem.Visible = true;
            rbChuaHoanThanh.Visible = true;
            rbDaHoanThanh.Visible = true;
        }

        private void btnDangKyLuanVan_Click(object sender, EventArgs e)
        {
            lblVal.Text = "Đăng ký luận văn";
            picVal.Image = Properties.Resources.edit;
            txtTimKiem.Visible = true;
            btnTimKiem.Visible = true;
            rbChuaHoanThanh.Visible = false;
            rbDaHoanThanh.Visible = false;
            container(new FDangKyLuanVan());
        }

        private void btnCapNhatTienDo_Click(object sender, EventArgs e)
        {
            lblVal.Text = "Cập nhật tiến độ";
            picVal.Image = Properties.Resources.update;
            txtTimKiem.Visible = false;
            btnTimKiem.Visible = false;
            rbChuaHoanThanh.Visible = false;
            rbDaHoanThanh.Visible = false;
            container(new FCapNhatTienDo());
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            lblVal.Text = "Thông tin cá nhân";
            picVal.Image = Properties.Resources.user__1_;
            container(new FThongTinCaNhan());
            txtTimKiem.Visible = false;
            btnTimKiem.Visible = false;
            rbChuaHoanThanh.Visible = false;
            rbDaHoanThanh.Visible = false;
        }
    }
}
