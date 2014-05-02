using System.Web;
using System.Web.Optimization;

namespace RealEstateRentals
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
          
            bundles.Add(new ScriptBundle("~/bundles/Mobilejs").Include(
  "~/Scripts/jquery.mobile-1.*",
  "~/Scripts/jquery-1.*"));

            bundles.Add(new StyleBundle("~/Content/Mobilecss").Include(
                "~/Content/jquery.mobile.structure-1.4.2.min.css",
                "~/Content/jquery.mobile-1.4.2.css"));        
           
        }
    }
}