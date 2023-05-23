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
        void KetXuatWord(string ncc, string templatePath, string exportPath);
    }
}
