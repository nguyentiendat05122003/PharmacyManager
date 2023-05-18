using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IChiTietHoaDonDAL
    {
        int Insert(int mahoadon, float dongia, int mathuoc, int soluong);
        int Delete(int machitietID);
        int Update(int machitiet, int mahoadon, float dongia, int mathuoc, int soluong);
        DataTable getAll();
        int checkChitiet_ID(int machitietID);
    }
}
