using CleanArchitecture.Core.DTOs.Account;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.Accounts.Queries.GetAccount;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        /**************************************************************************************************/


        [ProducesResponseType(typeof(Response<AuthenticationResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            try
            {
                return Ok(await _accountService.AuthenticateAsync(request, GenerateIPAddress()));
            }
            catch (ApiException ex)
            {

                return BadRequest(new AuthenticationBadRequestResponse { Message = ex.Message });
            }
            
            
        }

        /**************************************************************************************************/


        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            
            try
            {
                var origin = "";
                return Ok(await _accountService.RegisterAsync(request, origin));
            }
            catch (ApiException ex) {
                return BadRequest(new RegisterBadRequestResponse { message = ex.Message });
            }
            
        }

        /**************************************************************************************************/


        [ProducesResponseType(typeof(ConfirmEmailResponse),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {

            try
            {
                return Ok(await _accountService.ConfirmEmailAsync(userId, code));

            }
            catch (ApiException ex)
            {
                return BadRequest(new AuthenticationBadRequestResponse { Message = ex.Message });
            }
            
            
            
        }

        /**************************************************************************************************/

        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest model)
        {
            await _accountService.ForgotPassword(model);
            return Ok();
        }
        
        
        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<string>),StatusCodes.Status500InternalServerError)]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {

            return Ok(await _accountService.ResetPassword(model));
        }
        /**************************************************************************************************/


        [Authorize]
        [ProducesResponseType(typeof(ConfirmEmailResponse),StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ConfirmEmailResponse),StatusCodes.Status200OK)]
        [HttpDelete("delete-accout")]
        public async Task<IActionResult> DeleteAccount(DeleteAccountRequest model)
        {
            return Ok(await _accountService.DeleteAccount(model));
        }

        /**************************************************************************************************/

        private string GenerateIPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

        /**************************************************************************************************/

        [Authorize]
        [HttpGet("get-account-info")]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(GetAccountQueryResponse),StatusCodes.Status200OK)]
        public async Task<IActionResult> GetInfo([FromQuery] GetAccountQueryRequest getAccountQueryRequest) 
        {
            return Ok(await _accountService.GetAccountInfo(getAccountQueryRequest));
        }


    }
}