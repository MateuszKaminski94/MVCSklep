using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MateuszowSKYSklep.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/basicElements.js",
                        "~/Scripts/indexElements.js",
                        "~/Scripts/detailsElements.js",
                        "~/Scripts/orderElements.js",
                        "~/Scripts/cartElements.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/themes/base/core.css",
                      "~/Content/themes/base/autocomplete.css",
                      "~/Content/themes/base/theme.css",
                      "~/Content/themes/base/menu.css",
                      "~/Content/mainSite.css",
                      "~/Content/indexSite.css",
                      "~/Content/cartSite.css",
                      "~/Content/detailsSite.css"));
        }
    }
}