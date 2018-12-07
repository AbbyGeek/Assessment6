using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult Index()
        {
            Ass7Entities ORM = new Ass7Entities();
            ViewBag.GuestList = ORM.GuestTables.ToList();
            return View();
        }

        public ActionResult AddGuest(GuestTable newGuest)
        {
            Ass7Entities ORM = new Ass7Entities();
            ORM.GuestTables.Add(newGuest);
            ORM.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EditGuest(int ID)
        {
            Ass7Entities ORM = new Ass7Entities();
            GuestTable found = ORM.GuestTables.Find(ID);
            return View(found);
        }

        public ActionResult DeleteGuest(int ID)
        {
            Ass7Entities ORM = new Ass7Entities();
            GuestTable found = ORM.GuestTables.Find(ID);

            ORM.GuestTables.Remove(found);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SaveChanges(GuestTable updatedGuest)
        {
            Ass7Entities ORM = new Ass7Entities();
            GuestTable oldGuest = ORM.GuestTables.Find(updatedGuest.GuestID);

            oldGuest.FirstName = updatedGuest.FirstName;
            oldGuest.LastNAme = updatedGuest.LastNAme;
            oldGuest.Email = updatedGuest.Email;
            oldGuest.AttendanceDate = updatedGuest.AttendanceDate;
            oldGuest.Guest = updatedGuest.Guest;
            

            ORM.Entry(oldGuest).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}