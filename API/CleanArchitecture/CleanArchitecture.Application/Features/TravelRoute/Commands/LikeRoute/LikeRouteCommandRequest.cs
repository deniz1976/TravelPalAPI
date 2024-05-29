using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.LikeRoute
{
    public class LikeRouteCommandRequest : IRequest<LikeRouteCommandResponse>
    {
        public string userId { get; set; }

        public string routeId { get; set; }

    }
}
