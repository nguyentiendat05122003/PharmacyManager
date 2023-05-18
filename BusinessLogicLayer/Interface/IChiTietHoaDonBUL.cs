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
        int Insert(ChiTietHoaDon cls);
        int Delete(int machitiet);
        int Update(ChiTietHoaDon cls);
        IList<ChiTietHoaDon> getAll();
        int checkChitiet_ID(int machitiet);

        void KetXuatWord(string name,int mahd, float tongtien,string templatePath, string exportPath);
    }
}
