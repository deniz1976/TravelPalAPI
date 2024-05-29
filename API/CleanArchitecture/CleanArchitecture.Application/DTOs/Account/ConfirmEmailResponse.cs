using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.DTOs.Account
{
    public class ConfirmEmailResponse
    {
        public bool? succeded { get; set; }

        public string? message { get; set; }
         
        public List<string>? errors { get; set; }

        public string? data { get; set; }
    }
}
