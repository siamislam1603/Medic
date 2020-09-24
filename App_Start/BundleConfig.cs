using System.Web;
using System.Web.Optimization;

namespace Medic
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                "~/Scripts/js/vendor/modernizr-3.5.0.min.js",
                "~/Scripts/js/vendor/jquery-1.12.4.min.js",
                "~/Scripts/js/popper.min.js",
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/owl.carousel.min.js",
                "~/Scripts/js/isotope.pkgd.min.js",
                "~/Scripts/js/ajax-form.js",
                "~/Scripts/js/waypoints.min.js",
                "~/Scripts/js/jquery.counterup.min.js",
                "~/Scripts/js/imagesloaded.pkgd.min.js",
                "~/Scripts/js/scrollIt.js",
                "~/Scripts/js/jquery.scrollUp.min.js",
                "~/Scripts/js/wow.min.js",
                "~/Scripts/js/nice-select.min.js",
                "~/Scripts/js/jquery.slicknav.min.js",
                "~/Scripts/js/jquery.magnific-popup.min.js",
                "~/Scripts/js/plugins.js",
                "~/Scripts/js/gijgo.min.js",
                "~/Scripts/js/contact.js",
                "~/Scripts/js/jquery.ajaxchimp.min.js",
                "~/Scripts/js/jquery.form.js",
                "~/Scripts/js/jquery.validate.min.js",
                "~/Scripts/js/mail-script.js",
                "~/Scripts/js/main.js",
                "~/jqueryui/jquery-ui.js"

                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/owl.carousel.min.css",
                      "~/css/magnific-popup.css",
                      "~/css/font-awesome.min.css",
                      "~/css/themify-icons.css",
                      "~/css/nice-select.css",
                      "~/css/flaticon.css",
                      "~/css/gijgo.css",
                      "~/css/animate.css",
                      "~/css/slicknav.css",
                      "~/css/style.css",
                      "~/css/mystylesheet.css",
                      "~/jqueryui/jquery-ui.css",
                      "~/jqueryui/jquery-ui.structure.css",
                      "~/jqueryui/jquery-ui.theme.css"

                      ));
        }
    }
}
