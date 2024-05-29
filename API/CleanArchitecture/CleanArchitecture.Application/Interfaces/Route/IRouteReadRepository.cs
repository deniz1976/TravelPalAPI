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
    public interface IRouteReadRepository
    {
        IQueryable GetAll(bool tracking = true);
        IQueryable GetWhere(Expression<Func<TravelRoute, bool>> method, bool tracking = true);
        Task<TravelRoute> GetSingleAsync(Expression<Func<TravelRoute, bool>> method, bool tracking = true);
        Task<TravelRoute> GetByIdAsync(string id, bool tracking = true);
    }

}
