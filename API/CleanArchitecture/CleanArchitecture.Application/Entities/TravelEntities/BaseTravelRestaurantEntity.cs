using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class BaseTravelRestaurantEntity : BaseEntity
    {   
        public string? nationalPhoneNumber { get; set; }

        public string? formattedAddress { get; set; }

        public double? rating { get; set; }
        public string? googleMapsUri { get; set; }

        public string? websiteUri { get; set; }

        public  Location? Location { get; set; }

        public  RegularOpeningHours? RegularOpeningHours { get; set; }

        public PRICE_LEVEL? _PRICE_LEVEL { get; set; }

        public  DisplayName? displayName { get; set; }

        public bool? reservable { get; set; }

        public bool? servesBrunch { get; set; }

        public bool? servesVegetarianFood { get; set; }

        public string? shortFormattedAddress { get; set; }

        public bool? outdoorSeating { get; set; }

        public bool? liveMusic { get; set; }

        public bool? menuForChildren { get; set; }

        public bool? restroom { get; set; }

        public bool? goodForGroups { get; set; }

        public  PaymentOptions? paymentOptions { get; set; }

        public  List<Photos>? photos { get; set; }

        public string? primaryType { get; set; }

        public string? googleId { get; set; }
    }
}
