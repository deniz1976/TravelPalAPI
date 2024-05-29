using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Route;
using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.DeleteRoute
{
    public class DeleteRouteCommandHandler : IRequestHandler<DeleteRouteCommandRequest, DeleteRouteCommandResponse>
    {
        private readonly IRouteWriteRepository _routeWriteRepository;
        private readonly IRouteReadRepository _routeReadRepository;

        public DeleteRouteCommandHandler(IRouteWriteRepository routeWriteRepository, IRouteReadRepository routeReadRepository) 
        {
            _routeWriteRepository = routeWriteRepository;
            _routeReadRepository = routeReadRepository;
        }
        public async Task<DeleteRouteCommandResponse> Handle(DeleteRouteCommandRequest request, CancellationToken cancellationToken)
        {
            Entities.TravelEntities.TravelRoute route = await _routeReadRepository.GetByIdAsync(request.routeId);

            if (route == null || request == null) throw new ApiException("Route not found");

            if (route.userId != request.userId) throw new ApiException("You cant delete route that doesnt belong to you");

            await _routeWriteRepository.RemoveAsync(request.routeId);
            await _routeWriteRepository.SaveAsync();
            DeleteRouteCommandResponse deleteRouteCommandResponse = new DeleteRouteCommandResponse();
            deleteRouteCommandResponse.message = "Account Deleted";
            return deleteRouteCommandResponse;
        }
    }
}
