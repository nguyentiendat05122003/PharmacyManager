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
    public class TaiKhoanBUL:ITaiKhoanBUL
    {
        private readonly ITaiKhoanDAL dal = new TaiKhoanDAL();

        public int Insert(TaiKhoan cls)
        {
            if (checkTaiKhoan_ID(cls.Matk) == 0)
                return dal.Insert(cls.Tentaikhoan, cls.Matkhau, cls.Manhanvien);
            else return -1;

        }
        public int Delete(int matk)
        {
            if (checkTaiKhoan_ID(matk) != 0)
                return dal.Delete(matk);
            else return -1;
        }
        public int Update(TaiKhoan cls)
        {
            if (checkTaiKhoan_ID(cls.Matk) != 0)
                return dal.Update(cls.Matk, cls.Tentaikhoan, cls.Matkhau, cls.Manhanvien);
            else return -1;
        }

        public IList<TaiKhoan> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<TaiKhoan> list = new List<TaiKhoan>();
            foreach (DataRow row in table.Rows)
            {
                TaiKhoan cls = new TaiKhoan();
                cls.Matk = cls.Matk;
                cls.Tentaikhoan = cls.Tentaikhoan;
                cls.Matkhau = cls.Matkhau;
                cls.Manhanvien = cls.Manhanvien;
                list.Add(cls);
            }
            return list;
        }
        public int checkTaiKhoan_ID(int classID)
        {
            return dal.checkTaiKhoan_ID(classID);
        }
    }
}
