﻿using CleanArchitecture.Core.DTOs.Account;
using CleanArchitecture.Core.Features.Accounts.Queries.GetAccount;
using CleanArchitecture.Core.Wrappers;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task ForgotPassword(ForgotPasswordRequest model);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);

        Task<Response<string>> DeleteAccount(DeleteAccountRequest model);

        Task<GetAccountQueryResponse> GetAccountInfo(GetAccountQueryRequest request);
    }
}
