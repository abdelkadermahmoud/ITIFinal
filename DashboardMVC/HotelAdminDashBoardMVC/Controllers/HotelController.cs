using HotelModels;
using Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdminDashBoardMVC.Controllers
{
    public class HotelController : Controller
    {

        IUnitOfWork UnitOfWork;
        IModelRepository<Hotel> HotelModelRepository;
        IModelRepository<Cancelation> CancelationModelRepository;
        IModelRepository<Meal> MealModelRepository;
        IModelRepository<User> UserModelRepository;
        IModelRepository<City> CityModelRepository;
        IModelRepository<Category> CategoryModelRepository;

        public HotelController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
            HotelModelRepository = UnitOfWork.GetHotelRepo();
        }
        // GET: Hotels
        public List<Hotel> AllHotels()
        {
            return HotelModelRepository.Get().ToList();
        }

        // view: Hotel/Details/5
        public ActionResult Index()
        {

            return View(AllHotels());
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hotel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hotel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
