using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class Lunch : BaseTravelRestaurantEntity
    {
        public bool? servesBeer { get; set; }

        public bool? servesWine { get; set; }
    }
}
