using DayFiveOfSohag.Filters;
using HotelModels;
using Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdminDashBoardMVC.Controllers
{
    [CheckAdminIdentity]
    public class PartnerController : Controller
    {
        // GET: Guest
        IUnitOfWork UnitOfWork;
        IModelRepository<Partner> PartnerModelRepository;
        IModelRepository<User> UserModelRepository;

        private List<User> AllPartner()
        {
            var person = new List<User>();

            person = (from p in UserModelRepository.Get()
                      join e in PartnerModelRepository.Get()
                      on p.ID equals e.ID
                      select p).ToList();
            return person;
        }
        public PartnerController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
            PartnerModelRepository = UnitOfWork.GetPartnerRepo();
            UserModelRepository = UnitOfWork.GetUserRepo();
        }
        public ActionResult Index()
        {

            return View(AllPartner());
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

            return PartialView("_UsersList", AllPartner());
            //return Redirect("/Guest/Index");
        }
    }
}