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
    public class LoaiNhanVienBUL:ILoaiNhanVienBUL
    {
        private readonly ILoaiNhanVienDAL dal = new LoaiNhanVienDAL();

        public IList<
            LoaiNhanVien> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<LoaiNhanVien> list = new List<LoaiNhanVien>();
            foreach (DataRow row in table.Rows)
            {
                LoaiNhanVien cls = new LoaiNhanVien();
                cls.MaLoai = row.Field<int>(0);
                cls.TenLoai = row.Field<string>(1);
                list.Add(cls);
            }
            return list;
        }
    }
}
