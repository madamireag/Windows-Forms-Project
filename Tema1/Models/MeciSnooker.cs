using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Models
{
   public class MeciSnooker:Meci
    {
        public string Jucator1 { get; set; }
        public string Jucator2 { get; set; }
        
        public float CotaCastigator1 { get; set; }
        public float CotaCastigator2 { get; set; }
        public MeciSnooker():base()
        {

        }
        public MeciSnooker(DateTime datam,TipMeci sp,string jucator,string oponent) : base(datam,sp)
        {
            this.Jucator1 = jucator;
            this.Jucator2 = oponent;
        }
    }
}
