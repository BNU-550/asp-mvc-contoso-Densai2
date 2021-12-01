using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_MVC_Contoso.Models;

namespace ASP_MVC_Contoso.Data
{
    public class DbInitaliser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddStudents(context);
            AddCourses(context);
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
        }
        public static void AddStudents(ApplicationDbContext context)
        {
            if (context.Students.Any())
            {
                return;    //db has been seeded
            }
            var students = new Student[]
            {
                    new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                    new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                    new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                    new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                    new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
        public static void AddCourses(ApplicationDbContext context)
        {
            if (context.Courses.Any())
            {
                return;    //db has been seeded
            }

            Module CO550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web Applications",
            };

            Module CO588 = new Module
            {
                ModuleID = "CO588",
                Title = "Database Design",
            };

            Module CO567 = new Module
            {
                ModuleID = "CO567",
                Title = "OO Systems Devlopment",
            };

            Module CO566 = new Module
            {
                ModuleID = "CO566",
                Title = "Mobile Systems",
            };

            var modules = new Module[]
            {
                CO550, CO566, CO567, CO588
            };

            context.Modules.AddRange(modules);
            context.SaveChanges(true);

            if (context.Courses.Any())
            {
                return;
            }


            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "BT1CTG1",
                    Title = "Computing",

                },

                new Course
                {
                    CourseID = "BT1CWD1",
                    Title = "Computing and Web",

                },
                new Course{CourseID="BB1DSC1", Title="Data Science" },
                new Course{CourseID="BT1SFT1", Title="Software Engineering" },
                new Course{CourseID="BB1ARI1", Title="Artificial Intelligence" },
                new Course{CourseID="MY1CYS1", Title="Cyber Security" },
                new Course{CourseID="BT1GDV1", Title="Games Development" },
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

        }
    }
}
