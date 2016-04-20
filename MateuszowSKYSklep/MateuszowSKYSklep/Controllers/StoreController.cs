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
            var game = db.Games.Find(id);

            var randoms = db.Games.Where(a => !a.IsHidden && a.GameId!=game.GameId).OrderBy(a => Guid.NewGuid()).Take(4).ToList();

            var links = Directory.EnumerateFiles(Server.MapPath("~/Content/Screens/"+id.ToString()));

            var vm = new DetailsViewModel()
            {
                Randoms = randoms,
                Games = game,
                Links = links
            };

            return View(vm);
        }

        public ActionResult List(string genrename)
        {
            var genre = db.Genres.Include("Games").Single(g => g.Name.ToUpper() == genrename.ToUpper());
            var games = genre.Games.ToList();

            ViewBag.Title = "Gry "+genre.Name;

            return View(games);
        }
    }
}