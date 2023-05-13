using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.Bibliography;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DonViTinhBUL:IDonViTinhBUL
    {
        private readonly IDonViTinhDAL dal = new DonViTinhDAL();

        public IList<DonviTinh> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<DonviTinh> list = new List<DonviTinh>();
            foreach (DataRow row in table.Rows)
            {
                DonviTinh cls = new DonviTinh();
                cls.Madonvitinh = row.Field<int>(0);
                cls.Tendonvitinh = row.Field<string>(1);
                list.Add(cls);
            }
            return list;
        }
    }
}
