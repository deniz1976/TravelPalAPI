using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces;
using Korzh.EasyQuery.Linq;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.City.Queries.GetCity
{
    public class GetCityQueryHandler : IRequestHandler<GetCityQueryRequest, GetCityQueryResponse>
    {
        private readonly ICityService _cityService;

        public GetCityQueryHandler(ICityService cityService)
        {

            _cityService = cityService;
        }

        public async Task<GetCityQueryResponse> Handle(GetCityQueryRequest request, CancellationToken cancellationToken)
        {
            GetCityQueryResponse response = new GetCityQueryResponse();
            if (!string.IsNullOrEmpty(request.Text))
            {
                var responseCity = _cityService.FullTextSearch(request.Text).Take(10).ToList();
                if (responseCity.Count == 0)
                {
                    return null;
                }             

                response.cities = responseCity;
            }         
            return response;
        }
    }
}
