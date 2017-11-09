using System.Web;
using System.Web.Optimization;

namespace Assessment_Owen
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/node_modules/angular/angular.js",
                      "~/node_modules/@uirouter/angularjs/release/angular-ui-router.js",
                      "~/node_modules/angular-ui-bootstrap/dist/ui-bootstrap.js",
                      "~/node_modules/angularjs-toaster/toaster.js",
                      "~/app/app.js",
                      "~/app/services/employeeService.js",
                      "~/app/controllers/employeeController.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
