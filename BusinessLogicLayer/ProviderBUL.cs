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
    public class ProviderBUL:IProviderBUL
    {
        private readonly IProviderDAL dal = new ProviderDAL();

        public int Insert(Provider cls)
        {
            if (checkNCC_ID(cls.Mancc) == 0)         
                return dal.Insert(cls.Tenncc,cls.Diachi,cls.Dienthoai,cls.Email,cls.Ngunghoptac);
            else return -1;

        }
        public int Delete(int mancc)
        {
            if (checkNCC_ID(mancc) != 0)
                return dal.Delete(mancc);
            else return -1;
        }
        public int checkNCC_ID(int mancc)
        {
            return dal.checkNCC_ID(mancc);
        }
        public int Update(Provider cls)
        {
            if (checkNCC_ID(cls.Mancc) != 0)
                return dal.Update(cls.Mancc, cls.Tenncc, cls.Diachi, cls.Dienthoai, cls.Email,cls.Ngunghoptac);
            else return -1;
        }

        public IList<Provider> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<Provider> list = new List<Provider>();
            foreach (DataRow row in table.Rows)
            {
                Provider cls = new Provider();
                cls.Mancc = row.Field<int>(0);
                cls.Tenncc = row.Field<string>(1);
                cls.Diachi = row.Field<string>(2);
                cls.Dienthoai = row.Field<string>(3);
                cls.Email = row.Field<string>(4);
                cls.Ngunghoptac = row.Field<bool>(5);
                list.Add(cls);
            }
            return list;
        }
        public IList<Provider> SearchLinq(string value)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(value) || x.Mancc.ToString().Contains(value) ||
               (x.Tenncc.ToString() == value) ||
               (string.IsNullOrEmpty(value) || x.Tenncc.ToLower().Contains(value)))).ToList();
        }

        public IList<Provider> GetProviderIsContact()
        {
            var items = getAll()
            .Where(row => row.Ngunghoptac == true)
            .ToList();
            return items;
        }
        public string GetProviderName(int mancc)
        {
            string tenNhaCungCap = getAll()
            .Where(ncc => ncc.Mancc == mancc)
            .Select(ncc => ncc.Tenncc)
            .FirstOrDefault();
            return tenNhaCungCap;
        }
    }
}
