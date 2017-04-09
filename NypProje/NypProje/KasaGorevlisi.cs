using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NypProje
{
    public class KasaGorevlisi:Kisi
    {
        public string TCKimlikNo{ get; set; }
        public override string KisiBilgiGoster()
        {
            return base.KisiBilgiGoster()+"KimlikNo :"+TCKimlikNo ;
            
        }
    }
}
