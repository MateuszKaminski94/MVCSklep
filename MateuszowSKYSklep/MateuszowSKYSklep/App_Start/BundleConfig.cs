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
                        "~/Scripts/basicElements.js",
                        "~/Scripts/indexElements.js",
                        "~/Scripts/detailsElements.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/mainSite.css",
                      "~/Content/indexSite.css",
                      "~/Content/detailsSite.css"));
        }
    }
}