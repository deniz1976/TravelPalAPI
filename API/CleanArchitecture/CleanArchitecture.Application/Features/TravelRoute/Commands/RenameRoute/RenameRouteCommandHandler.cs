using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.TravelRoute.Commands.LikeAndRenameRoute;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using Remotion.Linq.Parsing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.RenameRoute
{
    public class RenameRouteCommandHandler : IRequestHandler<RenameRouteCommandRequest, RenameRouteCommandResponse>
    {

        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;

        public RenameRouteCommandHandler(IRouteReadRepository routeReadRepository, IRouteWriteRepository routeWriteRepository)
        {
            _routeReadRepository = routeReadRepository;
            _routeWriteRepository = routeWriteRepository;
        }
        public async Task<RenameRouteCommandResponse> Handle(RenameRouteCommandRequest request, CancellationToken cancellationToken)
        {

            Entities.TravelEntities.TravelRoute travelRoute = await _routeReadRepository.GetByIdAsync(request.routeId);
            if (travelRoute == null) throw new ApiException("route not found");
            if (request.newRouteName == null) throw new ApiException("new route name is null");
            if (request.userId != travelRoute.userId) throw new ApiException("you cant change the route name that doesnt belong to you");

            if (travelRoute.routeName == request.newRouteName) throw new ApiException("New name must be different");
            travelRoute.routeName = request.newRouteName;
            travelRoute.UpdatedDate = DateTime.UtcNow;

            _routeWriteRepository.Update(travelRoute);
            await _routeWriteRepository.SaveAsync();

            RenameRouteCommandResponse r = new RenameRouteCommandResponse();
            r.message = "Route name changed succesfully.";

            return r;
        }
    }
}
