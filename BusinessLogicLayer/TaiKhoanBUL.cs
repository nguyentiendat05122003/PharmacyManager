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
        public int checkTaiKhoan_ID(int classID)
        {
            return dal.checkTaiKhoan_ID(classID);
        }
        public bool checkTaiKhoan_IsExist(string tk,string mk)
        {
            bool isAccountExist = getAll().Any(account => {
                return account.Tentaikhoan == tk && account.Matkhau==mk;
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
        public string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Sử dụng PBKDF2 để mã hóa mật khẩu
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Kết hợp muối và hash để lưu trữ trong cơ sở dữ liệu
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Chuyển đổi sang chuỗi Base64 để lưu trữ
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        public bool VerifyPassword(string password, string savedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            // Kiểm tra kích thước của hashBytes
            if (hashBytes.Length != 36)
            {
                // Kích thước không hợp lệ
                return false;
            }

            // Lấy muối từ mảng byte
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Lấy hash từ mảng byte
            byte[] hash = new byte[20];
            Array.Copy(hashBytes, 16, hash, 0, 20);

            // Sử dụng PBKDF2 để kiểm tra mật khẩu
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] testHash = pbkdf2.GetBytes(20);

                // So sánh hai mảng hash
                for (int i = 0; i < 20; i++)
                {
                    if (hash[i] != testHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
