using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateRentals.ViewModels
{
    public class ListingSearchVM
    {
        public string City { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int Price { get; set; }

        List<ListingSearchListingsVM> lListings {get; set;} 
    }

    public class ListingSearchListingsVM
    {
        public int ListingID { get; set; }
        public string Address { get; set; }
    }
}