using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetRouteById
{
    public class GetRouteByIdQueryRequest : IRequest<GetRouteByIdQueryResponse>
    {
        public string id { get; set; }
    }
}
