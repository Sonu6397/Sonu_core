using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonu_core.Models
{
    public class Studentmodel
    {
        [Key]
        public int id { get; set; }
        public string Fname{ get; set; }
        public string Lname { get; set; }
        public string Qalification { get; set; }
        public string Gender { get; set; }
        public string Mobile{ get; set; }
      
    }
}
