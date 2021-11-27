using HotelDataEF;
using HotelModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry
{
    public class UnitOfWork
        : IUnitOfWork
    {
        DbContext Context;
        IModelRepository<User> UserRepo;
        IModelRepository<Guest> GuestRepo;
        IModelRepository<Partner>  PartnerRepo;
        IModelRepository<Admin> AdminRepo;
        IModelRepository<Cancelation>  CancelationRepo;
        IModelRepository<Category> CategoryRepo;
        IModelRepository<City> CityRepo;
        IModelRepository<Country>  CountryRepo;
        IModelRepository<GuestReviewHotel>  GuestReviewHotelRepo;
        IModelRepository<Hotel>  HotelRepo;
        IModelRepository<Meal>  MealRepo;
        IModelRepository<PartnerInvoice>  PartnerInvoiceRepo;
        IModelRepository<Phones>  PhonesRepo;
        IModelRepository<Photos>  PhotosRepo;
        IModelRepository<Reservation>  ReservationRepo;
        IModelRepository<Reserve_Room>  Reserve_RoomRepo;
        IModelRepository<Room>  RoomRepo;
        IModelRepository<Room_Type> Room_TypeRepo;

        public UnitOfWork(IDBContextFactory _Factory,
            IModelRepository<User> _UserRepo,
            IModelRepository<Guest> _GuestRepo,
             IModelRepository<Partner> _PartnerRepo,
            IModelRepository<Admin> _AdminRepo,
             IModelRepository<Cancelation> _CancelationRepo,
            IModelRepository<Category> _CategoryRepo,
             IModelRepository<City> _CityRepo,
            IModelRepository<Country> _CountryRepo,
             IModelRepository<GuestReviewHotel> _GuestReviewHotelRepo,
            IModelRepository<Hotel> _HotelRepo,
             IModelRepository<Meal> _MealRepo,
            IModelRepository<PartnerInvoice> _PartnerInvoiceRepo,
             IModelRepository<Phones> _PhonesRepo,
             IModelRepository<Photos> _PhotosRepo,
              IModelRepository<Reservation> _ReservationRepo,
             IModelRepository<Reserve_Room> _Reserve_RoomRepo,
              IModelRepository<Room> _RoomRepo,
             IModelRepository<Room_Type> _Room_TypeRepo


            )
        {
            Context = _Factory.GetContext();
            UserRepo = _UserRepo;
            GuestRepo = _GuestRepo;
            PartnerRepo=_PartnerRepo;
            AdminRepo= _AdminRepo;
            CancelationRepo= _CancelationRepo;
            CategoryRepo= _CategoryRepo;
            CityRepo= _CityRepo;
            CountryRepo = _CountryRepo;
            GuestReviewHotelRepo = _GuestReviewHotelRepo;
            HotelRepo= _HotelRepo;
            MealRepo= _MealRepo;
            PartnerInvoiceRepo= _PartnerInvoiceRepo;
            PhonesRepo= _PhonesRepo;
            PhotosRepo= _PhotosRepo;
            ReservationRepo= _ReservationRepo;
            Reserve_RoomRepo= _Reserve_RoomRepo;
            RoomRepo= _RoomRepo;
            Room_TypeRepo= _Room_TypeRepo;
        }

        public IModelRepository<User> GetUserRepo()
        {
            return UserRepo;
        }

        public IModelRepository<Guest> GetGuestRepo()
        {
            return GuestRepo;
        }
        public IModelRepository<Admin> GetAdminRepo()
        {
            return AdminRepo;
        }

        public IModelRepository<Partner> GetPartnerRepo()
        {
            return PartnerRepo;
        }
        public IModelRepository<Hotel> GetHotelRepo()
        {
            return HotelRepo;
        }

        public IModelRepository<Cancelation> GetCancelationRepo()
        {
            return CancelationRepo;
        }

        public IModelRepository<Category> GetCategoryRepo()
        {
            return CategoryRepo;
        }

        public IModelRepository<City> GetCityRepo()
        {
            return CityRepo;
        }

        public IModelRepository<Country> GetCountryRepo()
        {
            return CountryRepo;
        }

        public IModelRepository<GuestReviewHotel> GetGuestReviewHotelRepo()
        {
            return GuestReviewHotelRepo;
        }

        public IModelRepository<Meal> GetMealRepo()
        {
            return MealRepo;
        }

        public IModelRepository<Phones> GetPhonesRepo()
        {
            return PhonesRepo;
        }

        public IModelRepository<Photos> GetPhotosRepo()
        {
            return PhotosRepo;
        }

        public IModelRepository<Reservation> GetReservationRepo()
        {
            return ReservationRepo;
        }

        public IModelRepository<Reserve_Room> GetReserve_RoomRepo()
        {
            return Reserve_RoomRepo;
        }

        public IModelRepository<Room> GetRoomRepo()
        {
            return RoomRepo;
        }

        public IModelRepository<Room_Type> GetRoom_TypeRepo()
        {
            return Room_TypeRepo;
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
