using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Contoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First name"), Required, StringLength(20)]
        public string FirstMidName { get; set; }

        [DisplayName("Enrol Date"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        // Relationships or navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
