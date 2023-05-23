using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Provider
    {
        private int mancc;
        protected string tenncc;
        protected string diachi;
        protected string dienthoai;
        protected string email;
        protected bool ngunghoptac;


        public int Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Email { get => email; set => email = value; }
        public bool Ngunghoptac { get => ngunghoptac; set => ngunghoptac = value; }

        public Provider()
        {

        }
        public Provider(string tenncc, string diachi, string dienthoai, string email,bool ngunghoptac)
        {
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.ngunghoptac |= ngunghoptac;
        }
        public Provider(Provider x)
        {
            this.tenncc = x.tenncc;
            this.diachi = x.diachi;
            this.dienthoai = x.dienthoai;
            this.email = x.email;
            this.ngunghoptac = x.ngunghoptac;
        }
        public Provider(int mancc,string tenncc, string diachi, string dienthoai, string email,bool ngunghoptac)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
            this.ngunghoptac = ngunghoptac;
        }
    }
}
