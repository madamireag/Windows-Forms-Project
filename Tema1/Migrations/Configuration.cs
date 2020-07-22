namespace Tema1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tema1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Tema1.Models.PariuriContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Tema1.Models.PariuriContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<MeciSnooker> meciuri = new List<MeciSnooker> {
            new MeciSnooker{Id=1,Sport=TipMeci.SNOOKER,Data=DateTime.Today,Jucator1="Selby",Jucator2="Ding",CotaCastigator1=2,CotaCastigator2=1}


            };
            {
                foreach (var e in context.MeciuriSnooker) context.MeciuriSnooker.Remove(e);
                context.SaveChanges();
            }
            context.MeciuriSnooker.AddOrUpdate(x => x.Id, meciuri.ToArray());

            context.SaveChanges();
        }
        }
}
