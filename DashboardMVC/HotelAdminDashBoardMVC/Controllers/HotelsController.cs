using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelDataEF;
using HotelModels;

namespace HotelAdminDashBoardMVC.Controllers
{
    public class HotelsController : Controller
    {
        private HotelContext db = new HotelContext();
        public HotelsController(IDBContextFactory _Factory)
        {
            db =(HotelContext) _Factory.GetContext();
        }
        // GET: Hotels
        public ActionResult Index()
        {
            var hotels = db.Hotels.Include(h => h.Cancelation).Include(h => h.Category).Include(h => h.City).Include(h => h.Meal).Include(h => h.Partner);
            return View(hotels.ToList());
        }

        // GET: Hotels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // GET: Hotels/Create
        public ActionResult Create()
        {
            ViewBag.Cancelation_Id = new SelectList(db.Cancelations, "ID", "Description");
            ViewBag.Category_Id = new SelectList(db.Categories, "ID", "Name");
            ViewBag.City_Id = new SelectList(db.Cities, "ID", "Name");
            ViewBag.Meal_Id = new SelectList(db.Meals, "ID", "Name");
            ViewBag.Partner_Id = new SelectList(db.Partners, "ID", "ID");
            return View();
        }

        // POST: Hotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,CheckInTime,CheckOutTime,IsActive,Category_Id,Meal_Id,Partner_Id,City_Id,Cancelation_Id")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                db.Hotels.Add(hotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cancelation_Id = new SelectList(db.Cancelations, "ID", "Description", hotel.Cancelation_Id);
            ViewBag.Category_Id = new SelectList(db.Categories, "ID", "Name", hotel.Category_Id);
            ViewBag.City_Id = new SelectList(db.Cities, "ID", "Name", hotel.City_Id);
            ViewBag.Meal_Id = new SelectList(db.Meals, "ID", "Name", hotel.Meal_Id);
            ViewBag.Partner_Id = new SelectList(db.Partners, "ID", "ID", hotel.Partner_Id);
            return View(hotel);
        }

        // GET: Hotels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cancelation_Id = new SelectList(db.Cancelations, "ID", "Description", hotel.Cancelation_Id);
            ViewBag.Category_Id = new SelectList(db.Categories, "ID", "Name", hotel.Category_Id);
            ViewBag.City_Id = new SelectList(db.Cities, "ID", "Name", hotel.City_Id);
            ViewBag.Meal_Id = new SelectList(db.Meals, "ID", "Name", hotel.Meal_Id);
            ViewBag.Partner_Id = new SelectList(db.Partners, "ID", "ID", hotel.Partner_Id);
            return View(hotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,CheckInTime,CheckOutTime,IsActive,Category_Id,Meal_Id,Partner_Id,City_Id,Cancelation_Id")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cancelation_Id = new SelectList(db.Cancelations, "ID", "Description", hotel.Cancelation_Id);
            ViewBag.Category_Id = new SelectList(db.Categories, "ID", "Name", hotel.Category_Id);
            ViewBag.City_Id = new SelectList(db.Cities, "ID", "Name", hotel.City_Id);
            ViewBag.Meal_Id = new SelectList(db.Meals, "ID", "Name", hotel.Meal_Id);
            ViewBag.Partner_Id = new SelectList(db.Partners, "ID", "ID", hotel.Partner_Id);
            return View(hotel);
        }

        // GET: Hotels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hotel hotel = db.Hotels.Find(id);
            db.Hotels.Remove(hotel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
