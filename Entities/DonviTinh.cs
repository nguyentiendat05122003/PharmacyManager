using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DonviTinh
    {
        protected int madonvintinh;
        protected string tendonvitinh;
        public int Madonvitinh {
            get { return madonvintinh; }
            set { madonvintinh = value; }
        }
        public string Tendonvitinh {
            get { return tendonvitinh;}
            set { tendonvitinh = value; }
        }
    }
}
