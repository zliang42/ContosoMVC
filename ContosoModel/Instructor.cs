using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Instructor
    {
        public int Id { get; set; }

        [Column("Hire Date")]
        public DateTime? HireDate { get; set; }

        public ICollection<Department> Departments { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
