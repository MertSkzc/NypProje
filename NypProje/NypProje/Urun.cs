using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Urun:UrunTanimi
    {
        public string UrunAdi{ get; set; }

        public SatisKalemi Stok{ get; set; }

        public Urun()
        {
            this.Stok = new SatisKalemi();
        }

        public override string UrunBilgisiGoster()
        {
           string temp = "";

            temp += "Kod:" + UrunKodu + " Urun Adı:" + UrunAdi + " Stok:" + Stok.Miktar + " Fiyat:" + Fiyat + " TL";

            return temp;
        }

        
    }
}
