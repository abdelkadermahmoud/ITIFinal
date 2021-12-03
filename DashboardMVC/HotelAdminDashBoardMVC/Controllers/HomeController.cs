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
    public class HomeController : Controller
    {
        IUnitOfWork UnitOfWork;
        IModelRepository<Admin> AdminModelRepository;
        IModelRepository<User> UserModelRepository;

        private List<User> AllAdmin()
        {
            var person = new List<User>();

            person = (from p in UserModelRepository.Get()
                      join e in AdminModelRepository.Get()
                      on p.ID equals e.ID
                      select p).ToList();
            return person;
        }
        public HomeController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
            AdminModelRepository = UnitOfWork.GetAdminRepo();
            UserModelRepository = UnitOfWork.GetUserRepo();
        }
        [CheckAdminIdentity]
        public ActionResult Index()
        {
            return View();
        }

        [CheckAdminIdentity]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(AdminLoginModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
                

            User SelectedUser = AllAdmin()
                .FirstOrDefault(i => i.UserName == user.UserName
                     && i.Password == user.Password);

            if (SelectedUser == null)
            {
                ViewBag.error = "invalid username or password";
                return View();
            }

            Session["User"] = User;
            return Redirect("/Home/Index");
        }
    }
    }