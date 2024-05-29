using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class Location : BaseEntity
    {
        public double? latitude {  get; set; }

        public double? longitude { get; set; }

    }
}
