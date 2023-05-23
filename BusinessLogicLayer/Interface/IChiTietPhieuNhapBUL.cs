using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IChiTietPhieuNhapBUL
    {
        int Insert(ChiTietPhieuNhap cls);
        int Delete(int classID);
        int Update(ChiTietPhieuNhap cls);
        IList<ChiTietPhieuNhap> getAll();

        int checkChiTietPN_ID(int classID);

        void KetXuatWord(PhieuNhap mapn,string tennv,string ncc,string templatePath, string exportPath);
    }
}
