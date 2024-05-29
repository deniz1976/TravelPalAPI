using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Interfaces.City;
using CleanArchitecture.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.City
{
    public class CityWriteRepository : ICityWriteRepository
    {
        private readonly ApplicationDbContext _context;

        public CityWriteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<AllWorldCities> cities => _context.AllWorldCities;

        public async Task<bool> AddAsync(AllWorldCities city)
        {
            EntityEntry entityEntry = await cities.AddAsync(city);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<AllWorldCities> cities)
        {
            cities.AddRange(cities);
            return true;
        }

        public bool Remove(AllWorldCities city)
        {
            EntityEntry entityEntry = cities.Remove(city);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            AllWorldCities city = await cities.FirstOrDefaultAsync(data => data.id == id);
            return Remove(city);
        }

        public bool RemoveRange(List<AllWorldCities> cities)
        {
            this.cities.RemoveRange(cities);
            return true;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(AllWorldCities city)
        {
            EntityEntry entityEntry = cities.Update(city);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
