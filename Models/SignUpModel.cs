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
        [FromForm(Name="first")]
        public string FirstName { get; set; }
        [Required]
        [FromForm(Name = "last")]
        public string LastName { get; set; }
        [Required]
        [FromForm(Name = "DOB")]
        public DateTime DOB { get; set; }

        [Required]
        [FromForm(Name = "email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [FromForm(Name = "password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [FromForm(Name = "confirmpassword")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
    }
}
