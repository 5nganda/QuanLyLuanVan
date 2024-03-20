using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLLV01
{
    public class Person
    {
        public string id;
        public string hoten;
        public string chucvu;
        public string gioitinh;
        public string cccd;
        public string email;
        public string diachi;
        public DateTime ngaysinh;


        public string Id { get; set; }
        public string Hoten { get; set; }
        public string Chucvu { get; set; }
        public string Gioitinh { get; set; }
        public string Cccd { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }

        public DateTime NgaySinh { get; set; }

        public Person()
        {

        }
        public Person(string id, string hoten, string chucvu, string gioitinh, string cccd, string email, string diachi, DateTime ngaysinh)
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Chucvu = chucvu;
            this.Gioitinh = gioitinh;
            this.Cccd = cccd;
            this.Email = email;
            this.Diachi = diachi;
            this.NgaySinh = ngaysinh;
        }
    }
}
