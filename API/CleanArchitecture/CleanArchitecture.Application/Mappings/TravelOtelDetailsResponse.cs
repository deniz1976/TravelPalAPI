using CleanArchitecture.Core.Entities.TravelEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Mappings
{
    public class TravelOtelDetailsResponse
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
        public bool? goodForChildren { get; set; }

        [JsonProperty("paymentOptions")]
        public PaymentOptions? paymentOptions { get; set; }
        public string? primaryType { get; set; }

        [JsonProperty("photos")]
        public List<Photos>? photos { get; set; }

        public string? internationalPhoneNumber { get; set; }


    }
}
