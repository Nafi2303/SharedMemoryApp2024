using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace WebFormFoad2024
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // L'ordre est très important pour que ces fichiers fonctionnent, car ils ont des dépendances explicites
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));


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

            // La version Development de Modernizr vous permet de développer et d’apprendre. Ensuite, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));
        }
    }
}