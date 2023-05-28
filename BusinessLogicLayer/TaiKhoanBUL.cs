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
using System.Security.Cryptography;
using System.IO;

namespace BusinessLogicLayer
{
    public class TaiKhoanBUL:ITaiKhoanBUL
    {
        private readonly ITaiKhoanDAL dal = new TaiKhoanDAL();
        public INhanVienBUL nv = new NhanVienBUL();
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
                cls.Matk = row.Field<int>(0);
                cls.Tentaikhoan = row.Field<string>(1);
                cls.Matkhau = row.Field<string>(2);
                cls.Manhanvien = row.Field<int>(3);
                list.Add(cls);
            }
            return list;
        }
        public IList<dynamic> Gettk(int manv)
        {

            List<dynamic> filteredAccountList = getAllJoin().Where(account => account.Manhanvien == manv).ToList();
            return filteredAccountList;
        }
        public int checkTaiKhoan_ID(int matk)
        {
            return dal.checkTaiKhoan_ID(matk);
        }
        public bool checkTaiKhoan_IsExist(string tk,string mk)
        {
            bool isAccountExist = getAll().Any(account =>
            {
                return account.Tentaikhoan == tk && mk == account.Matkhau;
            });
            return isAccountExist;
        }
        public TaiKhoan TaiKhoanLogin(string tk, string mk)
        {
            if (checkTaiKhoan_IsExist(tk, mk))
            {
                TaiKhoan taiKhoanTimThay = getAll().FirstOrDefault(t => t.Tentaikhoan == tk && t.Matkhau == mk);
                return taiKhoanTimThay;
            }
            else
            {
                return null;
            }
        }
        public NhanVien GetNhanVien(int manv)
        {
            NhanVien thongtinnv = nv.getAll().FirstOrDefault(t => t.MaNhanVien ==manv);
            return thongtinnv;
        }       

        public IList<dynamic> getAllJoin()
        {
            var query = from account in getAll()
                        join employee in nv.getAll() on account.Manhanvien equals employee.MaNhanVien
                        select new
                        {
                            Matk = account.Matk,
                            Tentaikhoan = account.Tentaikhoan,
                            Manhanvien = employee.MaNhanVien,
                            EmployeeName = employee.Hoten,
                            Matkhau = account.Matkhau,
                        };

            var joinedList = query.ToList();
            return joinedList.Cast<dynamic>().ToList(); ;
        }
    }
}
