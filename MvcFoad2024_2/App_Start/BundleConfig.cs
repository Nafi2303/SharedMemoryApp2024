using System.Web;
using System.Web.Optimization;

namespace MvcFoad2024_2
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

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            
            bundles.Add(new Bundle("~/bundles/employee").Include(
                      "~/Scripts/employee.js"));

            bundles.Add(new Bundle("~/bundles/foadjs").Include(
                      "~/assets/vendor/apexcharts/apexcharts.js",
                      "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/assets/vendor/chart.js/chart.umd.js",
                      "~/assets/vendor/echarts/echarts.min.js",
                      "~/assets/vendor/quill/quill.js",
                      "~/assets/vendor/simple-datatables/simple-datatables.js",
                      "~/assets/vendor/tinymce/tinymce.min.js",
                      "~/assets/vendor/php-email-form/validate.js",
                      "~/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/foadCSS").Include(
                     "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                     "~/assets/vendor/bootstrap-icons/bootstrap-icons.css",
                     "~/assets/vendor/boxicons/css/boxicons.min.css",
                     "~/assets/vendor/quill/quill.snow.css",
                     "~/assets/vendor/quill/quill.bubble.css",
                     "~/assets/vendor/remixicon/remixicon.css",
                     "~/assets/vendor/simple-datatables/style.css",
                     "~/assets/css/style.css",
                     "~/Content/PagedList.css"));
        }
    }
}
