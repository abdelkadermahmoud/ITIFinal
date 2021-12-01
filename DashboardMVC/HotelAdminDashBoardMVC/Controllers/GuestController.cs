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

        private List<User> AllGuests()
        {
            var person = new List<User>();

            person = (from p in UserModelRepository.Get()
                      join e in GuestModelRepository.Get()
                      on p.ID equals e.ID
                      select p).ToList();
            return person;
        }
        public GuestController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
            GuestModelRepository = UnitOfWork.GetGuestRepo();
            UserModelRepository = UnitOfWork.GetUserRepo();
        }
        public ActionResult Index()
        {
                        
            return View(AllGuests());
        }

        public ActionResult Block(int? id)
        {


            //if (id == null || id <= 0)
            //    return Redirect("/User/Login");

           // ViewBag.Title = $"Edit User With {id}";
            User Temp = UserModelRepository.Get(id.Value);
            //if (Temp == null)
            //    return Redirect("/User/Login");
            Temp.Status = Status.Blocked;
            UserModelRepository.Edit(Temp);
            UnitOfWork.Save();
            //UserEditViewModel UserEditView = Temp.ToEditableModel();

            return PartialView("_GuestsList", AllGuests());
            //return Redirect("/Guest/Index");
        }
    }
}