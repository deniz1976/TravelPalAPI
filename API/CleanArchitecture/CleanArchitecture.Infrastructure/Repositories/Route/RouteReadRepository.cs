using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Interfaces.Route;
using CleanArchitecture.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.Route
{
    public class RouteReadRepository : IRouteReadRepository
    {
        private readonly ApplicationDbContext _context;

        public RouteReadRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TravelRoute> routes => _context.TravelRoutes;

        public IQueryable GetAll(bool tracking = true)
        {
            var query = routes.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;

        }

       
      
        public IQueryable GetWhere(Expression<Func<TravelRoute, bool>> method, bool tracking = true)
        {
            var query = routes.Where(method);
            if (!tracking)
                query = query.AsNoTracking();



            query = query
                ?.Include(tr => tr.Otel)?
                    .ThenInclude(o => o.Location)?
                .Include(tr => tr.Otel)?
                    .ThenInclude(o => o.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.Otel)?
                    .ThenInclude(o => o.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.Otel)?
                    .ThenInclude(o => o.displayName)?
                .Include(tr => tr.Otel)?
                    .ThenInclude(o => o.paymentOptions)?
                .Include(tr => tr.Otel)?
                    .ThenInclude(o => o.photos)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.Location)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.displayName)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.paymentOptions)?
                .Include(tr => tr.Breakfast)?
                    .ThenInclude(b => b.photos)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.Location)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.displayName)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.paymentOptions)?
                .Include(tr => tr.Lunch)?
                    .ThenInclude(l => l.photos)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.Location)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.displayName)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.paymentOptions)?
                .Include(tr => tr.Dinner)?
                    .ThenInclude(d => d.photos)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.Location)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.displayName)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.paymentOptions)?
                .Include(tr => tr.FirstPlaceForRoute)?
                    .ThenInclude(fp => fp.photos)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.Location)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.displayName)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.paymentOptions)?
                .Include(tr => tr.SecondPlaceForRoute)?
                    .ThenInclude(sp => sp.photos)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.Location)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.regularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.displayName)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.paymentOptions)?
                .Include(tr => tr.ThirdPlaceForRoute)?
                    .ThenInclude(tp => tp.photos)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.Location)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.open)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.RegularOpeningHours)?
                        .ThenInclude(ro => ro.periods)?
                            .ThenInclude(p => p.close)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.displayName)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.paymentOptions)?
                .Include(tr => tr.EventAfterDinner)?
                    .ThenInclude(ead => ead.photos).AsSplitQuery();
            return query;
        }


        public async Task<TravelRoute> GetByIdAsync(string id, bool tracking)
        {
            var query = routes.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();

            query = query
               ?.Include(tr => tr.Otel)?
                   .ThenInclude(o => o.Location)?
               .Include(tr => tr.Otel)?
                   .ThenInclude(o => o.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.Otel)?
                   .ThenInclude(o => o.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.Otel)?
                   .ThenInclude(o => o.displayName)?
               .Include(tr => tr.Otel)?
                   .ThenInclude(o => o.paymentOptions)?
               .Include(tr => tr.Otel)?
                   .ThenInclude(o => o.photos)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.Location)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.displayName)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.paymentOptions)?
               .Include(tr => tr.Breakfast)?
                   .ThenInclude(b => b.photos)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.Location)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.displayName)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.paymentOptions)?
               .Include(tr => tr.Lunch)?
                   .ThenInclude(l => l.photos)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.Location)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.displayName)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.paymentOptions)?
               .Include(tr => tr.Dinner)?
                   .ThenInclude(d => d.photos)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.Location)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.displayName)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.paymentOptions)?
               .Include(tr => tr.FirstPlaceForRoute)?
                   .ThenInclude(fp => fp.photos)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.Location)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.displayName)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.paymentOptions)?
               .Include(tr => tr.SecondPlaceForRoute)?
                   .ThenInclude(sp => sp.photos)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.Location)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.regularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.displayName)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.paymentOptions)?
               .Include(tr => tr.ThirdPlaceForRoute)?
                   .ThenInclude(tp => tp.photos)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.Location)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.open)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.RegularOpeningHours)?
                       .ThenInclude(ro => ro.periods)?
                           .ThenInclude(p => p.close)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.displayName)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.paymentOptions)?
               .Include(tr => tr.EventAfterDinner)?
                   .ThenInclude(ead => ead.photos).AsSplitQuery();


            Guid g = new Guid(id);
            return await query.FirstOrDefaultAsync(data => data.Id == g);
        }

        public async Task<TravelRoute> GetSingleAsync(Expression<Func<TravelRoute, bool>> method, bool tracking)
        {
            var query = routes.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync();
        }

       
    }
}
