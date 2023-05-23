using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;

namespace BusinessLogicLayer
{
    public class NhanVienBUL:INhanVienBUL
    {
        private readonly INhanVienDAL dal = new NhanVienDAL();
        ILoaiNhanVienBUL loainv = new LoaiNhanVienBUL();
        public int Insert(NhanVien cls)
        {
            return dal.Insert(cls.VaiTro,cls.Hoten,cls.Gioitinh, cls.Ngaysinh , cls.Diachi, cls.Dienthoai, cls.Email,cls.Dathoiviec);
        }
        public IList<NhanVien> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<NhanVien> list = new List<NhanVien>();
            foreach (DataRow row in table.Rows)
            {
                NhanVien cls = new NhanVien();
                cls.MaNhanVien = row.Field<int>(0);
                cls.VaiTro = row.Field<int>(1);
                cls.Hoten = row.Field<string>(2);
                cls.Gioitinh = row.Field<bool>(3);
                cls.Ngaysinh = row.Field<DateTime>(4);
                cls.Diachi = row.Field<string>(5);
                cls.Dienthoai = row.Field<string>(6);
                cls.Email = row.Field<string>(7);
                cls.Dathoiviec = row.Field<bool>(8);
                list.Add(cls);
            }
            return list;
        }
        public int Delete(int NhanVienID)
        {
            if (checkNhanVien_ID(NhanVienID) != 0)
                return dal.Delete(NhanVienID);
            else return -1;
        }
        public int checkNhanVien_ID(int nhanvienID)
        {
            return dal.checkNhanVien_ID(nhanvienID);
        }
        public int Update(NhanVien nv)
        {
            if (checkNhanVien_ID(nv.MaNhanVien) != 0)
                return dal.Update(nv.MaNhanVien, nv.VaiTro, nv.Hoten , nv.Gioitinh, nv.Ngaysinh, nv.Diachi,  nv.Dienthoai,  nv.Email,nv.Dathoiviec);
            else return -1;
        }
        
        public IList<NhanVien> SearchLinq(string value)
        {

            return getAll().Where(x => string.IsNullOrEmpty(value) || x.Hoten.Contains(value) ||
                (x.MaNhanVien.ToString() == value) ||
                (string.IsNullOrEmpty(value) || x.Diachi.Contains(value)) ||
                (string.IsNullOrEmpty(value) || x.Dienthoai.Contains(value)) ||
                (string.IsNullOrEmpty(value) || x.Email.Contains(value)) ||
                (x.Ngaysinh.ToString().Contains(value)) ||
                (string.IsNullOrEmpty(value) || x.Gioitinh.ToString().Contains(value)))
                .ToList();
        }       
        public void KetXuatWord(string templatePath, string exportPath)
        {
            INhanVienBUL nv = new NhanVienBUL();
            IList<NhanVien> listData = nv.getAll();
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateClassTemplate(exportPath, dictionaryData, listData);
        }

        public List<dynamic> getAllJoin()
        {
            var nv_loainv = (from nv in getAll()
                                    join pd in loainv.getAll() on nv.VaiTro equals pd.MaLoai
                                    select new { MaNhanVien = nv.MaNhanVien, HoTen = nv.Hoten, Gioitinh = nv.Gioitinh, NgaySinh =nv.Ngaysinh, Vaitro=nv.VaiTro, DiaChi=nv.Diachi, DienThoai=nv.Dienthoai, Email=nv.Email, Tenvt = pd.TenLoai, DaThoiViec =nv.Dathoiviec});
            return nv_loainv.Cast<dynamic>().ToList();
        }
    }
}
