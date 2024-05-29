using CleanArchitecture.Core.Entities.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.City.Queries.GetCity
{
    public class GetCityQueryResponse
    { 
        public List<AllWorldCities>? cities = new List<AllWorldCities>();
    }
}
