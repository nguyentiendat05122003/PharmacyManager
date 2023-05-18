using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ITaiKhoanBUL
    {
        int Insert(TaiKhoan cls);
        int Delete(int matk);
        int Update(TaiKhoan cls);
        IList<TaiKhoan> getAll();
        int checkTaiKhoan_ID(int classID);
    }
}
