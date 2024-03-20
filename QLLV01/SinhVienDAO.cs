using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLV01
{
    public class SinhVienDao
    {
        public DataTable LoadCNLV()
        {
            string sqlStr = "SELECT TênLuậnVăn,Nhóm,TàiLiệuBáoCáo,TiếnĐộ,Điểm,NhậnXét FROM TienDo WHERE TrạngThái = 1";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = "SELECT TênGiảngViên,TênLuậnVăn,PhânLoại,SốLượngCònLại,SốLượngThànhViên,NộiDung,HạnCuốiĐăngKí FROM QuanLyLuanVan";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void Thucthi(string s)
        {
            DBConnection db = new DBConnection();
            db.Thucthi(s);
        }
    }
}
