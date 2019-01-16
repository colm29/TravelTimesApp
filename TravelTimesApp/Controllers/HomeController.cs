using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTimesApp.Models;

namespace TravelTimesApp.Controllers
{
    public class HomeController : Controller
    {
        private HertzEntities _db = new HertzEntities();

        public ActionResult Index()
        {

            return View(_db.TravelTimes.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create([Bind(Exclude = "ID")] TravelTime travelTimetoCreate)


        {

            if (!ModelState.IsValid)

                return View();

            _db.TravelTimes.Add(travelTimetoCreate);

            _db.SaveChanges();

            return RedirectToAction("Index");

        }



        // GET: Home/Edit/5
        public ActionResult Edit(int ID)
        {
            var travelTimeToEdit = (from m in _db.TravelTimes

                                    where m.ID == ID

                                    select m).First();

            return View(travelTimeToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(TravelTime travelTimeToEdit)

        {

            var originalTravelTime = (from m in _db.TravelTimes

                                      where m.ID == travelTimeToEdit.ID

                                      select m).First();

            if (!ModelState.IsValid)

                return View(originalTravelTime);


            _db.Entry(originalTravelTime).CurrentValues.SetValues(travelTimeToEdit);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }


      
        public ActionResult Delete(int id)
        {
            try
            {
                TravelTime travelTimeToDelete = _db.TravelTimes.Find(id);
                _db.TravelTimes.Remove(travelTimeToDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
