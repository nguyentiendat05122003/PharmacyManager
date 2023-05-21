using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IHoaDonDAL
    {
        int Insert(DateTime ngaylap, float tongtien, int makhachhang, int manhanvien);
        int Delete(int classID);
        int Update(int mahoadon, DateTime ngaylap, float tongtien, int makhachhang, int manhanvien);
        DataTable getAll();
        int checkHoaDon_ID(int hoadonID);

        float GetDoanhThu(int month, int year);
    }
}
