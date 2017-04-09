using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class Sepet
    {
        public List<Urun> Sepettekiler { get; set; }
        
        public Sepet()
        {
            this.Sepettekiler = new List<Urun>();
        }
    }
}
