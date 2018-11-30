using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RSVP()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult BringDish()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RSVPLanding(Atendee newAtendee)
        {
            ViewBag.Message = "RSVP landing page";

            ViewBag.atendee = newAtendee;
            return View();
        }

        public ActionResult DishLanding(Dish newDish)
        {
            ViewBag.Message = "Dish landing page";

            ViewBag.dish = newDish;
            return View();
        }
    }
}