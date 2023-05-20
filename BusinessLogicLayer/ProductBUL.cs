using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public class ProductBUL : IProductBUL
    {
        private readonly IProductDAL dal = new ProductDAL();
        IProviderBUL provider = new ProviderBUL();
        IDonViTinhBUL dvt = new DonViTinhBUL();

        public int Insert(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) == 0)
                return dal.Insert(pro.Tenthuoc,pro.Giaban,pro.Hansudung,pro.Mancc,pro.Madonvitinh);
            else return -1;
        }
       

        public int Delete(int productId)
        {
            if (checkProduct_ID(productId) != 0)
                return dal.Delete(productId);
            else return -1;
        }
        /// <summary>
       

        public int Update(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) != 0)
                return dal.Update(pro.Mathuoc,pro.Tenthuoc, pro.Giaban, pro.Hansudung, pro.Mancc, pro.Madonvitinh);
            else return -1;
        }
       

        public IList<Product> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<Product> list = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product cls = new Product();
                cls.Mathuoc = row.Field<int>(0);
                cls.Tenthuoc = row.Field<string>(1);
                cls.Giaban = row.Field<float>(2);
                cls.Hansudung =row.Field<DateTime>(3);
                cls.Mancc =row.Field<int>(4);
                cls.Madonvitinh = row.Field<int>(5);
               list.Add(cls);
            }
            return list;
        }
        public int checkProduct_ID(int mathuoc)
        {
            return dal.checkProduct_ID(mathuoc);
        }
        public List<dynamic> SearchLinq(string value)
        {
            return getAllJoin().Where(x => (string.IsNullOrEmpty(value) || x.Mathuoc.ToString().Contains(value) ||
                (x.Tenthuoc.ToString() == value) ||
                (string.IsNullOrEmpty(value) || x.Tenthuoc.Contains(value)))).ToList();
        }
        public List<dynamic> getAllJoin()
        {
            var product_provider = (from pd in getAll()
                                    join pv in provider.getAll() on pd.Mancc equals pv.Mancc
                                    join dv in dvt.getAll() on pd.Madonvitinh equals dv.Madonvitinh
                                    select new { Mathuoc = pd.Mathuoc, Tenthuoc = pd.Tenthuoc, Giaban = pd.Giaban, Hansudung = pd.Hansudung, Mancc = pd.Mancc, Donvitinh = pd.Madonvitinh, Tenncc = pv.Tenncc,TenDonvi = dv.Tendonvitinh });
            return product_provider.Cast<dynamic>().ToList();
        }

        public void ThemTuExcel(string filePath)
        {
            var messageError = "";
            var data = ExcelHelper.ReadFromExcelFile(filePath, 1, out messageError);
            Console.Write(data);
            if (string.IsNullOrEmpty(messageError))
            {
                foreach (DataRow row in data.Rows)
                {
                    Product nv = new Product();
                    nv.Tenthuoc = row.Field<string>("TenThuoc");
                    nv.Giaban =float.Parse(row.Field<string>("GiaBan"));
                    nv.Hansudung = DateTime.ParseExact(row.Field<string>("HanSuDung"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    nv.Mancc =int.Parse(row.Field<string>("MaNCC"));
                    nv.Madonvitinh = int.Parse(row.Field<string>("MaDonViTinh"));
                    dal.Insert(nv);
                }
            }
            else throw new Exception(messageError);

        }

        public void KetXuatWord(string templatePath, string exportPath)
        {
            IList<Product> list = getAll();
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateProductTemplate(exportPath, dictionaryData, list);
        }
    }
}
