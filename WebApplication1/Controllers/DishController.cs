using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DishController : Controller
    {
        // GET: Dish
        public ActionResult Index()
        {
            Ass7Entities ORM = new Ass7Entities();
            ViewBag.DishTable = ORM.DishTables.ToList();
            return View();
        }

        public ActionResult AddDish(DishTable newDish)
        {
            Ass7Entities ORM = new Ass7Entities();
            ORM.DishTables.Add(newDish);
            ORM.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EditDish(int ID)
        {
            Ass7Entities ORM = new Ass7Entities();
            DishTable found = ORM.DishTables.Find(ID);
            return View(found);
        }

        public ActionResult DeleteDish(int ID)
        {
            Ass7Entities ORM = new Ass7Entities();
            DishTable found = ORM.DishTables.Find(ID);

            ORM.DishTables.Remove(found);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SaveChanges(DishTable updatedDish)
        {
            Ass7Entities ORM = new Ass7Entities();
            DishTable oldDish = ORM.DishTables.Find(updatedDish.DishID);

            oldDish.PersonName = updatedDish.PersonName;
            oldDish.DishName = updatedDish.DishName;
            oldDish.PhoneNumber = updatedDish.PhoneNumber;
            oldDish.DishDescription = updatedDish.DishDescription;
            oldDish.Option = updatedDish.Option;


            ORM.Entry(oldDish).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}