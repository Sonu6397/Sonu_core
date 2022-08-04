using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sonu_core.Models.LoginViewMOdel;

namespace Sonu_core.Models
{
    public class studentContext:DbContext
    {
       public studentContext(DbContextOptions<studentContext> options) : base(options)
        {

        }
       public DbSet<Studentmodel> Studentmodels { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Sonu_core.Models.LoginViewMOdel.SignupViewModel> SignupViewModel { get; set; }
    }
}
