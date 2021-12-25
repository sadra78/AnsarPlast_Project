using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace AccountManagement.Application.Contracts.Account
{
    public class ChangePassword
    {
        public long Id { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired), MinLength(8, ErrorMessage = ValidationMessages.MinPassword)]
        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired), MinLength(8, ErrorMessage = ValidationMessages.MinPassword)]
        public string RePassword { get; set; }
    }
}
