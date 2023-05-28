using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public class PhieuNhapBUL : IPhieuNhapBUL
    {
        private readonly IPhieuNhapDAL dal = new PhieuNhapDAL();
        
            
        public int Insert(PhieuNhap cls)
        {
            if (checkPhieuNhap_ID(cls.Maphieunhap) == 0)
                return dal.Insert(cls.Mancc,cls.Ngaynhap, cls.Tongtien, cls.Manhanvien);
            else return -1;
        }

        public int Delete(int phieunhapID)
        {
            if (checkPhieuNhap_ID(phieunhapID) != 0)
                return dal.Delete(phieunhapID);
            else return -1;
        }

        public int Update(PhieuNhap cls)
        {
            if (checkPhieuNhap_ID(cls.Maphieunhap) != 0)
                return dal.Update(cls.Maphieunhap,cls.Mancc, cls.Ngaynhap, cls.Tongtien, cls.Manhanvien);
            else return -1;
        }

        public IList<PhieuNhap> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<PhieuNhap> list = new List<PhieuNhap>();
            foreach (DataRow row in table.Rows)
            {
                PhieuNhap cls = new PhieuNhap();
                cls.Maphieunhap = row.Field<int>(0);
                cls.Mancc = row.Field<int>(1);
                cls.Ngaynhap = row.Field<DateTime>(2);
                cls.Tongtien = row.Field<float>(3);
                cls.Manhanvien = row.Field<int>(4);
                list.Add(cls);
            }
            return list;
        }

        public int checkPhieuNhap_ID(int classID)
        {
            return dal.checkPhieuNhap_ID(classID);
        }
        public float GetDoanhSoNhap(int month, int year)
        {
            return dal.GetDoanhSoNhap(month, year);
        }
        public IList<PhieuNhap> SearchLinq(PhieuNhap cls)
        {
            return getAll();
        }
        public PhieuNhap GetLastPN()
        {
            PhieuNhap phieuNhapCuoiCung = getAll().OrderByDescending(p => p.Maphieunhap).FirstOrDefault();          
            return phieuNhapCuoiCung;
        }

        public void KetXuatWord(string ncc, string templatePath, string exportPath)
        {
            
        }
        public List<dynamic> GetAllJoinFull()
        {
            IChiTietPhieuNhapBUL chiTiet = new ChiTietPhieuNhapBUL();
            IProviderBUL nhacungcap = new ProviderBUL();
            INhanVienBUL nhanvien = new NhanVienBUL();
            IProductBUL product = new ProductBUL();
            var query = from t in getAll()
                        join ctpn in chiTiet.getAll() on t.Maphieunhap equals ctpn.Maphieunhap
                        join ncc in nhacungcap.getAll() on t.Mancc equals ncc.Mancc
                        join nv in nhanvien.getAll() on t.Manhanvien equals nv.MaNhanVien
                        join thuoc in product.getAll() on ctpn.Mathuoc equals thuoc.Mathuoc
                        select new { MaPhieuNhap = t.Maphieunhap, Tencc = ncc.Tenncc, Tenv = nv.Hoten, TongTien = t.Tongtien, Tenthuoc = thuoc.Tenthuoc,DonGiaNhap=ctpn.Dongia,DonGiaBan=thuoc.Giaban,Soluong = ctpn.Soluong, NgayLap = t.Ngaynhap };
            return query.Cast<dynamic>().ToList(); ;
        }

        public IList<dynamic> SearchLinq(string value)
        {
            string newValue = value.ToLower();
            return GetAllJoinFull().Where(x =>
                (string.IsNullOrEmpty(value) || x.NgayLap.ToString().Contains(value) ||
                (x.Tencc.ToString() == value) ||
                x.Tencc.ToLower().Contains(newValue))
            ).ToList();
        }


    }
}
