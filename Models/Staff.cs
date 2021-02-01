using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    
        public enum Gender
        {
            male, female, diverse
        }

        public class Staff
        {

            [Key]
            public int Staff_id { get; set; }

            [Required]
            [StringLength(20, MinimumLength = 2)]
            [DisplayName("Name")]
            public string Staff_Name { get; set; }

            [Required]
            [DisplayName("Surname")]
            public string Staff_Surname { get; set; }


            public Gender? Gender { get; set; }

            [Required(ErrorMessage = "Field can't be empty")]
            [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
            public string Email { get; set; }


            public ICollection<Membership> Memberships { get; set; }

            public ICollection<Service> Services { get; set; }
        }
}
