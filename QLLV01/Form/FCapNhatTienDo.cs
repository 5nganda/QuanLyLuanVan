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
    public partial class FCapNhatTienDo : Form
    {
        public FCapNhatTienDo()
        {
            InitializeComponent();
        }

        private void FCapNhatTienDo_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(10);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Linh An";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Lam giao dien web de tot nghiep chu de ve moi truong cong ngh the he 4.0 hay cho biet em la ai trong khi ddo";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Web";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Lam giao dien web de tot nghiep chu de ve ";
            guna2DataGridView1.Rows[0].Cells[4].Value = "12/3/2024";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Thuy Linh";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Bao ve";
            guna2DataGridView1.Rows[1].Cells[2].Value = "App";
            guna2DataGridView1.Rows[1].Cells[3].Value = "IU";
            guna2DataGridView1.Rows[1].Cells[4].Value = "13/4/2024";

            guna2DataGridView1.Rows[2].Cells[0].Value = "123";
            guna2DataGridView1.Rows[2].Cells[1].Value = "123";
            guna2DataGridView1.Rows[2].Cells[2].Value = "123";
            guna2DataGridView1.Rows[2].Cells[3].Value = "123";
            guna2DataGridView1.Rows[2].Cells[4].Value = "123";

            guna2DataGridView1.Rows[3].Cells[0].Value = "123";
            guna2DataGridView1.Rows[3].Cells[1].Value = "123";
            guna2DataGridView1.Rows[3].Cells[2].Value = "123";
            guna2DataGridView1.Rows[3].Cells[3].Value = "123";
            guna2DataGridView1.Rows[3].Cells[4].Value = "123";

            guna2DataGridView1.Rows[4].Cells[0].Value = "123";
            guna2DataGridView1.Rows[4].Cells[1].Value = "123";
            guna2DataGridView1.Rows[4].Cells[2].Value = "123";
            guna2DataGridView1.Rows[4].Cells[3].Value = "123";
            guna2DataGridView1.Rows[4].Cells[4].Value = "123";

            guna2DataGridView1.Rows[5].Cells[0].Value = "123";
            guna2DataGridView1.Rows[5].Cells[1].Value = "321";
            guna2DataGridView1.Rows[5].Cells[2].Value = "123";
            guna2DataGridView1.Rows[5].Cells[3].Value = "123";
            guna2DataGridView1.Rows[5].Cells[4].Value = "145";

            guna2DataGridView1.Rows[6].Cells[0].Value = "123";
            guna2DataGridView1.Rows[6].Cells[1].Value = "123";
            guna2DataGridView1.Rows[6].Cells[2].Value = "123";
            guna2DataGridView1.Rows[6].Cells[3].Value = "123";
            guna2DataGridView1.Rows[6].Cells[4].Value = "123";

            guna2DataGridView1.Rows[7].Cells[0].Value = "123";
            guna2DataGridView1.Rows[7].Cells[1].Value = "123";
            guna2DataGridView1.Rows[7].Cells[2].Value = "123";
            guna2DataGridView1.Rows[7].Cells[3].Value = "123";
            guna2DataGridView1.Rows[7].Cells[4].Value = "123";

            guna2DataGridView1.Rows[8].Cells[0].Value = "123";
            guna2DataGridView1.Rows[8].Cells[1].Value = "123";
            guna2DataGridView1.Rows[8].Cells[2].Value = "123";
            guna2DataGridView1.Rows[8].Cells[3].Value = "123";
            guna2DataGridView1.Rows[8].Cells[4].Value = "123";

            guna2DataGridView1.Rows[9].Cells[0].Value = "123";
            guna2DataGridView1.Rows[9].Cells[1].Value = "123";
            guna2DataGridView1.Rows[9].Cells[2].Value = "123";
            guna2DataGridView1.Rows[9].Cells[3].Value = "123";
            guna2DataGridView1.Rows[9].Cells[4].Value = "123";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ItCapNhatLuanVan f = new ItCapNhatLuanVan();
            f.Show();
        }
    }
}
