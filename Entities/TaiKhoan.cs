using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TaiKhoan
    {
        protected int matk;
        protected string tentaikhoan;
        protected string matkhau;
        protected int manhanvien;

        public int Matk { get => matk; set => matk = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }

        public TaiKhoan()
        {
        }
        public TaiKhoan(TaiKhoan cls)
        {
            this.matk = cls.matk;
            this.tentaikhoan = cls.tentaikhoan;
            this.matkhau = cls.matkhau;
            this.manhanvien = cls.manhanvien;
        }
        public TaiKhoan(int matk, string tentaikhoan, string matkhau, int manhanvien)
        {
            this.matk = matk;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.manhanvien = manhanvien;
        }
        public TaiKhoan(string tentaikhoan, string matkhau, int manhanvien)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.manhanvien = manhanvien;
        }
    }
}
