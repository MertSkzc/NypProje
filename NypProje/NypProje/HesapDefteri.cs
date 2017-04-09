using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class HesapDefteri
    {
        public List<Satis> Satislar { get; set; }
        public HesapDefteri()
        {
            this.Satislar = new List<Satis>();
        }
    }
}
