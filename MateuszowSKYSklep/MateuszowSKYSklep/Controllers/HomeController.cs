using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MateuszowSKYSklep.DAL;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StoreContext db = new StoreContext();
            var genresList = db.Genres.ToList();

            return View();
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}