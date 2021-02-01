using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Service
    {
        [Key]
        public int Services_Id { get; set; }

        [ForeignKey("Member")]
        public int Member_Id { get; set; }

        [ForeignKey("Staff")]
        public int Staff_Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Member Member { get; set; }
    }
}
