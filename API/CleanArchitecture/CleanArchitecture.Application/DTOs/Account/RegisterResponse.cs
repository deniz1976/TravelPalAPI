using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.DTOs.Account
{
    public class RegisterResponse
    {
        public string message { get; set; }
        public bool succeeded { get; set; }

        public string userID { get; set; }
    }
}
