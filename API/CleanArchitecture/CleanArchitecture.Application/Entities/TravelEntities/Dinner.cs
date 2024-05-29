using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class Dinner : BaseTravelRestaurantEntity
    {

        public bool? servesBeer { get; set; }

        public bool? servesWine { get; set; }

    }
}
