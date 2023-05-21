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
    public class PhieuNhapBUL : IPhieuNhapBUL
    {
        private readonly IPhieuNhapDAL dal = new PhieuNhapDAL();

        public int Insert(PhieuNhap cls)
        {
            if (checkPhieuNhap_ID(cls.Maphieunhap) == 0)
                return dal.Insert(cls.Mathuoc,cls.Ngaynhap, cls.Tongtien, cls.Manhanvien);
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
                return dal.Update(cls.Maphieunhap,cls.Mathuoc, cls.Ngaynhap, cls.Tongtien, cls.Manhanvien);
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
                cls.Mathuoc = row.Field<int>(1);
                cls.Ngaynhap = row.Field<DateTime>(2);
                cls.Tongtien = row.Field<float>(2);
                cls.Manhanvien = row.Field<int>(3);
                list.Add(cls);
            }
            return list;
        }

        public int checkPhieuNhap_ID(int classID)
        {
            return dal.checkPhieuNhap_ID(classID);
        }

        public IList<PhieuNhap> SearchLinq(PhieuNhap cls)
        {
            return getAll();
        }
    }
}
