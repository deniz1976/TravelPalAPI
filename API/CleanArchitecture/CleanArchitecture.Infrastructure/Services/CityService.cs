using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Features.City.Queries.GetCity;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Interfaces.City;
using CleanArchitecture.Infrastructure.Contexts;
using Korzh.EasyQuery.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class CityService : ICityService
    {
        private readonly ApplicationDbContext _context;
        private readonly ICityWriteRepository _cityWriteRepository;
        private readonly ICityReadRepository _cityReadRepository;

        public CityService(ApplicationDbContext context, ICityWriteRepository cityWriteRepository, ICityReadRepository cityReadRepository) 
        {
            _context = context;
            _cityWriteRepository = cityWriteRepository;
            _cityReadRepository = cityReadRepository;
        
        }

        public IQueryable<AllWorldCities> FullTextSearch(string text)
        {           
            return _context.AllWorldCities.FullTextSearchQuery(text);
        }

        
    }
}
