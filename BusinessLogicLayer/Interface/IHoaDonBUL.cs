using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IHoaDonBUL
    {
        int Insert(HoaDon hd);
        int Delete(int hdid);
        int Update(HoaDon cls);
        IList<HoaDon> getAll();
        IList<HoaDon> SearchLinq(HoaDon cls);

        int checkHoaDon_ID(int classID);

    }
}
