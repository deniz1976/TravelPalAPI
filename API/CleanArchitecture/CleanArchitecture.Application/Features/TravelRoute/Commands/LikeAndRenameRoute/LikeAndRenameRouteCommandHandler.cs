using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.LikeAndRenameRoute
{
    public class LikeAndRenameRouteCommandHandler : IRequestHandler<LikeAndRenameRouteCommandRequest, LikeAndRenameRouteCommandResponse>
    {
        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;

        public LikeAndRenameRouteCommandHandler(IRouteReadRepository routeReadRepository, IRouteWriteRepository routeWriteRepository) 
        {
            _routeReadRepository = routeReadRepository;
            _routeWriteRepository = routeWriteRepository;
        }
        public async Task<LikeAndRenameRouteCommandResponse> Handle(LikeAndRenameRouteCommandRequest request, CancellationToken cancellationToken)
        {
            Entities.TravelEntities.TravelRoute travelRoute = await _routeReadRepository.GetByIdAsync(request.routeId) ?? throw new ApiException("route not found");
            if (request.newRouteName == null) throw new ApiException("new route name is null");
            if (request.userId != travelRoute.userId) throw new ApiException("you cant change the route name that doesnt belong to you");
            if (request.newRouteName == travelRoute.routeName) throw new ApiException("New name must be different");

            travelRoute.routeName = request.newRouteName;
            travelRoute.isLiked = true;
            travelRoute.UpdatedDate = DateTime.UtcNow;

             _routeWriteRepository.Update(travelRoute);
            await _routeWriteRepository.SaveAsync();

            LikeAndRenameRouteCommandResponse r = new LikeAndRenameRouteCommandResponse();
            r.message = "Route name changed and liked succesfully.";

            return r;
        }
    }
}
