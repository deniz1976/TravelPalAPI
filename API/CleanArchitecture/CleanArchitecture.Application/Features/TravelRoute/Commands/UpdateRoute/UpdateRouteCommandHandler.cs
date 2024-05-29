using CleanArchitecture.Core.Entities.TravelEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.UpdateRoute
{
    public class UpdateRouteCommandHandler : IRequestHandler<UpdateRouteCommandRequest, UpdateRouteCommandResponse>
    {
        public async Task<UpdateRouteCommandResponse> Handle(UpdateRouteCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.routeRestaurant == null) 
            {
                if (request.routePlaceEntity == null) 
                {
                    throw new Exception("Restaurant and place both null");
                }

                //swap place

            }

            if (request.routePlaceEntity == null)
            {
                throw new Exception();
            }

            //swap restaurant
            //return new route "component"
            return new UpdateRouteCommandResponse();
        }
    }
}
