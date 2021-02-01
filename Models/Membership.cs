using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Membership
    {
        [Key]
        public int Membership_Id { get; set; }

        [ForeignKey("Staff")]
        public int? Staff_Id { get; set; }

        [ForeignKey("Member")]
        public int Member_Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [NotMapped]
        public double Days 
        {
            get
            {
                return (EndDate - StartDate).TotalDays;
            }
           
        }

        [DataType(DataType.Currency)]
        public float Total { get; set; }

        [JsonIgnore]
        public virtual Member Member { get; set; }
        public virtual Staff Staff { get; set; }
        
        
    }
}
