using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class UrunKatalogu
    {
        public List<Urun> Urunler { get; set; }

        public UrunKatalogu()
        {
            this.Urunler = new List<Urun>();
        }
    }
}
