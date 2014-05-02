using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstateRentals.ViewModels;
using RealEstateRentals.BusinessLogic;  

namespace RealEstateRentals.Controllers
{
    public class HomeController : Controller
    {

        //Search Listings
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        public ActionResult SearchResults(FormCollection myCollection)
        {
            HomeBL oHBL = new HomeBL();
            ListingSearchVM oLSVM = oHBL.SearchListings(myCollection);
            return View(oLSVM);
        }
       
    }
}
