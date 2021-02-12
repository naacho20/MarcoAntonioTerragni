using System.Web;
using System.Web.Optimization;

namespace MarcoAntonioTerragniWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/breakpoint.js",
                      "~/Scripts/imagesloaded.js",
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/jquery.ajaxchimp.min.js",
                      "~/Scripts/jquery.countdown.js",
                      "~/Scripts/jquery.countTo.js",
                      "~/Scripts/jquery.eislideshow.js",
                      "~/Scripts/jquery.flexslider-min.js",
                      "~/Scripts/jquery.isotope.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/jquery.nav.js",
                      "~/Scripts/jquery.sticky.min.js",
                      "~/Scripts/menuzord.js",
                      "~/Scripts/modernizr.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/scripts.js",
                      "~/Scripts/smooth.js",
                      "~/Scripts/touchspin.js",
                      "~/Scripts/typist.js",
                      "~/Scripts/visible.js",
                      "~/Scripts/wow.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/default-theme.css",
                      "~/Content/css/elastic.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/linea-icon.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/shortcodes.css",
                      "~/Content/css/style.css"));
        }
    }
}
