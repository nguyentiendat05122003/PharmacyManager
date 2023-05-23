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

        int checkProduct_ID(int Masanpham);
        List<dynamic> SearchLinq(string value);
        void ThemTuExcel(string filePath);
        List<dynamic> getAllJoin();
        void KetXuatWord(string templatePath, string exportPath);

        int GetSoluong(int mathuoc);      
    }
}
