//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Tema1.Models
{
    public class PariuriContext:DbContext
    {
       
        public PariuriContext() : base(){
            
        }
      
        public DbSet<Pariu> Pariuri {get;set;}
        public DbSet<MeciSnooker> MeciuriSnooker { get; set; }

       
    }
}
