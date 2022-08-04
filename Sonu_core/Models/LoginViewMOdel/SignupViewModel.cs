using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonu_core.Models.LoginViewMOdel
{
    public class SignupViewModel
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
