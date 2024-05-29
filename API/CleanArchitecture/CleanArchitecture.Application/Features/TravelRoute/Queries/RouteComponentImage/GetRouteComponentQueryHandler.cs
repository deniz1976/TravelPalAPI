using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage
{
    public class GetRouteComponentQueryHandler : IRequestHandler<GetRouteComponentQueryRequest, GetRouteComponentQueryResponse>
    {
        private readonly IPlacesService _placesService;

        public GetRouteComponentQueryHandler(IPlacesService placesService) 
        {
            _placesService = placesService;
        }
        public async Task<GetRouteComponentQueryResponse> Handle(GetRouteComponentQueryRequest request, CancellationToken cancellationToken)
        {

            GetRouteComponentQueryResponse r = await _placesService.GetRouteComponentImage(request);
            return r;
        }
    }
}
