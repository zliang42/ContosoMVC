using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Student
    {
        public int Id { get; set; }

        [Column("Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
