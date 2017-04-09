using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Musteri:Kisi
    {
        public long MusteriNo{ get; set; }
        public Sepet sepet { get; set; }
        public Musteri()
        {
            this.sepet = new Sepet();
        }

        public override string KisiBilgiGoster()
        {
            return base.KisiBilgiGoster();
        }
    }
}
