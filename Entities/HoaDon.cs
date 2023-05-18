using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HoaDon
    {
        private int mahoadon;
        private DateTime ngaylap;
        private float tongtien;
        private int makhachhang;
        private int manhanvien;
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public HoaDon()
        {

        }
        public HoaDon(HoaDon cls)
        {
            this.mahoadon = cls.mahoadon;
            this.ngaylap = cls.ngaylap;
            this.tongtien = cls.tongtien;
            this.makhachhang = cls.makhachhang;
            this.mahoadon = cls.mahoadon;
        }
        public HoaDon(int mahoadon, DateTime ngaylap, float tongtien, int makhachhang, int manhanvien)
        {
            this.mahoadon = mahoadon;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.makhachhang = makhachhang;
            this.manhanvien = manhanvien;
        }

        public HoaDon(DateTime ngaylap, float tongtien, int makhachhang, int manhanvien)
        {
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.makhachhang = makhachhang;
            this.manhanvien = manhanvien;
        }
    }
}
