using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonu_core.Models
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string Confirm_password { get; set; }
    }
}
