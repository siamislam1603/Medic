using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medic.Models
{
    public class Doctor
    {
        [Required]
        [StringLength(128)]
        public string id { get; set; }
        [StringLength(32)]
        public string name { get; set; }
        public string specialization { get; set; }
    }
}