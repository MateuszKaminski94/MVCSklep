using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glimpse.Mvc.AlternateType;
using Owin;

namespace MateuszowSKYSklep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //app.UseHangfire(config =>
            //{
            //    config.UseAuthorizationFilters(new AuthorizationFilter
            //    {
            //        Roles = "Admin"
            //    });

            //    config.UseSqlServerStorage("StoreContext");
            //    config.UseServer();
            //});
        }
    }
}