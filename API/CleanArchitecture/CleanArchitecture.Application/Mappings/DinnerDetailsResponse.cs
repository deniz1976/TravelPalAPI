using CleanArchitecture.Core.Entities.TravelEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Mappings
{
    public class DinnerDetailsResponse
    {
        public string? nationalPhoneNumber { get; set; }
        public string? formattedAddress { get; set; }
        public string? googleMapsUri { get; set; }
        public string? websiteUri { get; set; }

        [JsonProperty("location")]
        public Location? location { get; set; }
        public double? rating { get; set; }

        [JsonProperty("regularOpeningHours")]
        public RegularOpeningHours? regularOpeningHours { get; set; }

        [JsonProperty("displayName")]
        public DisplayName? displayName { get; set; }

        public bool? reservable { get; set; }
        public bool? servesBrunch { get; set; }
        public bool? servesVegetarianFood { get; set; }
        public string? shortFormattedAddress { get; set; }
        public bool? outdoorSeating { get; set; }
        public bool? liveMusic { get; set; }
        public bool? menuForChildren { get; set; }
        public bool? restroom { get; set; }
        public bool? goodForGroups { get; set; }

        [JsonProperty("paymentOptions")]
        public PaymentOptions? paymentOptions { get; set; }
        public string? primaryType { get; set; }

        [JsonProperty("photos")]
        public List<Photos>? photos { get; set; }

        public bool? servesBeer { get; set; }
        public bool? servesWine { get; set; }
    }
}
