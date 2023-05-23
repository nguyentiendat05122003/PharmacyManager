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
    public class ChiTietHoaDonBUL : IChiTietHoaDonBUL
    {
        private readonly IChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();     
        IProductBUL productBUL = new ProductBUL();
        public int Insert(ChiTietHoaDonBan cls)
        {
            if (checkChitiet_ID(cls.Machitiet) == 0)
                return dal.Insert(cls.Mahoadon,cls.Dongia,cls.Mathuoc,cls.Soluong);
            else return -1;
        }
        public int checkChitiet_ID(int chitietID)
        {
            return dal.checkChitiet_ID(chitietID);
        }
        public int Delete(int machitiet)
        {
            if (checkChitiet_ID(machitiet) != 0)
                return dal.Delete(machitiet);
            else return -1;
        }
        public int Update(ChiTietHoaDonBan cls)
        {
            if (checkChitiet_ID(cls.Machitiet) != 0)
                return dal.Update(cls.Machitiet, cls.Mahoadon, cls.Dongia, cls.Mathuoc, cls.Soluong);
            else return -1;
        }
        public IList<ChiTietHoaDonBan> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ChiTietHoaDonBan> list = new List<ChiTietHoaDonBan>();
            foreach (DataRow row in table.Rows)
            {
                ChiTietHoaDonBan cls = new ChiTietHoaDonBan();
                cls.Machitiet = row.Field<int>(0);
                cls.Mahoadon = row.Field<int>(1);
                cls.Dongia = row.Field<float>(2);              
                cls.Mathuoc = row.Field<int>(3);
                cls.Soluong = row.Field<int>(4);
                list.Add(cls);
            }
            return list;
        }



        public void KetXuatWord(string name,int mahd,float tongtien,string tenv,string templatePath, string exportPath)
        {
            IChiTietHoaDonBUL chitiet = new ChiTietHoaDonBUL();
            IList<ChiTietHoaDonBan> list = chitiet.getAll();
            IList<ChiTietHoaDonBan> newList = list.Where(ct => ct.Mahoadon == mahd).ToList();
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("tenkhachhang", name);
            dictionaryData.Add("tongtien",tongtien.ToString());
            dictionaryData.Add("nhanvien",tenv);
            System.IO.File.Copy(templatePath, exportPath, true);         
            ExportDocx.CreateChiTietTemplate(exportPath, dictionaryData,newList);
        }
    }
}
