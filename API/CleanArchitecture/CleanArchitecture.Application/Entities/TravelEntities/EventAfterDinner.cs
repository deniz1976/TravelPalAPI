using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class EventAfterDinner : BaseTravelRestaurantEntity
    {
        public bool? takeout {  get; set; }
        public bool? delivery { get; set; }
        public bool? curbsidePickup { get; set; }
        public bool? servesBeer {  get; set; }
        public bool? servesWine { get; set; }

        public bool? servesCocktails { get; set; }

        public bool? goodForChildren { get; set; }



    }
}
