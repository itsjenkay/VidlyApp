using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Models;
using System.ComponentModel.DataAnnotations;

namespace VidlyApp.Dtos
{
    public class CustomersDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        
        public byte MembershipTypeId { get; set; }

    }
}