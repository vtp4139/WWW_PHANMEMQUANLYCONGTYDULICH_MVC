namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customer", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        customerName = c.String(),
                        IDCard = c.String(),
                        phone = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        billID = c.Int(nullable: false, identity: true),
                        dateCreate = c.DateTime(nullable: false),
                        customerID = c.Int(nullable: false),
                        tourID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.billID)
                .ForeignKey("dbo.Customer", t => t.customerID, cascadeDelete: true)
                .ForeignKey("dbo.Tour", t => t.tourID, cascadeDelete: true)
                .Index(t => t.customerID)
                .Index(t => t.tourID);
            
            CreateTable(
                "dbo.Tour",
                c => new
                    {
                        tourID = c.Int(nullable: false, identity: true),
                        tourName = c.String(),
                        departureDate = c.DateTime(nullable: false),
                        numberOfDay = c.Int(nullable: false),
                        startAddress = c.String(),
                        price = c.Double(nullable: false),
                        numSeat = c.Int(nullable: false),
                        emptySeat = c.Int(nullable: false),
                        tourType = c.Boolean(nullable: false),
                        Describe = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.tourID);
            
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        feedbackID = c.Int(nullable: false, identity: true),
                        dateCreate = c.DateTime(nullable: false),
                        title = c.String(),
                        content = c.String(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.feedbackID)
                .ForeignKey("dbo.Customer", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "customerID", "dbo.Customer");
            DropForeignKey("dbo.Feedback", "customerID", "dbo.Customer");
            DropForeignKey("dbo.Bill", "tourID", "dbo.Tour");
            DropForeignKey("dbo.Bill", "customerID", "dbo.Customer");
            DropIndex("dbo.Feedback", new[] { "customerID" });
            DropIndex("dbo.Bill", new[] { "tourID" });
            DropIndex("dbo.Bill", new[] { "customerID" });
            DropIndex("dbo.Account", new[] { "customerID" });
            DropTable("dbo.Feedback");
            DropTable("dbo.Tour");
            DropTable("dbo.Bill");
            DropTable("dbo.Customer");
            DropTable("dbo.Account");
        }
    }
}
