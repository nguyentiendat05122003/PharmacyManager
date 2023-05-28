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
        IChiTietPhieuNhapBUL chitet = new ChiTietPhieuNhapBUL();
        IDonViTinhBUL dvt = new DonViTinhBUL();
        IPhieuNhapBUL pn = new PhieuNhapBUL();
        IProviderBUL ncc = new ProviderBUL();
        public int Insert(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) == 0)
                return dal.Insert(pro.Tenthuoc,pro.Giaban,pro.Hansudung,pro.Dungkinhdoanh,pro.Madonvitinh,pro.Soluong);
            else return -1;
        }
        public int Delete(int productId)
        {
            if (checkProduct_ID(productId) != 0)
                return dal.Delete(productId);
            else return -1;
        }  

        public int Update(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) != 0)
                return dal.Update(pro.Mathuoc,pro.Tenthuoc, pro.Giaban, pro.Hansudung, pro.Dungkinhdoanh, pro.Madonvitinh,pro.Soluong);
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
                cls.Dungkinhdoanh = row.Field<bool>(4);
                cls.Madonvitinh = row.Field<int>(5);
                cls.Soluong = row.Field<int>(6);
                list.Add(cls);
            }
            return list;
        }

        public IList<Product> getAllFilter()
        {
            var results = from product in getAll()
                          where product.Dungkinhdoanh == false
                          select product;
            return results.ToList();
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
                                    join dv in dvt.getAll() on pd.Madonvitinh equals dv.Madonvitinh
                                    select new { Mathuoc = pd.Mathuoc, Tenthuoc = pd.Tenthuoc, Giaban = pd.Giaban, Hansudung = pd.Hansudung, Donvitinh = pd.Madonvitinh, TenDonvi = dv.Tendonvitinh,TrangThai = pd.Dungkinhdoanh,SoLuong=pd.Soluong });
            return product_provider.Cast<dynamic>().ToList();
        }      

        public void KetXuatWord(string templatePath, string exportPath)
        {
            IList<Product> list = getAll();
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateProductTemplate(exportPath, dictionaryData, list);
        }
        public int GetSoluong(int mathuoc)
        {
            int slg = getAll()
                .Where(t => t.Mathuoc == mathuoc)
                .Select(t => t.Soluong)
                .FirstOrDefault();
            return slg;
        }
        public List<Product> GetSanPhamByNhaCungCap(int maNCC)
        {
            var query = from t in getAll()
                        join ctpn in chitet.getAll() on t.Mathuoc equals ctpn.Mathuoc
                        join pn in pn.getAll() on ctpn.Maphieunhap equals pn.Maphieunhap
                        join ncc in ncc.getAll() on pn.Mancc equals ncc.Mancc
                        where ncc.Mancc == maNCC
                        select t;
            return query.ToList();
        }
        public void KetXuatExcel(string templatePath, string exportPath)
        {
            var list = getAll();
            DataTable dataExport = new DataTable();
            dataExport.Columns.Add("Mathuoc");
            dataExport.Columns.Add("Tenthuoc");
            dataExport.Columns.Add("Giaban");
            dataExport.Columns.Add("Hansudung",typeof(DateTime));
            dataExport.Columns.Add("Dungkinhdoanh",typeof(int));
            dataExport.Columns.Add("Madonvitinh", typeof(int));
            dataExport.Columns.Add("Soluong", typeof(int));
            List<ExcelDataExtention> staticDataValue = new List<ExcelDataExtention>();
            staticDataValue.Add(new ExcelDataExtention
            {
                IsEnd = false,
                StartColumnName = "F",
                EndColumnName = "F",
                StartRowIndex = 4,
                EndRowIndex = 4,
                Value = "Hưng yên, ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year
            }); ;
            int start_row = 6;
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    DataRow row = dataExport.NewRow();
                    if (string.IsNullOrEmpty(item.Mathuoc.ToString()))
                        row["Mathuoc"] = DBNull.Value;
                    else
                        row["Mathuoc"] = item.Mathuoc;

                    if (item.Tenthuoc == null)
                        row["Tenthuoc"] = DBNull.Value;
                    else
                        row["Tenthuoc"] = item.Tenthuoc;
                    if (string.IsNullOrEmpty(item.Giaban.ToString()))
                        row["Giaban"] = DBNull.Value;
                    else
                        row["Giaban"] = item.Giaban.ToString();

                    if (string.IsNullOrEmpty(item.Hansudung.ToString()))
                        row["Hansudung"] = DBNull.Value;
                    else
                        row["Hansudung"] = item.Hansudung.ToString();

                    if (string.IsNullOrEmpty(item.Dungkinhdoanh.ToString()))
                        row["Dungkinhdoanh"] = DBNull.Value;
                    else
                        row["Dungkinhdoanh"] = item.Dungkinhdoanh ? "1" : "0";

                    if (string.IsNullOrEmpty(item.Madonvitinh.ToString()))
                        row["Madonvitinh"] = DBNull.Value;
                    else
                        row["Madonvitinh"] = item.Madonvitinh;

                    if (string.IsNullOrEmpty(item.Soluong.ToString()))
                        row["Soluong"] = DBNull.Value;
                    else
                        row["Soluong"] = item.Soluong;                
                    dataExport.Rows.Add(row);
                }
                ExcelHelper.ExportDataTableToExcel(exportPath, templatePath, dataExport, 1, start_row + 1, staticDataValue, true, "", "", false, "");
            }
        }

        public void ThemTuExcel(string filePath)
        {
            var messageError = "";
            var data = ExcelHelper.ReadFromExcelFile(filePath, 1, out messageError);
            if (string.IsNullOrEmpty(messageError))
            {
                foreach (DataRow row in data.Rows)
                {
                    Product product = new Product();
                    product.Tenthuoc = row.Field<string>("Tenthuoc");
                    product.Giaban = float.Parse(row.Field<string>("Giaban"));
                    product.Hansudung = DateTime.ParseExact(row.Field<string>("Hansudung"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    product.Dungkinhdoanh = row.Field<string>("Dungkinhdoanh") == "1" ? true : false;
                    product.Madonvitinh = int.Parse(row.Field<string>("Madonvitinh"));
                    product.Soluong = int.Parse(row.Field<string>("Soluong"));
                    dal.Insert(product);
                }
            }
            else throw new Exception(messageError);

        }
    }
}
