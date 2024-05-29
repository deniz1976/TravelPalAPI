using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.TravelRoute.Commands.LikeAndRenameRoute;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.LikeRoute
{
    public class LikeRouteCommandHandler : IRequestHandler<LikeRouteCommandRequest, LikeRouteCommandResponse>
    {
        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;

        public LikeRouteCommandHandler(IRouteReadRepository routeReadRepository, IRouteWriteRepository routeWriteRepository) 
        {
            _routeReadRepository = routeReadRepository;
            _routeWriteRepository = routeWriteRepository;
        }
        public async Task<LikeRouteCommandResponse> Handle(LikeRouteCommandRequest request, CancellationToken cancellationToken)
        {
            Entities.TravelEntities.TravelRoute travelRoute = await _routeReadRepository.GetByIdAsync(request.routeId);
            if (travelRoute == null) throw new ApiException("route not found");
            if (request.userId != travelRoute.userId) throw new ApiException("you cant like the route that doesnt belong to you");

            travelRoute.isLiked = !travelRoute.isLiked;
            travelRoute.UpdatedDate = DateTime.UtcNow;

            _routeWriteRepository.Update(travelRoute);
            await _routeWriteRepository.SaveAsync();

            LikeRouteCommandResponse r = new LikeRouteCommandResponse();
            r.message = "Route liked succesfully.";

            return r;
        }
    }
}
