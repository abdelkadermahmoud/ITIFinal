using HotelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry
{
   public interface IUnitOfWork
    {
        IModelRepository<User> GetUserRepo();
        IModelRepository<Guest> GetGuestRepo();
        IModelRepository<Admin> GetAdminRepo();
        IModelRepository<Partner> GetPartnerRepo();
        IModelRepository<Hotel> GetHotelRepo();
        IModelRepository<Cancelation> GetCancelationRepo();
        IModelRepository<Category> GetCategoryRepo();
        IModelRepository<City> GetCityRepo();
        IModelRepository<Country> GetCountryRepo();
        IModelRepository<GuestReviewHotel> GetGuestReviewHotelRepo();
        IModelRepository<Meal> GetMealRepo();
        IModelRepository<Phones> GetPhonesRepo();
        IModelRepository<Photos> GetPhotosRepo();
        IModelRepository<Reservation> GetReservationRepo();
        IModelRepository<Reserve_Room> GetReserve_RoomRepo();
        IModelRepository<Room> GetRoomRepo();
        IModelRepository<Room_Type> GetRoom_TypeRepo();
        void Save();

    }
}
