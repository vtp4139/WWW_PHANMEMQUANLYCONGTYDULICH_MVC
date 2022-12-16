namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAllDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        IDCard = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(),
                        CustomerID = c.Int(nullable: false),
                        TourID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Tour", t => t.TourID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.TourID);
            
            CreateTable(
                "dbo.Tour",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TourName = c.String(),
                        DepartureDate = c.DateTime(nullable: false),
                        NumberOfDay = c.Int(nullable: false),
                        StartAddress = c.String(),
                        Price = c.Double(nullable: false),
                        NumSeat = c.Int(nullable: false),
                        EmptySeat = c.Int(nullable: false),
                        TourType = c.Boolean(nullable: false),
                        Describe = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(),
                        Title = c.String(),
                        Content = c.String(),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Feedback", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Bill", "TourID", "dbo.Tour");
            DropForeignKey("dbo.Bill", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Feedback", new[] { "CustomerID" });
            DropIndex("dbo.Bill", new[] { "TourID" });
            DropIndex("dbo.Bill", new[] { "CustomerID" });
            DropIndex("dbo.Account", new[] { "CustomerID" });
            DropTable("dbo.Feedback");
            DropTable("dbo.Tour");
            DropTable("dbo.Bill");
            DropTable("dbo.Customer");
            DropTable("dbo.Account");
        }
    }
}
