using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLV01
{
    public class GiangVienDao
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void ThemLuanVan(string TenLuanVan, string PhanLoai, string SoLuong, string SoLuongTv, string Noidung, DateTime HanCuoiDangKi)
        {
            string SQL = string.Format("INSERT INTO QuanLyLuanVan(TênLuậnVăn, PhânLoại, SốLượngCònLại,SốLượngThànhViên,NộiDung,HạnCuốiĐăngKí) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}')", TenLuanVan, PhanLoai, SoLuong, SoLuongTv, Noidung, HanCuoiDangKi.ToShortDateString());
            Thucthi(SQL);
        }
        public void XoaLuanVan(string TenLuanVan)
        {
            string SQL = string.Format("DELETE FROM QuanLyLuanVan WHERE TênLuậnVăn = '{0}'", TenLuanVan);
            Thucthi(SQL);
        }
        public void ThemvaodsDuyet(string tenluanvan, string nhom, string nhomtruong, string slthanhvien, string slthanhviennhom, string trangthai)
        {
            string SQL = string.Format("INSERT INTO TienDo(TênLuậnVăn,Nhóm,NhómTrưởng,SốLượngThànhViên,SốLượngTVNHóm,TrạngThái) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", tenluanvan, nhom, nhomtruong, slthanhvien, slthanhviennhom, trangthai);
            Thucthi(SQL);
        }
        public void ThemvaodsTiendo(string tenluanvan, string nhom, string nhomtruong, string slthanhvien, string slthanhviennhom)
        {
            string SQL = string.Format("INSERT INTO TienDo(TênLuậnVăn,Nhóm,NhómTrưởng,SốLượngThànhViên,SốLượngTVNHóm) VALUES ('{0}','{1}','{2}','{3}','{4}')", tenluanvan, nhom, nhomtruong, slthanhvien, slthanhviennhom);
            Thucthi(SQL);
        }
        public void DuyetLuanVan(string s)
        {
            string SQL = string.Format("UPDATE TienDo SET TrạngThái = 1 WHERE TênLuậnVăn = '{0}'", s);
            Thucthi(SQL);
        }
        public DataTable Load()
        {
            string sqlStr = "SELECT * FROM QuanLyLuanVan";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public void Thucthi(string s)
        {
            DBConnection db = new DBConnection();
            db.Thucthi(s);
        }
        public DataTable LoadQLLV()
        {
            string sqlStr = "SELECT TênLuậnVăn,PhânLoại,SốLượngCònLại,SốLượngThànhViên,NộiDung,HạnCuốiĐăngKí FROM QuanLyLuanVan";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
        public DataTable LoadFormDuyet()
        {
            string sqlStr = "SELECT TênLuậnVăn,Nhóm,NhómTrưởng,SốLượngThànhViên,SốLượngTVNHóm FROM TienDo WHERE TrạngThái=0";
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }
    }
}
