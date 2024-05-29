using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.TravelEntities
{
    public class Close : BaseEntity
    {
        public int? day { get; set; }
        public int? hour { get; set; }
        public int? minute { get; set; }
    }

    public class Open : BaseEntity
    {
        public int? day { get; set; }
        public int? hour { get; set; }
        public int? minute { get; set; }
    }

    public class Period : BaseEntity
    {
        public  Open? open { get; set; }
        public  Close? close { get; set; }
    }

    public class RegularOpeningHours : BaseEntity
    {
        public bool? openNow { get; set; }
        public  List<Period>? periods { get; set; }
        public  List<string>? weekdayDescriptions { get; set; }
    }

}
