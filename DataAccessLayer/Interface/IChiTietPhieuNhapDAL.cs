using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IChiTietPhieuNhapDAL
    {
        int Insert(int maphieunhap, int mathuoc,int soluong, float dongia);
        int Delete(int machitietphieunhap);
        int Update(int machitietphieunhap, int mathuoc ,int maphieunhap, int soluong, float dongia);
        DataTable getAll();
        int checkChiTietPN_ID(int machitietphieunhap);
    }
}
