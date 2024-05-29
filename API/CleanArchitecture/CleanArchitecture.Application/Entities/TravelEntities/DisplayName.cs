using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class DisplayName : BaseEntity
    {
        public string? text {  get; set; }

        public string? langugageCode { get; set; }
    }
}
