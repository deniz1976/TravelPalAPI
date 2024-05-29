using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetLikedRoutes
{
    public class GetLikedRoutesQueryRequest : IRequest<GetLikedRoutesQueryResponse>
    {
        public string userId { get; set; }

    }
}
