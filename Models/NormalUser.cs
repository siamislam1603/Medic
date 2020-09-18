using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medic.Models
{
    public class NormalUser
    {
        [Required]
        [StringLength(128)]
        public string id { get; set; }
        [StringLength(maximumLength: 3, MinimumLength = 2)]
        public string bloodGroup { get; set; }
        [StringLength(32)]
        public string name { get; set; }
    }
}