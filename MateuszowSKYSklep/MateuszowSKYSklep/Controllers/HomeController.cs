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
            var genres = db.Genres.ToList();
            var preOrders = db.Games.Where(a => !a.IsHidden && a.IsPreOrder).OrderByDescending(a => a.DatePremiere).Take(3).ToList();
            var randoms = db.Games.Where(a => !a.IsHidden).OrderBy(a => Guid.NewGuid()).Take(4).ToList();
            //var links = Directory.EnumerateFiles(Server.MapPath("~/Content/Screens/" + preOrders..ToString()));
            /*foreach (var preorder in preOrders)
            {
                links[0] = Directory.EnumerateFiles(Server.MapPath("~/Content/Screens/" + id.ToString()));
            }*/

            var vm = new HomeViewModel()
            {
                Genres = genres,
                PreOrders = preOrders,
                Randoms = randoms
                //Links = links
            };

            return View(vm);
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}