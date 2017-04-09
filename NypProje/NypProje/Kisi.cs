using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public virtual string KisiBilgiGoster()
        {
            string temp = "";
            temp +=this.Ad + " " + this.Soyad + Environment.NewLine;
            return temp;
        }
        public Kisi()
        {

        }

    }
}
