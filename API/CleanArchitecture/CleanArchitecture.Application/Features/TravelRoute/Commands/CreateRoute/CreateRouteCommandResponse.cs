using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute
{
    public class CreateRouteCommandResponse
    {
        public List<CleanArchitecture.Core.Entities.TravelEntities.TravelRoute>? TravelRoutes { get; set; }
    }
}
