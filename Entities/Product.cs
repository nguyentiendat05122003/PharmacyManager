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
        protected int mancc;
        protected int madonvitinh;

        public Product()
        {

        }

        public Product(int mathuoc, string tenthuoc, float giaban, DateTime hansudung, int mancc, int madonvitinh)
        {
            this.mathuoc = mathuoc;
            this.tenthuoc = tenthuoc;
            this.giaban = giaban;
            this.hansudung = hansudung;
            this.mancc = mancc;
            this.madonvitinh = madonvitinh;
        }

        public Product(string tenthuoc, float giaban, DateTime hansudung, int mancc, int madonvitinh)
        {
            this.tenthuoc = tenthuoc;
            this.giaban = giaban;
            this.hansudung = hansudung;
            this.mancc = mancc;
            this.madonvitinh = madonvitinh;
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
        public int Mancc {
            get { return mancc; }
            set
            {
                mancc = value;
            }
        }
        public int Madonvitinh
        {
            get { return madonvitinh;}
            set { madonvitinh = value; }
        }

    }
}
