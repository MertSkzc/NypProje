using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Terminal
    {
        public int SeriNo { get; set; }
        public Satis satis { get; set; }
        public KasaGorevlisi Gorevli { get; set; }
        public Terminal()
        {
            this.satis = new Satis();
            this.Gorevli = new KasaGorevlisi();
        }
    }
}
