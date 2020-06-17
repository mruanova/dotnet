namespace MauDotNetCore.Models
{
    public class Connection
    {
        public int ConnectionId { get; set; }
 
        public int FollowerId { get; set; }
        public TwitterUser Follower { get; set; }
 
        public int UserFollowedId { get; set; }
        public TwitterUser UserFollowed { get; set; }
    }
}
