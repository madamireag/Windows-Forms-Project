using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Models
{
    public abstract class Meci
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipMeci Sport { get; set; }
        public Meci() { }
        public Meci(DateTime date,TipMeci tip)
        {
            this.Data = date;
            this.Sport = tip;
        }
    }
}
