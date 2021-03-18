using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        [ForeignKey("")]
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual StudentAddress Address { get; set; }
    }
}