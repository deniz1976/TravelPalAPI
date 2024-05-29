using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.DTOs.Account
{

    
    public class AuthenticationBadRequestIdentity
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
        public Errors errors { get; set; }

    }

    public class Errors {
    
        public List<string> strings { get; set; }
    }

    
}



