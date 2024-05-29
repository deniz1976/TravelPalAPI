using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Interfaces.Repositories.common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities.TravelEntities;

namespace CleanArchitecture.Core.Interfaces.City
{
    public interface ICityReadRepository
    {
        IQueryable GetAll(bool tracking = true);
        IQueryable GetWhere(Expression<Func<AllWorldCities,bool>> method, bool tracking = true);

         Task<AllWorldCities> GetSingleAsync(Expression<Func<AllWorldCities,bool>> method, bool tracking = true);

         Task<AllWorldCities> GetByIdAsync(int id, bool tracking = true);
        
    }
}
