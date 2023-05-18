using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TaiKhoan
    {
        private int matk;
        private string tentaikhoan;
        private string matkhau;
        private int manhanvien;

        public int Matk { get => matk; set => matk = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }

        public TaiKhoan()
        {
        }
        public TaiKhoan(TaiKhoan cls)
        {
            this.Matk = cls.Matk;
            this.Tentaikhoan = cls.Tentaikhoan;
            this.Matkhau = cls.Matkhau;
            this.Manhanvien = cls.Manhanvien;
        }
        public TaiKhoan(int matk, string tentaikhoan, string matkhau, int manhanvien)
        {
            this.Matk = matk;
            this.Tentaikhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.Manhanvien = manhanvien;
        }
        public TaiKhoan(string tentaikhoan, string matkhau, int manhanvien)
        {
            this.Tentaikhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.Manhanvien = manhanvien;
        }
    }
}
