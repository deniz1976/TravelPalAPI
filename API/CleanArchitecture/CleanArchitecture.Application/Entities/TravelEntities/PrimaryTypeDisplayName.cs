using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class PrimaryTypeDisplayName : BaseEntity
    {
        public string? text {  get; set; }

        public string? languageCode { get; set; }
    }
}
