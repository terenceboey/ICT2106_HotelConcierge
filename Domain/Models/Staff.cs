using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2106_Project.Domain.Models
{
    public class Staff
    {
        public Account Account { get; set; }
        [Key]   
        public Guid account_id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string Role { get; set; }
        public Hotel Hotel { get; set; }
        public string hotel_id { get; set; }

    }
}
