using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MateuszowSKYSklep.App_Start;
using MateuszowSKYSklep.DAL;
using MateuszowSKYSklep.Infrastructure;
using MateuszowSKYSklep.Models;
using MateuszowSKYSklep.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace MateuszowSKYSklep.Controllers
{
    public class CartController : Controller
    {
        private ShoppingCartManager shoppingCartManager;

        private ISessionManager sessionManager { get; set; }

        private ApplicationUserManager _userManager;

        private StoreContext db = new StoreContext();

        public CartController()
        {
            this.sessionManager = new SessionManager();
            this.shoppingCartManager = new ShoppingCartManager(this.sessionManager, this.db);
        }

        // GET: Cart
        public ActionResult Index()
        {
            var cartItems = shoppingCartManager.GetCart();
            var cartTotalPrice = shoppingCartManager.GetCartTotalPrice();

            var vm = new CartViewModel()
            {
                CartItems = cartItems,
                TotalPrice = cartTotalPrice
            };

            return View(vm);
        }

        public ActionResult AddToCart(int id)
        {
            shoppingCartManager.AddToCart(id);
            return RedirectToAction("Index");
        }

        public int GetCartItemsCount()
        {
            return shoppingCartManager.GetCartItemsCount();
        }

        public ActionResult RemoveFromCart(int gameid)
        {
            ShoppingCartManager shoppingCartManager = new ShoppingCartManager(this.sessionManager, this.db);

            int itemCount = shoppingCartManager.RemoveFromCart(gameid);
            int cartItemsCount = shoppingCartManager.GetCartItemsCount();
            decimal cartTotal = shoppingCartManager.GetCartTotalPrice();

            var result = new CartRemoveViewModel
            {
                RemoveItemId = gameid,
                RemovedItemCount = itemCount,
                CartTotal = cartTotal,
                CartItemsCount = cartItemsCount
            };

            return Json(result);
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public async Task<ActionResult> Checkout()
        {
            if (Request.IsAuthenticated)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

                var order = new Order
                {
                    FirstName = user.UserData.FirstName,
                    LastName = user.UserData.LastName,
                    Address = user.UserData.Address,
                    CodeAndCity = user.UserData.CodeAndCity,
                    Email = user.UserData.Email,
                    PhoneNumber = user.UserData.PhoneNumber
                };

                return View(order);
            }
            else
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Checkout", "Cart") });
        }

        [HttpPost]
        public async Task<ActionResult> Checkout(Order orderdetails)
        {
            if (ModelState.IsValid)
            {
                //logger.Info("Checking out");

                // Get user
                var userId = User.Identity.GetUserId();

                // Save Order
                //ShoppingCartManager shoppingCartManager = new ShoppingCartManager(this.sessionManager, this.db);
                var newOrder = shoppingCartManager.CreateOrder(orderdetails, userId);

                // Update profile information
                var user = await UserManager.FindByIdAsync(userId);
                TryUpdateModel(user.UserData);
                await UserManager.UpdateAsync(user);

                // Empty cart
                shoppingCartManager.EmptyCart();

                // Send mail confirmation
                // Refetch - need also albums details
                //var order = db.Orders.Include("OrderItems").SingleOrDefault(o => o.OrderId == newOrder.OrderId);            
                //var order = db.Orders.Include("OrderItems").Include("OrderItems.Album").SingleOrDefault(o => o.OrderId == newOrder.OrderId);


                //IMailService mailService = new HangFirePostalMailService();
                //mailService.SendOrderConfirmationEmail(order);

                //this.mailService.SendOrderConfirmationEmail(order);

                //string url = Url.Action("SendConfirmationEmail", "Cart", new { orderid = newOrder.OrderId, lastname = newOrder.LastName }, Request.Url.Scheme);

                //// Hangfire - nice one (if ASP.NET app will be still running)
                //BackgroundJob.Enqueue(() => Helpers.CallUrl(url));



                //// Strongly typed - without background
                ////OrderConfirmationEmail email = new OrderConfirmationEmail();
                ////email.To = order.Email;
                ////email.Cost = order.TotalPrice;
                ////email.OrderNumber = order.OrderId;
                ////email.FullAddress = string.Format("{0} {1}, {2}, {3}", order.FirstName, order.LastName, order.Address, order.CodeAndCity);
                ////email.OrderItems = order.OrderItems;
                ////email.CoverPath = AppConfig.PhotosFolderRelative;

                //// Loosely typed - without background
                ////dynamic email = new Postal.Email("OrderConfirmation");
                ////email.To = order.Email;
                ////email.Cost = order.TotalPrice;
                ////email.OrderNumber = order.OrderId;
                ////email.FullAddress = string.Format("{0} {1}, {2}, {3}", order.FirstName, order.LastName, order.Address, order.CodeAndCity);
                ////email.OrderItems = order.OrderItems;
                ////email.CoverPath = AppConfig.PhotosFolderRelative;
                ////email.Send();

                //// Easiest background
                ////HostingEnvironment.QueueBackgroundWorkItem(ct => email.Send());

                return RedirectToAction("OrderConfirmation");
            }
            else
                return View(orderdetails);
        }

        public ActionResult OrderConfirmation()
        {
            return View();
        }
    }
}