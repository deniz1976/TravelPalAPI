using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Core.DTOs.Account
{
    public class DeleteAccountRequest
    {
        [Required]
        public string usernameOrEmailAddress { get; set; }
        [Required]
        public string password { get; set; }
    }
}
