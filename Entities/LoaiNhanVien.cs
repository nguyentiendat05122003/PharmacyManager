using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LoaiNhanVien
    {
        protected int maLoai;
        protected string tenLoai;
        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
    }
}
