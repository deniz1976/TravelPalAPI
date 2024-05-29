using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Entities.TravelEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.UpdateRoute
{
    public class UpdateRouteCommandRequest : IRequest<UpdateRouteCommandResponse>
    {
        public List<Entities.TravelEntities.TravelRoute> routes {  get; set; }

        public BaseTravelRestaurantEntity? routeRestaurant { get; set; }

        public BaseTravelPlaceEntity? routePlaceEntity { get; set; }
    }
}
