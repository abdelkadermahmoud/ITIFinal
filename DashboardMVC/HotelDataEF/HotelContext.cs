using HotelModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDataEF
{
    public class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelDB")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Cancelation> Cancelations { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<GuestReviewHotel> GuestReviewHotels { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<PartnerInvoice> PartnerInvoices { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Reserve_Room> Reserve_Rooms { get; set; }
        public virtual DbSet<Room_Type> Room_Type { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<HotelModels.Room> Rooms { get; set; }
    }
}