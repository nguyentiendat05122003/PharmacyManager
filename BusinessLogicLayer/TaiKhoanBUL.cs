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
        public int checkTaiKhoan_ID(int classID)
        {
            return dal.checkTaiKhoan_ID(classID);
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
        //mã hóa
        public string HashPassword(string password, int iterations, int SaltSize ,int HashSize)
        {         
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
        }

        //giải mã
        public bool DecodePassword(string password, string hashedPassword, int SaltSize, int HashSize)
        {
            // Extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // Get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // Get salt
            var salt = new byte[SaltSize];
            var storedHash = new byte[HashSize];

            // Check if the hashBytes length is valid
            if (hashBytes.Length >= SaltSize + HashSize)
            {
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);
                Array.Copy(hashBytes, SaltSize, storedHash, 0, HashSize);
            }

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Get result
            for (var i = 0; i < HashSize; i++)
            {
                if (storedHash[i] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }

        

        public  string Encrypt(string plainText)
        {
            byte[] encryptedBytes;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("ThisIsASecretKey12345");
                aesAlg.IV = Encoding.UTF8.GetBytes("ThisIsAnIV1234567");

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedBytes);
        }

        public  string Decrypt(string encryptedText)
        {
            byte[] cipherBytes = Convert.FromBase64String(encryptedText);
            string plainText;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("ThisIsASecretKey12345"); ;
                aesAlg.IV = Encoding.UTF8.GetBytes("ThisIsAnIV1234567");
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plainText;
        }
    }
}
