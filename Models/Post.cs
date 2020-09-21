using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medic.Models
{
    public class Post
    {
       
        public int id { get; set; }
        
        public string post { get; set; }
     
        public DateTime postDate { get; set; }
        public string UserId { get; set; }

       
        
    }
}