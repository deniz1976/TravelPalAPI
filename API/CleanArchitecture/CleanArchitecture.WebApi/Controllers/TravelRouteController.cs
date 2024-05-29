using CleanArchitecture.Core.Entities.TravelEntities;
using CleanArchitecture.Core.Features.TravelRoute.Commands.CreateRoute;
using CleanArchitecture.Core.Features.TravelRoute.Commands.DeleteRoute;
using CleanArchitecture.Core.Features.TravelRoute.Commands.LikeAndRenameRoute;
using CleanArchitecture.Core.Features.TravelRoute.Commands.LikeRoute;
using CleanArchitecture.Core.Features.TravelRoute.Commands.RenameRoute;
using CleanArchitecture.Core.Features.TravelRoute.Commands.UpdateRoute;
using CleanArchitecture.Core.Features.TravelRoute.Queries.GetLikedRoutes;
using CleanArchitecture.Core.Features.TravelRoute.Queries.GetRouteById;
using CleanArchitecture.Core.Features.TravelRoute.Queries.RouteComponentImage;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TravelRouteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TravelRouteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[Action]")]
        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(List<TravelRoute>),StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateRoute(CreateRouteCommandRequest createRouteCommandRequest) {
            CreateRouteCommandResponse response = await _mediator.Send(createRouteCommandRequest);
            return Ok(response);
        }

        [HttpPost("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(UpdateRouteCommandResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateRoute(UpdateRouteCommandRequest updateRouteCommandRequest) {
            UpdateRouteCommandResponse response = await _mediator.Send(updateRouteCommandRequest);
            return Ok(response);
        
        }

        [HttpGet("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(GetRouteComponentQueryResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> GetRouteComponentImage([FromQuery]GetRouteComponentQueryRequest getRouteComponentQueryRequest) 
        {
            GetRouteComponentQueryResponse routeComponentQueryResponse = await _mediator.Send(getRouteComponentQueryRequest);
            return Ok(routeComponentQueryResponse);
        }

        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(GetRouteByIdQueryResponse),StatusCodes.Status200OK)]
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetRouteById([FromQuery] GetRouteByIdQueryRequest getRouteByIdQueryRequest) 
        {
            GetRouteByIdQueryResponse getRouteByIdQueryResponse = await _mediator.Send(getRouteByIdQueryRequest);
            return Ok(getRouteByIdQueryResponse);
        }

        [Authorize]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(DeleteRouteCommandResponse),StatusCodes.Status200OK)]
        [HttpDelete("[Action]")]
        public async Task<IActionResult> DeleteRouteById(DeleteRouteCommandRequest deleteRouteCommandRequest) 
        {
            DeleteRouteCommandResponse deleteRouteCommandResponse = await _mediator.Send(deleteRouteCommandRequest);
            return Ok(deleteRouteCommandResponse);

        }

        [Authorize]
        [HttpPut("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(LikeAndRenameRouteCommandResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> LikeAndRenameRoute(LikeAndRenameRouteCommandRequest likeAndRenameRouteCommandRequest) 
        {
            LikeAndRenameRouteCommandResponse likeAndRenameRouteCommandResponse = await _mediator.Send(likeAndRenameRouteCommandRequest);
            return Ok(likeAndRenameRouteCommandResponse);
        }
        [Authorize]
        [HttpPut("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(LikeRouteCommandResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> LikeRoute(LikeRouteCommandRequest likeRouteCommandRequest) 
        {
            LikeRouteCommandResponse likeRouteCommandResponse = await _mediator.Send(likeRouteCommandRequest);
            return Ok(likeRouteCommandResponse);
        }

        [Authorize]
        [HttpPut("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(RenameRouteCommandResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> RenameRoute(RenameRouteCommandRequest renameRouteCommandRequest) 
        {
            RenameRouteCommandResponse response = await _mediator.Send(renameRouteCommandRequest);
            return Ok(response);

        }

        [Authorize]
        [HttpGet("[Action]")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(GetLikedRoutesQueryResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> GetLikedRoutes([FromQuery]GetLikedRoutesQueryRequest getLikedRoutesQueryRequest) 
        {
            GetLikedRoutesQueryResponse getLikedRoutesQuery = await _mediator.Send(getLikedRoutesQueryRequest);
            return Ok(getLikedRoutesQuery);
        }
    }
}
