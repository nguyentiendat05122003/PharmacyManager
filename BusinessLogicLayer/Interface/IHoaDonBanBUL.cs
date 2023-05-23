using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IHoaDonBanBUL
    {
        int Insert(HoaDonBan hd);
        int Delete(int hdid);
        int Update(HoaDonBan cls);
        IList<HoaDonBan> getAll();
        IList<HoaDonBan> SearchLinq(HoaDonBan cls);

        int checkHoaDon_ID(int classID);

        float GetDoanhThu(int month,int year);

        HoaDonBan GetLastHD();
    }
}
