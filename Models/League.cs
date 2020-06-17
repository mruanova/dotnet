using System.Collections.Generic;

namespace MauDotNetCore.Models
{
    public class League
    {
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}