using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstateRentals.BusinessLogic;
using RealEstateRentals.ViewModels;  

namespace RealEstateRentals.Controllers
{
    public class ListingDetailController : Controller
    {
        //
        // GET: /ListingDetail/

        public ActionResult Index(int ListingID)
        {
            ListingDetailsBL oLDBL = new ListingDetailsBL();
            ListingInformationVM oLIVM = oLDBL.GetListingInformation(ListingID);
            return View(oLIVM);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(FormCollection myCollection)
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

    }
}
