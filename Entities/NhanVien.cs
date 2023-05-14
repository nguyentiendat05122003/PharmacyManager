using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NhanVien
    {
        protected int maNhanVien;
        protected int vaitro;
        protected string hoten;
        protected string diachi;
        protected string dienthoai;
        protected string email;
        protected DateTime ngaysinh;
        protected bool gioitinh;
        public NhanVien()
        {
        }
        public NhanVien(NhanVien cls)
        {
            this.maNhanVien = cls.maNhanVien;
            this.vaitro = cls.vaitro;
            this.hoten = cls.hoten;
            this.diachi = cls.diachi;
            this.dienthoai = cls.dienthoai;
            this.email = cls.email;
            this.ngaysinh = cls.ngaysinh;
            this.gioitinh = cls.gioitinh;
        }
        public NhanVien(int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email)
        {
            this.vaitro = vaitro;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }

        public NhanVien(int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email,int manhanvien)
        {
            this.vaitro = vaitro;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.MaNhanVien = manhanvien;
        }

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public int VaiTro
        {
            get { return vaitro; }
            set { vaitro = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
    }
}
