namespace ITS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CityCategorys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LocationCategorys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                        Status = c.Boolean(),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CityCategorys", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Contact = c.String(nullable: false, maxLength: 50),
                        IP = c.String(maxLength: 500),
                        Address = c.String(nullable: false, maxLength: 500),
                        Rate = c.Double(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        OpenTime = c.DateTimeOffset(nullable: false, precision: 7),
                        ClosedTime = c.DateTimeOffset(nullable: false, precision: 7),
                        URL = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        MoreImages = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Detail = c.String(maxLength: 500),
                        HomeFlag = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LocationCategorys", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.LocationTags",
                c => new
                    {
                        LocationID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.LocationID, t.TagID })
                .ForeignKey("dbo.Locations", t => t.LocationID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.LocationID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlanDetails",
                c => new
                    {
                        PlanID = c.Int(nullable: false),
                        Content = c.String(maxLength: 2000),
                        CreatedDay = c.DateTime(nullable: false),
                        SetDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanID)
                .ForeignKey("dbo.Plans", t => t.PlanID)
                .Index(t => t.PlanID);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 200),
                        UserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 20),
                        Content = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StopPoints",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Image = c.String(maxLength: 256),
                        Content = c.String(maxLength: 2000),
                        IP = c.String(nullable: false, maxLength: 2000),
                        TripID = c.Int(nullable: false),
                        IsFinish = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Trips", t => t.TripID, cascadeDelete: true)
                .Index(t => t.TripID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDay = c.DateTimeOffset(nullable: false, precision: 7),
                        StopDay = c.DateTimeOffset(nullable: false, precision: 7),
                        UserID = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StopPoints", "TripID", "dbo.Trips");
            DropForeignKey("dbo.Trips", "UserID", "dbo.Users");
            DropForeignKey("dbo.PlanDetails", "PlanID", "dbo.Plans");
            DropForeignKey("dbo.Plans", "UserId", "dbo.Users");
            DropForeignKey("dbo.LocationTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.LocationTags", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.Locations", "CategoryID", "dbo.LocationCategorys");
            DropForeignKey("dbo.LocationCategorys", "CityID", "dbo.CityCategorys");
            DropIndex("dbo.Trips", new[] { "UserID" });
            DropIndex("dbo.StopPoints", new[] { "TripID" });
            DropIndex("dbo.Plans", new[] { "UserId" });
            DropIndex("dbo.PlanDetails", new[] { "PlanID" });
            DropIndex("dbo.LocationTags", new[] { "TagID" });
            DropIndex("dbo.LocationTags", new[] { "LocationID" });
            DropIndex("dbo.Locations", new[] { "CategoryID" });
            DropIndex("dbo.LocationCategorys", new[] { "CityID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.Trips");
            DropTable("dbo.StopPoints");
            DropTable("dbo.Users");
            DropTable("dbo.Plans");
            DropTable("dbo.PlanDetails");
            DropTable("dbo.Tags");
            DropTable("dbo.LocationTags");
            DropTable("dbo.Locations");
            DropTable("dbo.LocationCategorys");
            DropTable("dbo.Footers");
            DropTable("dbo.CityCategorys");
        }
    }
}
