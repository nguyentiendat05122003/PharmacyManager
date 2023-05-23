using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IProviderDAL
    {
        int Insert(string tenncc, string diachi, string dienthoai, string email,bool ngunghoptac);
        int Delete(int mancc);
        int Update(int mancc, string tenncc, string diachi, string dienthoai, string email,bool ngunghoptac);
        DataTable getAll();
        int checkNCC_ID(int man);
    }
}
