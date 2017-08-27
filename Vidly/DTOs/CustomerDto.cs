using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(255)]
        public string Name { get; set; }

       // [Min18YearsIfAMAmber]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedForNewsleters { get; set; }
    
        public byte MembershipTypeId { get; set; }
    }
}