using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagement.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("School2021db"){
            Database.SetInitializer<SchoolContext>(new StudentDBInitializer());
        }

        public System.Data.Entity.DbSet<SchoolManagement.Models.Student> Students { get; set; }
        public System.Data.Entity.DbSet<SchoolManagement.Models.Grade> Grades { get; set; }
        public System.Data.Entity.DbSet<SchoolManagement.Models.StudentAddress> StudentAddresses { get; set; }
    }
}