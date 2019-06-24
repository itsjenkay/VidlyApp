using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace VidlyApp.Models
{
    public class Customer
    {
       
        public int Id { get; set; }

        [Required]
        [MaxLength(255)] 
        public string Name { get; set; }

        [Display(Name ="Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Required]
        public MembershipType MembershipType { get; set; }
        
        public byte MembershipTypeId { get; set; }

    }
}