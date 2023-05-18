using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ChiTietHoaDon
    {
        private int machitiet;
        private int mahoadon;
        private float dongia;
        private int mathuoc;
        private int soluong;

        public int Machitiet { get => machitiet; set => machitiet = value; }
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public int Mathuoc { get => mathuoc; set => mathuoc = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public ChiTietHoaDon()
        {

        }

        public ChiTietHoaDon(ChiTietHoaDon cls)
        {
            this.Machitiet = cls.Machitiet;
            this.Mahoadon = cls.Mahoadon;
            this.Dongia = cls.Dongia;
            this.Mathuoc = cls.Mathuoc;
            this.Soluong= cls.Soluong;
        }
        public ChiTietHoaDon(int machitiet, int mahoadon, float dongia, int mathuoc, int soluong)
        {
            this.Machitiet = machitiet;
            this.Mahoadon = mahoadon;
            this.Dongia = dongia;
            this.Mathuoc = mathuoc;
            this.Soluong = soluong;
        }
        public ChiTietHoaDon(int mahoadon, float dongia, int mathuoc, int soluong)
        {
            this.Mahoadon = mahoadon;
            this.Dongia = dongia;
            this.Mathuoc = mathuoc;
            this.Soluong = soluong;
        }
    }
}
