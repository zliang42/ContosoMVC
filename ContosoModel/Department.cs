using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Budget { get; set; }
        public DateTime? StartDate { get; set; }

        public int InstructorId { get; set; }

        public byte?[] RowVersion { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public List<Course> Courses { get; set; }

        public Instructor Instructor { get; set; }

    }
}
