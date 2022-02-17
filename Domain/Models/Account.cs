using System;
using System.ComponentModel.DataAnnotations;

namespace _2106_Project.Domain.Models
{
    public class Account
    {
        [Key]
        public Guid account_id { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string AccountStatus { get; set; }
    }
}
