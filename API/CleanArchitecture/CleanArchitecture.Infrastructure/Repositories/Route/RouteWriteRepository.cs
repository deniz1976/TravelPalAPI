using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Interfaces.Route;
using CleanArchitecture.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.Route
{
    public class RouteWriteRepository : IRouteWriteRepository
    {
        private readonly ApplicationDbContext _context;

        public RouteWriteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TravelRoute> cities => _context.TravelRoutes;

        public async Task<bool> AddAsync(TravelRoute route)
        {
            EntityEntry entityEntry = await cities.AddAsync(route);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<TravelRoute> routes)
        {
            cities.AddRange(routes);
            return true;
        }

        public bool Remove(TravelRoute route)
        {
            EntityEntry entityEntry = cities.Remove(route);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            TravelRoute route = await cities.FirstOrDefaultAsync(data => data.Id == new Guid(id));
            return Remove(route);
        }

        public bool RemoveRange(List<TravelRoute> routes)
        {
            this.cities.RemoveRange(routes);
            return true;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(TravelRoute routes)
        {
            EntityEntry entityEntry = cities.Update(routes);
            return entityEntry.State == EntityState.Modified;
        }

    }
}
