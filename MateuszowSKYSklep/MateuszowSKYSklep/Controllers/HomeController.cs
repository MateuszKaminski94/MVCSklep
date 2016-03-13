using System;
using System.Collections.Generic;
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
            var genres = db.Genres.ToList();
            var preOrders = db.Games.Where(a => !a.IsHidden && a.IsPreOrder).OrderByDescending(a => a.DateAdded).Take(1).ToList();
            var randoms = db.Games.Where(a => !a.IsHidden).OrderBy(a => Guid.NewGuid()).Take(4).ToList();

            var vm = new HomeViewModel()
            {
                Genres = genres,
                PreOrders = preOrders,
                Randoms = randoms
            };

            return View(vm);
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}