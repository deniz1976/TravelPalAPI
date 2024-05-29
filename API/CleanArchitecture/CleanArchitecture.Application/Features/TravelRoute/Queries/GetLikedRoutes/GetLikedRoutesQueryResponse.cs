using CleanArchitecture.Core.Entities.TravelEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Queries.GetLikedRoutes
{
    public class GetLikedRoutesQueryResponse
    {
        public IQueryable LikedRoutes { get; set; }
    }
}
