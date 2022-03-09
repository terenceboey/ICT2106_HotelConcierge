using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2106_Project.Domain.Models
{
    public class Guest
    {
        [Required]
        [Key]
        [ForeignKey("Account")]
        public Guid account_id { get; set; }
        public Account Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

    }
}
