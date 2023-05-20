using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IKhachHangDAL
    {
        int Insert(string hoten, string diachi, string dienthoai, string email);
        int Delete(int makh);
        int Update(int makh, string hoten, string diachi, string dienthoai, string email);
        DataTable getAll();
        int checkKh_ID(int makh);
    }
}
