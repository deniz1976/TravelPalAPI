using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.City.Queries.GetCity
{
    public class GetCityQueryRequest : IRequest<GetCityQueryResponse>
    { 

        public string Text { get; set; }
    }
}
