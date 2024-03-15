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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        bool CheckLogin(string userName, string passWord)
        {
            for (int i = 0; i < ListUser.Instance.ListAccountUser.Count; i++)
            {
                if (userName == ListUser.Instance.ListAccountUser[i].UserName && passWord == ListUser.Instance.ListAccountUser[i].Password)
                    return true;
            }
            return false;
        }

        private void cbHienMatKhau_Click_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !cbHienMatKhau.Checked;
        }

        private void cbHienMatKhau_ChangeUICues_1(object sender, UICuesEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !cbHienMatKhau.Checked;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (CheckLogin(userName, passWord))
            {
                FMain f = new FMain();
                f.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mat khau hoac mat khau", "Loi", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
            }
        }
    }
}
