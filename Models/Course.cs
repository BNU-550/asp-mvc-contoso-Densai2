using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Contoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(8)]
        [RegularExpression("[A-Z] {2} [0-9] {3}")]
        public String CourseID { get; set; }

        [StringLength(30), Required, MinLength(10)]
        public string CourseCode { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }
        
        // Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
