using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.RenameRoute
{
    public class RenameRouteCommandRequest : IRequest<RenameRouteCommandResponse>
    {
        public string userId { get; set; }
        public string routeId { get; set; }

        public string newRouteName { get; set; }
    }
}
