using System;
using System.ComponentModel.DataAnnotations;

namespace _2106_Project.Domain.Models
{
    public class Guest
    {
        public Account Account { get; set; }
        [Key]
        public Guid account_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

    }
}
