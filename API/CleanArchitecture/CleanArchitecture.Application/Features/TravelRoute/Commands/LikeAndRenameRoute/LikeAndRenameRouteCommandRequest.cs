using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.LikeAndRenameRoute
{
    public class LikeAndRenameRouteCommandRequest : IRequest<LikeAndRenameRouteCommandResponse>
    { 
        public string userId { get; set; }
        
        public string routeId { get; set; }

        public string newRouteName { get; set; }
    }
}
