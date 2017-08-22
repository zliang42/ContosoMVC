using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string AddressLine1 { get; set; }

        [MaxLength(100)]
        public string AddressLine2 { get; set; }

        [Column("Unit")]
        public int? UnitOrApartmentNumber { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(30)]
        public string State { get; set; }


        [MaxLength(10)]
        public string ZipCode { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(50)]
        public string UpdatedBy { get; set; }

        [MaxLength(20)]
        [StringLength(20)]
        public string Password { get; set; }

        public string Salt { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? LastLockedDateTime { get; set; }
        public int? FailedAttempts { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
