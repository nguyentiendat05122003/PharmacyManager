using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PhieuNhap
    {
        private int maphieunhap;
        private int mathuoc;
        private DateTime ngaynhap;
        private float tongtien;
        private int manhanvien;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Mathuoc { get => mathuoc; set => mathuoc = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }

        public PhieuNhap() { }
        public PhieuNhap(PhieuNhap cls)
        {
            this.maphieunhap = cls.maphieunhap;
            this.mathuoc = cls.mathuoc;
            this.ngaynhap = cls.ngaynhap;
            this.tongtien = cls.tongtien;
            this.manhanvien = cls.manhanvien;
        }
        public PhieuNhap(int maphieunhap, int mathuoc, DateTime ngaynhap,float tongtien,int manhanvien)
        {
            this.maphieunhap = maphieunhap;
            this.mathuoc = mathuoc;
            this.ngaynhap =  ngaynhap;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
        }

        public PhieuNhap(int mathuoc, DateTime ngaynhap, float tongtien, int manhanvien)
        {
            this.mathuoc = mathuoc;
            this.ngaynhap = ngaynhap;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
        }
    }
}
