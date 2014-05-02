using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateRentals.ViewModels
{
    public class ListingInformationVM
    {
        public int ListingID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfRooms { get; set; }
        public int Price { get; set; }
    }
}