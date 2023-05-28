using DocumentFormat.OpenXml.Drawing.Charts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IProductBUL
    {
        int Insert(Product pro);
        int Delete(int Masanpham);
        int Update(Product pro);

        IList<Product> getAll();
        IList<Product> getAllFilter();

        int checkProduct_ID(int Masanpham);
        List<dynamic> SearchLinq(string value);
        List<dynamic> getAllJoin();

        void KetXuatWord(string templatePath, string exportPath);
        int GetSoluong(int mathuoc);

        List<Product> GetSanPhamByNhaCungCap(int maNCC);
        void KetXuatExcel(string templatePath, string exportPath);

        void ThemTuExcel(string filePath);


    }
}
