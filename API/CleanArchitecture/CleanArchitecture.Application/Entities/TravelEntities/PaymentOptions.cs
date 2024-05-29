using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class PaymentOptions : BaseEntity
    {
        public string? acceptsCreditCards { get; set; }

        public string? acceptsDebitCards { get; set; }

        public string? acceptsCashOnly { get; set; }
    }
}
