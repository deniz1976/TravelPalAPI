using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetRouteById
{
    public class GetRouteByIdQueryResponse
    {
        public CleanArchitecture.Core.Entities.TravelEntities.TravelRoute travelRoute {  get; set; }
    }
}
