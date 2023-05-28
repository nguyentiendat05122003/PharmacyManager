using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IPhieuNhapBUL
    {
        int Insert(PhieuNhap cls);
        int Delete(int phieunhapID);
        int Update(PhieuNhap cls);
        IList<PhieuNhap> getAll();
        int checkPhieuNhap_ID(int phieunhapID);
        PhieuNhap GetLastPN();

        List<dynamic> GetAllJoinFull();

        IList<dynamic> SearchLinq(string value);
        void KetXuatWord(string ncc, string templatePath, string exportPath);

        float GetDoanhSoNhap(int month, int year);

    }
}
