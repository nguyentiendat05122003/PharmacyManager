using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KhachHangBUL:IKhachHangBUL
    {
        private readonly IKhachHangDAL dal = new KhachHangDAL();

        public int Insert(KhachHang cls)
        {
            if (checkkh_ID(cls.Makhachhang) == 0)
                return dal.Insert(cls.Hoten, cls.Diachi, cls.Dienthoai, cls.Email,cls.Daxoa);
            else return -1;
        }
        public int Delete(int mancc)
        {
            if (checkkh_ID(mancc) != 0)
                return dal.Delete(mancc);
            else return -1;
        }
        public int checkkh_ID(int mancc)
        {
            return dal.checkKh_ID(mancc);
        }
        public int Update(KhachHang cls)
        {
            if (checkkh_ID(cls.Makhachhang) != 0)
                return dal.Update(cls.Makhachhang, cls.Hoten, cls.Diachi, cls.Dienthoai, cls.Email,cls.Daxoa);
            else return -1;
        }

        public IList<KhachHang> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<KhachHang> list = new List<KhachHang>();
            foreach (DataRow row in table.Rows)
            {
                KhachHang cls = new KhachHang();
                cls.Makhachhang = row.Field<int>(0);
                cls.Hoten = row.Field<string>(1);
                cls.Diachi = row.Field<string>(2);
                cls.Dienthoai = row.Field<string>(3);
                cls.Email = row.Field<string>(4);
                cls.Daxoa = row.Field<bool>(5);
                list.Add(cls);
            }
            return list;
        }
        public IList<KhachHang> SearchLinq(string value)
        {
                return getAll().Where(x => (string.IsNullOrEmpty(value) || x.Hoten.Contains(value) ||
                    (string.IsNullOrEmpty(value) || x.Hoten.Contains(value)) ||
                    (x.Dienthoai.Equals(value)))).ToList();
        }
    }
}
