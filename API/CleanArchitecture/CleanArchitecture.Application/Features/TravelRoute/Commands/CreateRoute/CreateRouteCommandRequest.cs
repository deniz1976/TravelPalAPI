using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute
{
    public class CreateRouteCommandRequest : IRequest<CreateRouteCommandResponse>
    {
        public string CountryOrCity { get; set; }

        public string TransportVehicle { get; set; }

        public DateTime StartDay{ get; set; }

        public DateTime EndDay { get; set;}

        public Guid? userId { get; set; }



    }
}
