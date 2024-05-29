using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Features.Accounts.Queries.GetAccount
{
    public class GetAccountQueryRequest : IRequest<GetAccountQueryResponse>
    {
        public string id { get; set; }
    }
}
