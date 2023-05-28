using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IKhachHangBUL
    {
        int Insert(KhachHang cls);
        int Delete(int makh);
        int Update(KhachHang cls);
        IList<KhachHang> getAll();
        IList<KhachHang> getAllFilter();

        int checkkh_ID(int makh);
        IList<KhachHang> SearchLinq(string value);
    }
}
