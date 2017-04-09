using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Satis
    {
        public decimal Tutar { get; set; }
        public DateTime SatisTarihi { get; set; }
        public Odeme odeme{ get; set; }
        public Musteri musteri{ get; set; }
        public Satis()
        {
            this.musteri = new Musteri();
            this.odeme = new Odeme();
        }
        public Satis(Musteri m)
        {
            this.musteri = m;
            this.odeme = new Odeme();
            this.SatisTarihi = new DateTime();
        }
    }
}
