using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateRentals.ViewModels;
using System.Web.Mvc;

namespace RealEstateRentals.BusinessLogic
{
    public class ListingDetailsBL
    {
        public ListingInformationVM GetListingInformation(int ListingID)
        {
            return new ListingInformationVM(); 
        }

        public bool UpdateListing(FormCollection myCollection)
        {
            return true;
        }

        public bool AddListing(FormCollection myCollection)
        {
            return true;
        }

        public bool DeleteListing(int ListingID)
        {
            return true;
        }
    }
}