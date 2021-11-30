namespace HotelDataEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 100),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        photo = c.String(),
                        Gender = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Password = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 500),
                        Mobile = c.String(nullable: false, maxLength: 15),
                        City_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cancelations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CheckOutTime = c.DateTime(nullable: false),
                        CheckInTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        Meal_Id = c.Int(nullable: false),
                        Partner_Id = c.Int(nullable: false),
                        City_Id = c.Int(nullable: false),
                        Cancelation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cancelations", t => t.Cancelation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Partners", t => t.Partner_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Meal_Id)
                .Index(t => t.Partner_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Cancelation_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Zip_code = c.Int(nullable: false),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_Id, cascadeDelete: true)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GuestReviewHotels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        stars = c.Int(nullable: false),
                        Feedback = c.String(),
                        Guest_Id = c.Int(nullable: false),
                        Hotel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Guests", t => t.Guest_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Guest_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        TimeCreated = c.DateTime(nullable: false),
                        DiscountPercent = c.Int(nullable: false),
                        NoOfAdults = c.Int(nullable: false),
                        NoOfChilds = c.Int(nullable: false),
                        Guest_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Guests", t => t.Guest_Id, cascadeDelete: true)
                .Index(t => t.Guest_Id);
            
            CreateTable(
                "dbo.Reserve_Room",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Reservation_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Room_Type_Id = c.Int(nullable: false),
                        Hotel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .ForeignKey("dbo.Room_Type", t => t.Room_Type_Id, cascadeDelete: true)
                .Index(t => t.Room_Type_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.Room_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type_Name = c.String(),
                        Rate = c.String(),
                        View = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.PartnerInvoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Inoice_Amount = c.Int(nullable: false),
                        TimePaid = c.DateTime(nullable: false),
                        TimeCanceled = c.DateTime(nullable: false),
                        DepitAmount = c.Int(nullable: false),
                        CreditAmount = c.Int(nullable: false),
                        Partner_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Partners", t => t.Partner_Id, cascadeDelete: true)
                .Index(t => t.Partner_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hotel_Id = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hotel_Id = c.Int(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Hotel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Phones", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "Partner_Id", "dbo.Partners");
            DropForeignKey("dbo.Partners", "ID", "dbo.Users");
            DropForeignKey("dbo.PartnerInvoices", "Partner_Id", "dbo.Partners");
            DropForeignKey("dbo.Hotels", "Meal_Id", "dbo.Meals");
            DropForeignKey("dbo.GuestReviewHotels", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.GuestReviewHotels", "Guest_Id", "dbo.Guests");
            DropForeignKey("dbo.Guests", "ID", "dbo.Users");
            DropForeignKey("dbo.Reserve_Room", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Room_Type_Id", "dbo.Room_Type");
            DropForeignKey("dbo.Rooms", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Reserve_Room", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Guest_Id", "dbo.Guests");
            DropForeignKey("dbo.Hotels", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Hotels", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Hotels", "Cancelation_Id", "dbo.Cancelations");
            DropForeignKey("dbo.Admins", "ID", "dbo.Users");
            DropIndex("dbo.Photos", new[] { "Hotel_Id" });
            DropIndex("dbo.Phones", new[] { "Hotel_Id" });
            DropIndex("dbo.PartnerInvoices", new[] { "Partner_Id" });
            DropIndex("dbo.Partners", new[] { "ID" });
            DropIndex("dbo.Rooms", new[] { "Hotel_Id" });
            DropIndex("dbo.Rooms", new[] { "Room_Type_Id" });
            DropIndex("dbo.Reserve_Room", new[] { "Room_Id" });
            DropIndex("dbo.Reserve_Room", new[] { "Reservation_Id" });
            DropIndex("dbo.Reservations", new[] { "Guest_Id" });
            DropIndex("dbo.Guests", new[] { "ID" });
            DropIndex("dbo.GuestReviewHotels", new[] { "Hotel_Id" });
            DropIndex("dbo.GuestReviewHotels", new[] { "Guest_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropIndex("dbo.Hotels", new[] { "Cancelation_Id" });
            DropIndex("dbo.Hotels", new[] { "City_Id" });
            DropIndex("dbo.Hotels", new[] { "Partner_Id" });
            DropIndex("dbo.Hotels", new[] { "Meal_Id" });
            DropIndex("dbo.Hotels", new[] { "Category_Id" });
            DropIndex("dbo.Admins", new[] { "ID" });
            DropTable("dbo.Photos");
            DropTable("dbo.Phones");
            DropTable("dbo.PartnerInvoices");
            DropTable("dbo.Partners");
            DropTable("dbo.Meals");
            DropTable("dbo.Room_Type");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reserve_Room");
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
            DropTable("dbo.GuestReviewHotels");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Categories");
            DropTable("dbo.Hotels");
            DropTable("dbo.Cancelations");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
