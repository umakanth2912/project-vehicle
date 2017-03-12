namespace VehicleDealerDal.cs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        VehicleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Modeels",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                        ModelColor = c.String(),
                        ModelYear = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        DealerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.Dealers", t => t.DealerId, cascadeDelete: true)
                .Index(t => t.DealerId);
            
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        DealerId = c.Int(nullable: false, identity: true),
                        DealerName = c.String(),
                        DealerCity = c.String(),
                        DealerCountry = c.String(),
                        DealerPhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DealerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Brands", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "DealerId", "dbo.Dealers");
            DropForeignKey("dbo.Modeels", "BrandId", "dbo.Brands");
            DropIndex("dbo.Vehicles", new[] { "DealerId" });
            DropIndex("dbo.Modeels", new[] { "BrandId" });
            DropIndex("dbo.Brands", new[] { "VehicleId" });
            DropTable("dbo.Dealers");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Modeels");
            DropTable("dbo.Brands");
        }
    }
}
