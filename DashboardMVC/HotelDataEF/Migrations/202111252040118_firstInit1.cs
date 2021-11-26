namespace HotelDataEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstInit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GuestReviewHotels", "Guest_Id", c => c.Int(nullable: false));
            AddColumn("dbo.GuestReviewHotels", "Hotel_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.GuestReviewHotels", "Guest_Id");
            CreateIndex("dbo.GuestReviewHotels", "Hotel_Id");
            AddForeignKey("dbo.GuestReviewHotels", "Guest_Id", "dbo.Guests", "ID", cascadeDelete: true);
            AddForeignKey("dbo.GuestReviewHotels", "Hotel_Id", "dbo.Hotels", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuestReviewHotels", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.GuestReviewHotels", "Guest_Id", "dbo.Guests");
            DropIndex("dbo.GuestReviewHotels", new[] { "Hotel_Id" });
            DropIndex("dbo.GuestReviewHotels", new[] { "Guest_Id" });
            DropColumn("dbo.GuestReviewHotels", "Hotel_Id");
            DropColumn("dbo.GuestReviewHotels", "Guest_Id");
        }
    }
}
