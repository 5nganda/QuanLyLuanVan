using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLV01
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Thucthi(string s)
        {
            try
            {
                // Ket noi
                conn.Open();

                SqlCommand cmd = new SqlCommand(s, conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    MessageBox.Show("Thành Công");
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Có ít nhất một hàng đã được thêm, sửa đổi hoặc xóa từ cơ sở dữ liệu
                    // Điều này có thể được sử dụng để thông báo cho người dùng hoặc xử lý tiếp theo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That Bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string s)
        {
            DataTable dtQuanLy = new DataTable();

            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
                adapter.Fill(dtQuanLy);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtQuanLy;
        }
    }
}
