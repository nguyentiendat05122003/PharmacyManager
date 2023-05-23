using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IProductDAL
    {
        int Insert(string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh,int soluong);
        int Delete(int mathuoc);
        int Update(int mathuoc, string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh,int soluong);
        DataTable getAll();
        int checkProduct_ID(int mathuoc);
    }
}
