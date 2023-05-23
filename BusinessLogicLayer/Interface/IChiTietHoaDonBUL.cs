using DocumentFormat.OpenXml.VariantTypes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IChiTietHoaDonBUL
    {
        int Insert(ChiTietHoaDonBan cls);
        int Delete(int machitiet);
        int Update(ChiTietHoaDonBan cls);
        IList<ChiTietHoaDonBan> getAll();
        int checkChitiet_ID(int machitiet);

        void KetXuatWord(string name,int mahd, float tongtien,string tenv,string templatePath, string exportPath);
    }
}
