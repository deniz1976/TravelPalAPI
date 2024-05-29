using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetLikedRoutes
{
    public class GetLikedRoutesQueryHandler : IRequestHandler<GetLikedRoutesQueryRequest, GetLikedRoutesQueryResponse>
    {
        private readonly IRouteReadRepository _routeReadRepository;
        private readonly IRouteWriteRepository _routeWriteRepository;

        public GetLikedRoutesQueryHandler(IRouteReadRepository routeReadRepository, IRouteWriteRepository routeWriteRepository)
        {
            _routeReadRepository = routeReadRepository;
            _routeWriteRepository = routeWriteRepository;
        }

        public async Task<GetLikedRoutesQueryResponse> Handle(GetLikedRoutesQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null || request.userId == null) throw new ApiException("user id or request is null");
            var routes = _routeReadRepository.GetWhere(x => x.userId == request.userId && x.isLiked == true);
            GetLikedRoutesQueryResponse r = new GetLikedRoutesQueryResponse();
            r.LikedRoutes = routes;
            return r;

        }

    }
}
