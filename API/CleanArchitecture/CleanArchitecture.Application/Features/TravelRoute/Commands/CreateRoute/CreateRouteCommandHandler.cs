using CleanArchitecture.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute
{
    public class CreateRouteCommandHandler : IRequestHandler<CreateRouteCommandRequest, CreateRouteCommandResponse>
    {
        private readonly ITravelService _travelService;

        public CreateRouteCommandHandler(ITravelService travelService)
        {
        _travelService = travelService;
        }

        public async Task<CreateRouteCommandResponse> Handle(CreateRouteCommandRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request body is empty or half");

            }

            if (request.userId == null)
            {
                request.userId = new Guid("da9565c8-8b8a-4821-b5d3-33925eb63159");
            }

            if (request.StartDay > request.EndDay)
            {

                throw new Exception("last day is behind the first day");
            }

            TimeSpan diff = request.EndDay - request.StartDay;
            var days = 0;

            if (request.StartDay == request.EndDay)
                days = 1;

            else
                days = diff.Days + 1;

            CreateRouteCommandResponse response = await _travelService.CreateRoute(request, days);
            return response;
        }
    }
}
