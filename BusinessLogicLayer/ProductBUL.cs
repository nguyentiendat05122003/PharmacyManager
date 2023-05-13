using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public class ProductBUL : IProductBUL
    {
        private readonly IProductDAL dal = new ProductDAL();

        public int Insert(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) == 0)
                return dal.Insert(pro.Tenthuoc,pro.Giaban,pro.Hansudung,pro.Mancc,pro.Madonvitinh);
            else return -1;
        }
        /// <summary>
        /// Hàm xóa thông tin lớp học khỏi CSDL với mã lớp được chỉ định từ tầng Presentation
        /// Nếu không xóa được lớp do lớp này không tồn tại hàm trả về giá trị -1
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public int Delete(int productId)
        {
            if (checkProduct_ID(productId) != 0)
                return dal.Delete(productId);
            else return -1;
        }
        /// <summary>
        /// Hàm cập nhật lại thông tin một lớp học vào CSDL với thông tin mới được lấy từ tầng Presentation
        /// Nếu việc cập nhật thất bại do mã lớp không tồn tại thì hàm trả về -1
        /// </summary>
        /// <param name="cls">Thông tin lớp mới cần được cập nhật lại vào CSDL</param>

        public int Update(Product pro)
        {
            if (checkProduct_ID(pro.Mathuoc) != 0)
                return dal.Update(pro.Mathuoc,pro.Tenthuoc, pro.Giaban, pro.Hansudung, pro.Mancc, pro.Madonvitinh);
            else return -1;
        }
        /// <summary>
        /// Hàm trả về danh sách các lớp cóp trong CSDL
        /// </summary>

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
        public IList<Product> SearchLinq(Product cls)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(cls.Tenthuoc) || x.Tenthuoc.Contains(cls.Tenthuoc))).ToList();
           
        }
        public List<dynamic> getAllJoin(IProviderBUL provider,IDonViTinhBUL donvi)
        {
            var product_provider = (from pd in getAll()
                                    join pv in provider.getAll() on pd.Mancc equals pv.Mancc
                                    join dv in donvi.getAll() on pd.Madonvitinh equals dv.Madonvitinh
                                    select new { Mathuoc = pd.Mathuoc, Tenthuoc = pd.Tenthuoc, Giaban = pd.Giaban, Hansudung = pd.Hansudung, Mancc = pd.Mancc, Donvitinh = pd.Madonvitinh, Tenncc = pv.Tenncc,TenDonvi = dv.Tendonvitinh });
            return product_provider.Cast<dynamic>().ToList();
        }
    }
}
