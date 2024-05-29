using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.City.Queries.GetCity;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        readonly IMediator _mediatR;
        

        public CityController(IMediator mediator, ICityService cityService)
        {
            _mediatR = mediator;
            
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(List<AllWorldCities>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCity([FromQuery]GetCityQueryRequest getCityQueryRequest) {
            GetCityQueryResponse getCityQueryResponse = await _mediatR.Send(getCityQueryRequest);
            return Ok(getCityQueryResponse.cities);
        
        }
    }
}
