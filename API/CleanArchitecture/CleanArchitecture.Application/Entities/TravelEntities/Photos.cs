using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class Photos : BaseEntity
    {
        public string? name { get; set; }
        public int? widthPx { get; set; }
        public int? heightPx { get; set; }
    }
}
