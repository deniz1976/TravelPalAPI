using CleanArchitecture.Core.Entities.AppUserPersonalization;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class TravelRoute : BaseEntity
    {
        public string? routeName { get; set; } = "";
        public bool isLiked {  get; set; } = false;
        public string? userId { get; set; }
        public int? Days {  get; set; }
        public PRICE_LEVEL? _PRICE_LEVEL { get; set; }
        public string? TransportVehicle { get; set; }
        public  TravelOtel? Otel { get; set; }
        public  Breakfast? Breakfast { get; set; }
        public  Lunch? Lunch { get; set; }
        public  Dinner? Dinner { get; set; }
        public  FirstPlaceForRoute? FirstPlaceForRoute { get; set; } // first event before lunch
        public  SecondPlaceForRoute? SecondPlaceForRoute { get; set; } // second event after lunch 
        public  ThirdPlaceForRoute? ThirdPlaceForRoute { get; set; } // third event after lunch
        public  EventAfterDinner? EventAfterDinner { get; set; } // fourth event after dinner

      


        
        
    }
}
