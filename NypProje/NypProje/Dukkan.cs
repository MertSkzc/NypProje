using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Dukkan
    {
        public UrunKatalogu katolog { get; set; }           //aggregation
        public List<Terminal> Terminaller{ get; set; }
        public List<Musteri>  Musteriler { get; set; }
        public HesapDefteri Hesap { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public long Telefon { get; set; }
        public Dukkan()
        {            
            this.Terminaller =new List<Terminal>();
            this.Hesap = new HesapDefteri();
            this.Musteriler = new List<Musteri>();
        }
        


        
    }
}
