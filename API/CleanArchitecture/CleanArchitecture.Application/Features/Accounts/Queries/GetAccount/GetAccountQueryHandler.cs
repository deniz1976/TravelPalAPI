using CleanArchitecture.Core.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.Accounts.Queries.GetAccount
{
    public class GetAccountQueryHandler : IRequestHandler<GetAccountQueryRequest, GetAccountQueryResponse>
    {
        private readonly IAccountService _accountService;
        

        public GetAccountQueryHandler(IAccountService accountService) 
        {
            _accountService = accountService;
        }

        public async Task<GetAccountQueryResponse> Handle(GetAccountQueryRequest request, CancellationToken cancellationToken)
        {
            if (request == null) {
                throw new Exception("request is empty");
            }

            GetAccountQueryResponse response = await _accountService.GetAccountInfo(request);
            return response;

        }
    }
}
