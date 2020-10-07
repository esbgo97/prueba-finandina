using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppModels.Models
{
    public class Client
    {
        //[Key]
        public int Id { get; set; }

        //[Required, MinLength(3), MaxLength(50)]
        public string Names { get; set; }
        
        //[Required, MinLength(3), MaxLength(50)]
        public string LastNames { get; set; }

        //[Required, MinLength(7), MaxLength(12)]
        public string DocNumber { get; set; }
        
        //[Required]
        public DateTime Birth { get; set; }

        //[Required]
        public bool IsActive { get; set; }
    }
}