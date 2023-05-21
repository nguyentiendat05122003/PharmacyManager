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
    public class HoaDonBUL:IHoaDonBUL
    {
        private readonly IHoaDonDAL dal = new HoaDonDAL();

        public int Insert(HoaDon cls)
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
        public int Update(HoaDon cls)
        {
            if (checkHoaDon_ID(cls.Mahoadon) != 0)
                return dal.Update(cls.Mahoadon, cls.Ngaylap, cls.Tongtien, cls.Makhachhang, cls.Manhanvien);
            else return -1;
        }

        public IList<HoaDon> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<HoaDon> list = new List<HoaDon>();
            foreach (DataRow row in table.Rows)
            {
                HoaDon cls = new HoaDon();
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
        public IList<HoaDon> SearchLinq(HoaDon cls)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(cls.Mahoadon.ToString()) || x.Mahoadon.ToString().Contains(cls.Mahoadon.ToString()))).ToList();
        }
        public float GetDoanhThu(int month,int year)
        {
            return dal.GetDoanhThu(month,year);
        }
    }
}
