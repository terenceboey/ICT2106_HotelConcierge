using _2106_Project.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace _2106_Project.Models
{
    public class SignUpModel : PageModel
    { 
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        /*        [Required]
                [DataType(DataType.Password)]
                [Display(Name = "Confirm Password")]
                [Compare("Password", ErrorMessage = "Passwords don't match.")]
                public string ConfirmPassword { get; set; }

                [Required]
                public string Username { get; set; }*/
    }
}
