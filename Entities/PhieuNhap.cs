using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PhieuNhap
    {
        protected int maphieunhap;
        protected int mancc;
        protected DateTime ngaynhap;
        protected float tongtien;
        protected int manhanvien;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
       
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public int Mancc { get => mancc; set => mancc = value; }

        public PhieuNhap() { }
        public PhieuNhap(PhieuNhap cls)
        {
            this.maphieunhap = cls.maphieunhap;
            this.mancc = cls.mancc;
            this.ngaynhap = cls.ngaynhap;
            this.tongtien = cls.tongtien;
            this.manhanvien = cls.manhanvien;
        }
        public PhieuNhap(int maphieunhap, int mancc, DateTime ngaynhap,float tongtien,int manhanvien)
        {
            this.maphieunhap = maphieunhap;
            this.mancc = mancc;
            this.ngaynhap =  ngaynhap;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
        }

        public PhieuNhap(int mancc, DateTime ngaynhap, float tongtien, int manhanvien)
        {
            this.mancc = mancc;
            this.ngaynhap = ngaynhap;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
        }
    }
}
