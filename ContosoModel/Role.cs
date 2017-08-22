using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Column("Role Name")]
        public string RoleName { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
