using System.Web;
using System.Web.Optimization;

namespace PHARAM
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Desing


            

            bundles.Add(new ScriptBundle("~/Template/js").Include(
                        "~/Scripts/js/jquery-3.3.1.min.js",
                        "~/Scripts/styles/bootstrap4/popper.js",
                        "~/Scripts/styles/bootstrap4/bootstrap.min.js",
                        "~/Scripts/plugins/greensock/TweenMax.min.js",
                        "~/Scripts/plugins/greensock/TimelineMax.min.js",
                        "~/Scripts/plugins/scrollmagic/ScrollMagic.min.js",
                        "~/Scripts/plugins/greensock/animation.gsap.min.js",
                        "~/Scripts/plugins/greensock/ScrollToPlugin.min.js",
                        "~/Scripts/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                        "~/Scripts/plugins/easing/easing.js",
                        "~/Scripts/plugins/parallax-js-master/parallax.min.js"));

            bundles.Add(new StyleBundle("~/Template/css").Include(
                    "~/Content/css/bootstrap4/bootstrap.min.css",
                    "~/Scripts/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                    "~/Scripts/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                    "~/Scripts/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                    "~/Scripts/plugins/OwlCarousel2-2.2.1/animate.css"));

            #endregion
        }
    }
}
