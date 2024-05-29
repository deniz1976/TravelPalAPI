using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute;
using CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface ITravelService
    {
        public Task<CreateRouteCommandResponse> CreateRoute(CreateRouteCommandRequest request,int days);

    }
}
