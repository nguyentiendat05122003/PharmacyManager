using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ChiTietPhieuNhap
    {
        protected int machitietphieunhap;
        protected int maphieunhap;
        private int mathuoc;
        protected int soluong;
        protected float dongia;

        public int Machitietphieunhap { get => machitietphieunhap; set => machitietphieunhap = value; }
        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public int Mathuoc { get => mathuoc; set => mathuoc = value; }
        public ChiTietPhieuNhap()
        {
            
        }
        public ChiTietPhieuNhap(ChiTietPhieuNhap cls)
        {
            this.machitietphieunhap = cls.Machitietphieunhap;
            this.maphieunhap = cls.Maphieunhap;
            this.mathuoc = cls.mathuoc;
            this.Soluong = cls.Soluong;
            this.Dongia = cls.Dongia;
        }
        public ChiTietPhieuNhap(int machitietphieunhap, int maphieunhap,int mathuoc, int soluong, float dongia)
        {
            this.machitietphieunhap = machitietphieunhap;
            this.maphieunhap = maphieunhap;
            this.mathuoc = mathuoc;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        public ChiTietPhieuNhap(int maphieunhap,int mathuoc, int soluong, float dongia)
        {
            this.Maphieunhap = maphieunhap;
            this.mathuoc = mathuoc;
            this.Soluong = soluong;
            this.Dongia = dongia;
        }
    }
}
