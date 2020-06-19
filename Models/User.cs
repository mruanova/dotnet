using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MauDotNetCore.Models
{
    public class User // IdentityUser
    {
        [Key]
        public int UserId { get; set; } = 1;

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        // Navigation property for related Message objects
        public List<Message> CreatedMessages { get; set; }
        /*
        // identity
        public User()
        {
            CreatedMessages = new List<Message>();
        }
        */
    }
}