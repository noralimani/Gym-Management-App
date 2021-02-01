using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Member
    {
        [Key]
        public int Member_Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Name")]
        public string Member_Name { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [Display(Name = "Surname")]
        public string Member_Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Joined Date")]
        public DateTime JoinedDate { get; set; }

        public ICollection<Membership> Memberships { get; set; }

        public ICollection<Service> Services { get; set; }

        [NotMapped]
        public double Days
        {
            get
            {
                TimeSpan interval = DateTime.Now - JoinedDate;
                return interval.Days;
            }

        }
    }
}
