using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ITaiKhoanDAL
    {
        int Insert(string tentaikhoan, string matkhau, int manhanvien);
        int Delete(int matk);
        int Update(int matk, string tentaikhoan, string matkhau, int manhanvien);
        DataTable getAll();
        int checkTaiKhoan_ID(int matk);
    }
}
