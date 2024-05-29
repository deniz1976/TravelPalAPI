/**
 *  1 STAR = PRICE_LEVEL_INEXPENSIVE
 *  2 STAR = PRICE_LEVEL_INEXPENSIVE
 *  3 STAR = PRICE_LEVEL_MODERATE
 *  4 STAR = PRICE_LEVEL_EXPENSIVE
 *  5 STAR = PRICE_LEVEL_EXPENSIVE
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class TravelOtel : BaseTravelPlaceEntity
    {
        public string? star {  get; set; } 

        public string? internationalPhoneNumber { get; set; }


    }
}
