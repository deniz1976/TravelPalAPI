using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Interfaces.City;
using CleanArchitecture.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.City
{
    public class CityReadRepository : ICityReadRepository
    {
        private readonly ApplicationDbContext _context;

        public CityReadRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<AllWorldCities> cities => _context.AllWorldCities;

        public IQueryable GetAll(bool tracking = true)
        {
            var query = cities.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;

        }

        public IQueryable GetWhere(Expression<Func<AllWorldCities, bool>> method, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public async Task<AllWorldCities> GetByIdAsync(int id, bool tracking)
        {
            var query = cities.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.id == id);
        }

        public async Task<AllWorldCities> GetSingleAsync(Expression<Func<AllWorldCities, bool>> method, bool tracking)
        {
            var query = cities.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync();
        }

    }
}
