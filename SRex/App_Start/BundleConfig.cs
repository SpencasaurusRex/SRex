using System.Web;
using System.Web.Optimization;

namespace SRex
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery-3.2.1.slim.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/js/lib/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                    "~/js/lib/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/js/lib/bootstrap.min.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/css/bootstrap.min.css",
                      //"~/css/bootstrap-grid.min.css",
                      //"~/css/bootstrap-reboot.min.css",
                      "~/css/bootswatch-lux.css",
                      "~/css/site.css"));
        }
    }
}
