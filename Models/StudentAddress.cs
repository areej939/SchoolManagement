using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class StudentAddress
    {
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }

       
        public string Address { get; set; }
        public string City { get; set; }
        
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}