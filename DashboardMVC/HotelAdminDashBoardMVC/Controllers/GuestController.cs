using HotelModels;
using Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdminDashBoardMVC.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        IUnitOfWork UnitOfWork;
        IModelRepository<Guest> GuestModelRepository;
        IModelRepository<User> UserModelRepository;

        public GuestController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
            GuestModelRepository = UnitOfWork.GetGuestRepo();
            UserModelRepository = UnitOfWork.GetUserRepo();
        }
        public ActionResult Index()
        {
            var person = new List<User>();
            
                person = (from p in UserModelRepository.Get()
                          join e in GuestModelRepository.Get()
                          on p.ID equals e.ID 
                          select p).ToList();


            
            return View(person);
        }
    }
}