using CleanArchitecture.Core.Entities.City;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities.TravelEntities;

namespace CleanArchitecture.Core.Interfaces.Route
{
    public interface IRouteWriteRepository
    {
        Task<bool> AddAsync(TravelRoute route);

        Task<bool> AddRangeAsync(List<TravelRoute> routes);

        bool Remove(TravelRoute route);

        Task<bool> RemoveAsync(string id);

        bool RemoveRange(List<TravelRoute> routes);

        bool Update(TravelRoute route);

        Task<int> SaveAsync();
    }
}
