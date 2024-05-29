using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class BaseTravelPlaceEntity : BaseEntity
    {
        public string? nationalPhoneNumber { get; set; }

        public string? formattedAddress { get; set; }

        public  Location? Location { get; set; }

        public double? rating { get; set; }

        public string? googleMapsUri { get; set; }

        public string? websiteUri { get; set; }

        public  RegularOpeningHours? regularOpeningHours { get; set; }

        public  DisplayName? displayName { get; set; }

        public bool? goodForChildren { get; set; }

        public bool? restroom { get; set; }

        public PRICE_LEVEL? _PRICE_LEVEL { get; set; }

        public  List<Photos>? photos { get; set; }

        public string? primaryType { get; set; }
        public string? googleId { get; set; }

        public  PaymentOptions? paymentOptions { get; set; }


    }
}
