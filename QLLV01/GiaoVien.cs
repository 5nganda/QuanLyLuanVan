using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLV01
{
    internal class GiangVien : Person
    {
        public GiangVien(string Id, string Hoten, string Chucvu, string Gioitinh, string Cccd, string Email, string Diachi, DateTime Ngaysinh) : base(Id, Hoten, Chucvu, Gioitinh, Cccd, Email, Diachi, Ngaysinh)
        { }
    }
}
