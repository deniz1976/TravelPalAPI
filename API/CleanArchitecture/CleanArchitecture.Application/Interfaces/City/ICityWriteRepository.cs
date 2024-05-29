using CleanArchitecture.Core.Entities.City;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces.City
{
    public interface ICityWriteRepository
    {
        Task<bool> AddAsync(AllWorldCities city);

        Task<bool> AddRangeAsync(List<AllWorldCities> cities);

        bool Remove(AllWorldCities city);

        Task<bool> RemoveAsync(int id);

        bool RemoveRange(List<AllWorldCities> cities);

        bool Update(AllWorldCities city);

        Task<int> SaveAsync();
    }
}
