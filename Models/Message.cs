using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauDotNetCore.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        // Navigation property for related User object
        public User Creator { get; set; }
    }
}