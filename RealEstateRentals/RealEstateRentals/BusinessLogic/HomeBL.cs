using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateRentals.ViewModels;
using System.Web.Mvc;

namespace RealEstateRentals.BusinessLogic
{
    public class HomeBL
    {
        public ListingSearchVM SearchListings(FormCollection myCollection)
        {
            ListingSearchVM oLSVM = new ListingSearchVM();
            oLSVM.lListings = new List<ListingSearchListingsVM>(); 
            return new ListingSearchVM();
        }
    }
}