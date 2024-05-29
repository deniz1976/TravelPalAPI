using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.DTOs.Account
{
    public class AuthenticationInternalServerErrorResponse
    {
        public bool Succeded { get; set; }

        public string Message { get; set; }

        public string Errors { get; set; }

        public string Data { get; set; }
    }
}
