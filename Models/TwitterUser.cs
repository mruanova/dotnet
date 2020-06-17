using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MauDotNetCore.Models
{
    public class TwitterUser
    {
        [Key]
        public int TwitterUserId { get; set; }
 
        [InverseProperty("UserFollowed")]
        public List<Connection> Followers { get; set; }
 
        [InverseProperty("Follower")]
        public List<Connection> UsersFollowed { get; set; }
    }
}