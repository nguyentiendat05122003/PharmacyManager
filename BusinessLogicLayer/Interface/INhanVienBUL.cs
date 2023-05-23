using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface INhanVienBUL
    {
        int Insert(NhanVien nv);
        int Delete(int MaNhanVien);
        int Update(NhanVien nv);
        IList<NhanVien> getAll();
        IList<NhanVien> SearchLinq(string value);
        void KetXuatWord(string templatePath, string exportPath);

        List<dynamic> getAllJoin();

    }
}
