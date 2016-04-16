using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MateuszowSKYSklep.DAL
{
    public class StoreContext : IdentityDbContext<ApplicationUser>
    {
        public StoreContext() : base("StoreContext")
        {
            
        }

        static StoreContext()
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }

        public static StoreContext Create()
        {
            return new StoreContext();
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}