using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.DAL;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.Infrastructure
{
    public class ShoppingCartManager
    {
        private StoreContext db;

        private ISessionManager session;

        public const string CartSessionKey = "CartData";

        public ShoppingCartManager(ISessionManager session, StoreContext db)
        {
            this.session = session;
            this.db = db;
        }

        public void AddToCart(int gameid)
        {
            var cart = this.GetCart();

            var cartItem = cart.Find(c => c.Game.GameId == gameid);

            if (cartItem != null)
                cartItem.Quantity++;
            else
            {
                var gameToAdd = db.Games.SingleOrDefault(a => a.GameId == gameid);
                if (gameToAdd != null)
                {
                    var newCartItem = new CartItem()
                    {
                        Game = gameToAdd,
                        Quantity = 1,
                        TotalPrice = gameToAdd.Price
                    };

                    cart.Add(newCartItem);
                }
            }

            session.Set(CartSessionKey, cart);
        }

        public List<CartItem> GetCart()
        {
            List<CartItem> cart;

            if (session.Get<List<CartItem>>(CartSessionKey) == null)
            {
                cart = new List<CartItem>();
            }
            else
            {
                cart = session.Get<List<CartItem>>(CartSessionKey) as List<CartItem>;
            }

            return cart;
        }

        public int RemoveFromCart(int gameid)
        {
            var cart = this.GetCart();

            var cartItem = cart.Find(c => c.Game.GameId == gameid);

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    return cartItem.Quantity;
                }
                else
                    cart.Remove(cartItem);
            }

            return 0;
        }

        public decimal GetCartTotalPrice()
        {
            var cart = this.GetCart();
            return cart.Sum(c => (c.Quantity * c.Game.Price));
        }

        public int GetCartItemsCount()
        {
            var cart = this.GetCart();
            int count = cart.Sum(c => c.Quantity);

            return count;
        }

        public Order CreateOrder(Order newOrder, string userId)
        {
            var cart = this.GetCart();

            newOrder.DateCreated = DateTime.Now;
            //newOrder.UserId = userId;

            this.db.Orders.Add(newOrder);

            if(newOrder.OrderItems == null)
                newOrder.OrderItems = new List<OrderItem>();

            decimal cartTotal = 0;

            foreach (var cartItem in cart)
            {
                var newOrderItem = new OrderItem()
                {
                    GameId = cartItem.Game.GameId,
                    Quantity = cartItem.Quantity,
                    UnitPrice = cartItem.Game.Price
                };

                cartTotal += (cartItem.Quantity*cartItem.Game.Price);

                newOrder.OrderItems.Add(newOrderItem);
            }

            newOrder.TotalPrice = cartTotal;

            this.db.SaveChanges();

            return newOrder;
        }

        public void EmptyCart()
        {
            session.Set<List<CartItem>>(CartSessionKey, null);
        }
    }
}