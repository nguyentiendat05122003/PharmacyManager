using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
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
    public class HoaDonBanBUL:IHoaDonBanBUL
    {
        private readonly IHoaDonDAL dal = new HoaDonDAL();
        IProductBUL product = new ProductBUL();
        IChiTietHoaDonBUL chitiethd = new ChiTietHoaDonBUL();
        IKhachHangBUL khachhang = new KhachHangBUL();
        INhanVienBUL nhanvien = new NhanVienBUL();
        IPhieuNhapBUL pn = new PhieuNhapBUL();
        public int Insert(HoaDonBan cls)
        {
            if (checkHoaDon_ID(cls.Mahoadon) == 0)
                return dal.Insert(cls.Ngaylap, cls.Tongtien, cls.Makhachhang,cls.Manhanvien);
            else return -1;

        }
        public int Delete(int hoadonID)
        {
            if (checkHoaDon_ID(hoadonID) != 0)
                return dal.Delete(hoadonID);
            else return -1;
        }
        public int checkHoaDon_ID(int hoadonID)
        {
            return dal.checkHoaDon_ID(hoadonID);
        }
        public int Update(HoaDonBan cls)
        {
            if (checkHoaDon_ID(cls.Mahoadon) != 0)
                return dal.Update(cls.Mahoadon, cls.Ngaylap, cls.Tongtien, cls.Makhachhang, cls.Manhanvien);
            else return -1;
        }

        public IList<HoaDonBan> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<HoaDonBan> list = new List<HoaDonBan>();
            foreach (DataRow row in table.Rows)
            {
                HoaDonBan cls = new HoaDonBan();
                cls.Mahoadon = row.Field<int>(0);
                cls.Ngaylap = row.Field<DateTime>(1);
                cls.Tongtien = row.Field<float>(2);
                cls.Makhachhang = row.Field<int?>(3).GetValueOrDefault();                
                cls.Manhanvien = row.Field<int>(4);
                list.Add(cls);
            }
            return list;
        }
        public IList<dynamic> allhd()
        {
            var list = getAll();
            return list.Cast<dynamic>().ToList();
        }       
        public float GetDoanhThu(int month,int year)
        {
            return dal.GetDoanhThu(month,year);
        }

        public HoaDonBan GetLastHD()
        {
            return getAll().OrderByDescending(hd => hd.Mahoadon).FirstOrDefault();
        }

        public List<dynamic> GetAllJoinFull()
        {
            var query = from t in getAll()
                        join ctpn in chitiethd.getAll() on t.Mahoadon equals ctpn.Mahoadon
                        join kh in khachhang.getAll() on t.Makhachhang equals kh.Makhachhang
                        join nv in nhanvien.getAll() on t.Manhanvien equals nv.MaNhanVien
                        join thuoc in product.getAll() on ctpn.Mathuoc equals thuoc.Mathuoc
                        select new { MaHoaDon = t.Mahoadon,Tenkh=kh.Hoten,Tenv = nv.Hoten,TongTien = t.Tongtien,Tenthuoc = thuoc.Tenthuoc,Soluong=ctpn.Soluong,NgayBan=t.Ngaylap  };
            return query.Cast<dynamic>().ToList(); ;
        }
        public IList<dynamic> SearchLinq(string value)
        {
            string newValue = value.ToLower();
            return GetAllJoinFull().Where(x =>
                (string.IsNullOrEmpty(value) || x.NgayBan.ToString().Contains(value) ||
                (x.Tenkh.ToString() == value) ||
                x.Tenkh.ToLower().Contains(newValue))
            ).ToList();
        }

        public void KetXuatWord(string templatePath, string exportPath)
        {
            IList<(int Month, float TongHoaDon, float TongHangNhap)> dataList = new List<(int, float, float)>();
            int currentYear = DateTime.Now.Year;
            for (int month = 1; month <= 12; month++)
            {
                float tonghoadon = GetDoanhThu(month, currentYear);
                float tonghangnhap = pn.GetDoanhSoNhap(month, currentYear);
                dataList.Add((month, tonghoadon,tonghangnhap));
            }            
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("nam", currentYear.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateThongKeTemplate(exportPath, dictionaryData,dataList);
        }
    }
}
