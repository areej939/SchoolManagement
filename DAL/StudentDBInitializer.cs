using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagement.DAL
{
    public class StudentDBInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> defaultGrades = new List<Grade>();

            defaultGrades.Add(new Grade()
            {
                GradeName="first grade",
                Section="elemenetray"
            });


            IList<Student> defaultStudents = new List<Student>();

            defaultStudents.Add(new Student() { 
                    StudentName="saddam alsalem" ,
                    GradeId=1
            });
            defaultStudents.Add(new Student()
            {
                StudentName = "Mohamad Alahmad",
                GradeId = 1
            });
            defaultStudents.Add(new Student()
            {
                StudentName = "Sara ",
                GradeId = 1
            });
            context.Grades.AddRange(defaultGrades);
            context.Students.AddRange(defaultStudents);
            base.Seed(context);
        }
    }
}