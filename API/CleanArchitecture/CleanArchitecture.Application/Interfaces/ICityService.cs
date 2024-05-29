using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Features.City.Queries.GetCity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Core.Interfaces
{
    public interface ICityService
    {
        public IQueryable<AllWorldCities> FullTextSearch(string model);
    }
}
