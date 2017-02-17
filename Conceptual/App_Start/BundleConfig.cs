using System.Web;
using System.Web.Optimization;

namespace Conceptual
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/stylized.min.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/bracket/bracketStyle").Include(
                "~/Content/bracket/css/bootstrap.min.css",
                "~/Content/bracket/css/bootstrap-override.css",
                "~/Content/bracket/css/weather-icons.min.css",
                "~/Content/bracket/css/jquery-ui-1.10.3.css",
                "~/Content/bracket/css/toggles.css",
                "~/Content/bracket/css/select2.css",
                "~/Content/bracket/css/lato.css",
                "~/Content/bracket/css/roboto.css",
                "~/Content/bracket/css/style.default.css",

                "~/Content/bracket/css/bootstrap-timepicker.min.css",
                "~/Content/bracket/css/jquery.tagsinput.css",
                "~/Content/bracket/css/colorpicker.css",
                "~/Content/bracket/css/dropzone.css",

                "~/Content/bracket/css/bootstrap-wysihtml5.css",

                "~/Content/bracket/css/customizedBracketStyle.min.css"
                ));


            bundles.Add(new ScriptBundle("~/bundles/bracket/bracketScript").Include(
                      "~/Content/bracket/js/jquery-1.11.1.min.js",
                      "~/Content/bracket/js/jquery-migrate-1.2.1.min.js",
                      "~/Content/bracket/js/jquery-ui-1.10.3.min.js",
                      "~/Content/bracket/js/bootstrap.min.js",
                      "~/Content/bracket/js/modernizr.min.js",
                      "~/Content/bracket/js/jquery.sparkline.min.js",
                      "~/Content/bracket/js/toggles.min.js",
                      "~/Content/bracket/js/retina.min.js",
                      "~/Content/bracket/js/jquery.cookies.js",

                      "~/Content/bracket/js/jquery.autogrow-textarea.js",
                      "~/Content/bracket/js/bootstrap-timepicker.min.js",
                      "~/Content/bracket/js/jquery.maskedinput.min.js",
                      "~/Content/bracket/js/jquery.tagsinput.js",
                      "~/Content/bracket/js/jquery.mousewheel.js",
                      "~/Content/bracket/js/select2.min.js",
                      "~/Content/bracket/js/dropzone.min.js",
                      "~/Content/bracket/js/colorpicker.js",

                      "~/Content/bracket/js/wysihtml5-0.3.0.min.js",
                      "~/Content/bracket/js/bootstrap-wysihtml5.js",

                      "~/Content/bracket/js/jquery.datatables.min.js",
                      "~/Content/bracket/js/select2.min.js",

                      "~/Content/bracket/js/custom.js"
                      ));
        }
    }
}
