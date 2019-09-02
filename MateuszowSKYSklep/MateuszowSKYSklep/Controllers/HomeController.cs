using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MateuszowSKYSklep.DAL;
using MateuszowSKYSklep.Models;
using MateuszowSKYSklep.ViewModels;

namespace MateuszowSKYSklep.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Home
        public ActionResult Index()
        {
            var preOrders = db.Games.Where(a => !a.IsHidden && a.IsPreOrder).OrderByDescending(a => a.DatePremiere).Take(3).ToList();
            var randoms = db.Games.Where(a => !a.IsHidden).OrderBy(a => Guid.NewGuid()).Take(8).ToList();

            var vm = new HomeViewModel()
            {
                PreOrders = preOrders,
                Randoms = randoms
            };

            return View(vm);
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }

        [ChildActionOnly]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView("_GenresMenu", genres);
        }

        public ActionResult GamesSuggestions(string term)
        {
            var games =
                this.db.Games.Where(g => !g.IsHidden && g.GameTitle.ToLower().Contains(term.ToLower()))
                    .Take(5)
                    .Select(g => new {label = g.GameTitle, id = g.GameId});

            return Json(games, JsonRequestBehavior.AllowGet);
        }
    }
}