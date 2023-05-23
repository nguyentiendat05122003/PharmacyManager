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
        private bool daxoa;

        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Email { get => email; set => email = value; }
        public bool Daxoa { get => daxoa; set => daxoa = value; }

        public KhachHang()
        {
        }
        public KhachHang(KhachHang cls)
        {
            this.makhachhang = cls.Makhachhang;
            this.hoten = cls.Hoten;
            this.diachi = cls.Diachi;
            this.dienthoai = cls.Dienthoai;
            this.email = cls.Email;   
            this.daxoa = cls.daxoa;
        }

        public KhachHang(string hoten,string diachi,string dienthoai,string email, bool daxoa)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.daxoa = daxoa;
        }
        public KhachHang(string hoten, string diachi, string dienthoai, string email, int makh, bool daxoa)
        {
            this.makhachhang = makh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.daxoa = daxoa;
        }

        
    }
}
