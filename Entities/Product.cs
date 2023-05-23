using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        protected int mathuoc;
        protected string tenthuoc;
        protected float giaban;
        protected DateTime hansudung;
        protected int madonvitinh;
        protected bool dungkinhdoanh;
        protected int soluong;
        public Product()
        {

        }

        public Product(int mathuoc, string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh, int soluong)
        {
            this.mathuoc = mathuoc;
            this.tenthuoc = tenthuoc;
            this.giaban = giaban;
            this.hansudung = hansudung;
            this.madonvitinh = madonvitinh;
            this.dungkinhdoanh = dungkinhdoanh;
            this.soluong = soluong;
        }

        public Product(string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh,int soluong)
        {
            this.tenthuoc = tenthuoc;
            this.giaban = giaban;
            this.hansudung = hansudung;
            this.madonvitinh = madonvitinh;
            this.dungkinhdoanh = dungkinhdoanh;
            this.soluong = soluong;
        }
        public int Mathuoc
        {
            get { return mathuoc; }
            set { mathuoc = value; }
        }

        public string Tenthuoc {
            get { return tenthuoc; }
            set { tenthuoc = value; }
        }
        public float Giaban
        {
            get { return giaban; }  
            set { giaban = value; }
        }
        public DateTime Hansudung
        {
            get { return hansudung; }
            set
            {
                hansudung = value;
            }
        }     
        public int Madonvitinh
        {
            get { return madonvitinh;}
            set { madonvitinh = value; }
        }

        public bool Dungkinhdoanh { get => dungkinhdoanh; set => dungkinhdoanh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
