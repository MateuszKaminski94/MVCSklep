using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MateuszowSKYSklep.DAL;
using MateuszowSKYSklep.ViewModels;

namespace MateuszowSKYSklep.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var game = db.Games.Where(a => a.GameId == id).Take(1).Single();

            var links = Directory.EnumerateFiles(Server.MapPath("~/Content/Screens/"+id.ToString()));

            var vm = new DetailsViewModel()
            {
                Games = game,
                Links = links
            };

            return View(vm);
        }

        public ActionResult List(string genrename)
        {
            return View();
        }
    }
}