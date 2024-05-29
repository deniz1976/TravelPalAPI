using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage
{
    public class GetRouteComponentQueryRequest : IRequest<GetRouteComponentQueryResponse>
    {
        public int? maxHeightPx { get; set; }
        public int? maxWidthPx { get; set; }
        public string? placeAndPhotoID { get; set; }
    }
}
