using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using Remotion.Linq.Parsing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetRouteById
{
    public class GetRouteByIdQueryHandler : IRequestHandler<GetRouteByIdQueryRequest, GetRouteByIdQueryResponse>
    {
        private readonly IRouteReadRepository _routeReadRepository;

        public GetRouteByIdQueryHandler(IRouteReadRepository routeReadRepository)
        {
            _routeReadRepository = routeReadRepository;
        }
        public async Task<GetRouteByIdQueryResponse> Handle(GetRouteByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Entities.TravelEntities.TravelRoute travelRoute = await _routeReadRepository.GetByIdAsync(request.id);
            if (travelRoute == null) { throw new ApiException("Route is not found"); }
            GetRouteByIdQueryResponse routeByIdQueryResponse = new GetRouteByIdQueryResponse();
            routeByIdQueryResponse.travelRoute = travelRoute;
            return routeByIdQueryResponse;

        }
    }
}
