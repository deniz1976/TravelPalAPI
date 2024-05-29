using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IPlacesService
    {
        public Task<List<Breakfast>> BreakfastFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days);

        Task<Breakfast> GetBreakfastDetails(string googleId, PRICE_LEVEL pricelevel);

        public  Task<List<Lunch>> LunchFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days);

        Task<Lunch> GetLunchDetails(string googleId, PRICE_LEVEL pricelevel);

        public Task<List<Dinner>> DinnerFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days);

        Task<Dinner> GetDinnerDetails(string googleId, PRICE_LEVEL pricelevel);

        public Task<TravelOtel> OtelFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days);

        Task<TravelOtel> GetOtelDetails(string googleId, PRICE_LEVEL pricelevel, string otelStar);

        public Task<List<FirstPlaceForRoute>> PlaceFinder(string city, int days, List<string> queries);

        Task<FirstPlaceForRoute> GetFirstPlaceDetails(string googleId);

        public Task<List<EventAfterDinner>> NightEventFinder(PRICE_LEVEL _PRICE_LEVEL, string city, int days);

        Task<EventAfterDinner> GetNightEventDetails(string googleId);

        public Task<GetRouteComponentQueryResponse> GetRouteComponentImage(GetRouteComponentQueryRequest getRouteComponentQueryRequest);
    }
}
