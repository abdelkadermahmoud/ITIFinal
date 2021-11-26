using HotelModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDataEF
{
    internal class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Cancelation> Cancelations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<GuestReviewHotel> GuestReviewHotels { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<PartnerInvoice> PartnerInvoices { get; set; }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Reserve_Room> Reserve_Rooms { get; set; }
        public DbSet<Room_Type> Room_Types { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}