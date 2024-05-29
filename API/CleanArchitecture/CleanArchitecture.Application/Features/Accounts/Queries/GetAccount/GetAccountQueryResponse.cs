using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CleanArchitecture.Core.Features.Accounts.Queries.GetAccount
{
    public class GetAccountQueryResponse
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public bool? isDeleted { get; set; }

        public IQueryable? routes  { get; set; }
    }
}
