using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface INhanVienDAL
    {
        int Insert(int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email);
        int Insert(NhanVien nv);
        int Delete(int NhanVienID);
        int Update(int nhanvienID, int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email);
        DataTable getAll();
        int checkNhanVien_ID(int MaNhanVien);
    }
}
