namespace Tema1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeciSnookers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jucator1 = c.String(),
                        Jucator2 = c.String(),
                        CotaCastigator1 = c.Single(nullable: false),
                        CotaCastigator2 = c.Single(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Sport = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parius",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Suma = c.Single(nullable: false),
                        CastigatorSelectat = c.String(),
                        CotaCastigator = c.Single(nullable: false),
                        meci_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MeciSnookers", t => t.meci_Id)
                .Index(t => t.meci_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parius", "meci_Id", "dbo.MeciSnookers");
            DropIndex("dbo.Parius", new[] { "meci_Id" });
            DropTable("dbo.Parius");
            DropTable("dbo.MeciSnookers");
        }
    }
}
