using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public abstract class UrunTanimi
    {
        public int UrunKodu { get; set; }
        public string Aciklama{ get; set; }
        public decimal Fiyat { get; set; }
        public int UrunSepetAdeti { get; set; }
        public UrunTanimi()
        {
            UrunSepetAdeti = 0;
        }
        public abstract string UrunBilgisiGoster();
    }
}
