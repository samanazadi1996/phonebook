using phonebook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phonebook.Controllers
{
    public class HomeController : Controller
    {
        databasecontext db = new databasecontext();
        public ActionResult Index()
        {
            return View(db.pbs.ToList());
        }
        [HttpPost]
        public ActionResult Index(string query)
        {
            var tmp = from item in db.pbs select item;
            if (!string.IsNullOrEmpty(query))
            {
                tmp = tmp.Where(x => x.fname.Contains(query));
            }
            return View(tmp);
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(pb pb)
        {

            if (string.IsNullOrEmpty(pb.Email))
            {
                pb.Email = "null";
            }
            db.pbs.Add(pb);
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult edit(int id)
        {
            pb pb = db.pbs.Find(id);
            return View(pb);
        }
        [HttpPost]
        public ActionResult edit(pb pb)
        {
            db.Entry(pb).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult delete(int id)
        {
            pb pb = db.pbs.Find(id);
            db.pbs.Remove(pb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}