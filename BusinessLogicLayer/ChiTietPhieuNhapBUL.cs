using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.VariantTypes;
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
    public class ChiTietPhieuNhapBUL : IChiTietPhieuNhapBUL
    {
        private readonly IChiTietPhieuNhapDAL dal = new ChiTietPhieuNhapDAL();

        public int Insert(ChiTietPhieuNhap cls)
        {
            if (checkChiTietPN_ID(cls.Machitietphieunhap) == 0)
                return dal.Insert(cls.Maphieunhap,cls.Mathuoc,cls.Soluong,cls.Dongia);
            else return -1;
        }
        public int Delete(int machitietphieunhap)
        {
            if (checkChiTietPN_ID(machitietphieunhap) != 0)
                return dal.Delete(machitietphieunhap);
            else return -1;
        }

        public int Update(ChiTietPhieuNhap cls)
        {
            if (checkChiTietPN_ID(cls.Machitietphieunhap) != 0)
                return dal.Update(cls.Machitietphieunhap,cls.Maphieunhap,cls.Mathuoc,cls.Soluong,cls.Dongia);
            else return -1;
        }

        public IList<ChiTietPhieuNhap> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            Console.WriteLine(table);
            IList<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();
            foreach (DataRow row in table.Rows)
            {
                ChiTietPhieuNhap cls = new ChiTietPhieuNhap();
                cls.Machitietphieunhap = row.Field<int>(0);
                cls.Maphieunhap = row.Field<int>(1);
                cls.Mathuoc = row.Field<int>(2);
                cls.Soluong = row.Field<int>(3);
                cls.Dongia = row.Field<float>(4);
                list.Add(cls);
            }
            return list;
        }

        public int checkChiTietPN_ID(int classID)
        {
            return dal.checkChiTietPN_ID(classID);
        }

        public void KetXuatWord(PhieuNhap mapn,string tennv,string ncc,string templatePath, string exportPath)
        {        
            IList<ChiTietPhieuNhap> list = getAll();
            IList<ChiTietPhieuNhap> newlist  =  list.Where(pn => pn.Maphieunhap == mapn.Maphieunhap).ToList();
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("tongtien", mapn.Tongtien.ToString());
            dictionaryData.Add("tennhanvien",tennv);
            dictionaryData.Add("tenncc", ncc);
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreatePhieuNhapTemplate(exportPath, dictionaryData, newlist);
        }

    }
}
