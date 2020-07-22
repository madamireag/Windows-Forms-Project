using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Models
{
    public class Pariu
    {
        public int Id { get; set; }
        public float Suma { get
            {
                return _suma;
            }
            set {
                if (value <= 0) throw new CustomExceptionSuma();
                _suma = value;
            } 
        }

        public string CastigatorSelectat { get; set; }
        public float CotaCastigator { get; set; }
        public MeciSnooker meci { get; set; }
       
      
        private float _suma;
        public Pariu()
        {

        }
        public Pariu(float suma,string castigat,float cota,MeciSnooker meci)
        {

            this.Suma = suma;
            this.CastigatorSelectat = castigat;
            this.CotaCastigator = cota;
            this.meci = meci;
        }

    }
}
