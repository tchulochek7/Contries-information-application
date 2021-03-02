namespace CoutriesInformationAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        CapitalId = c.Int(),
                        Area = c.Double(nullable: false),
                        Population = c.Int(nullable: false),
                        RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CapitalId)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.CapitalId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Countries", "CapitalId", "dbo.Cities");
            DropIndex("dbo.Countries", new[] { "RegionId" });
            DropIndex("dbo.Countries", new[] { "CapitalId" });
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
