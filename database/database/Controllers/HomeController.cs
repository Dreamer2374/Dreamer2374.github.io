using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using database.Models;

namespace database.Controllers
{
    public class HomeController : Controller
    {

        TrafficContext db = new TrafficContext();

        public ActionResult Index()
        {


            var Traffics = db.Traffics;
            ViewBag.Traffics = Traffics;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet] //Удаление
        public ActionResult Delete(int? id)
        {
            if (id == null)
            { return HttpNotFound(); }

            var Index = db.Traffics.Find(id);
            db.Traffics.Remove(Index);
            db.SaveChanges();

            var Traf  = db.Traffics;
            ViewBag.Traffics = Traf;
            return RedirectToAction("Index");
        }


        [HttpPost] //поиск пост обработка
        public ActionResult Search(string somvar)
        {
            var allresults = db.Traffics.Where(a => a.DriverName.Contains(somvar)).ToList();
            //allresults = db.Traffics.Where(a => a.Amount.Equals(Convert.ToInt16(somvar))).ToList();
            return PartialView(allresults);
        }

        [HttpGet]
        public ActionResult Create()
        {
            //SelectList All = new SelectList(db.Traffics, "ID", "FirmName", "EventDate");
            //ViewBag.All = All;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Traffic traffic)
        {
            db.Traffics.Add(traffic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }
    }
}