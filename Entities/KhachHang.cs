using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class KhachHang
    {
        private int makhachhang;
        private string hoten;
        private string diachi;
        private string dienthoai;
        private string email;

        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang()
        {
        }
        public KhachHang(KhachHang cls)
        {
            this.Makhachhang = cls.Makhachhang;
            this.Hoten = cls.Hoten;
            this.Diachi = cls.Diachi;
            this.Dienthoai = cls.Dienthoai;
            this.Email = cls.Email;    
        }

        public KhachHang(string hoten,string diachi,string dienthoai,string email)
        {
            this.Hoten = hoten;
            this.Diachi = diachi;
            this.Dienthoai = dienthoai;
            this.Email = email;
        }
        public KhachHang(string hoten, string diachi, string dienthoai, string email, int makh)
        {
            this.Makhachhang = makh;
            this.Hoten = hoten;
            this.Diachi = diachi;
            this.Dienthoai = dienthoai;
            this.Email = email;
        }

        
    }
}
