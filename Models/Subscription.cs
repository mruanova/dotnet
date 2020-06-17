namespace MauDotNetCore.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int PersonId { get; set; }
        public int MagazineId { get; set; }
        public Person Person { get; set; }
        public Magazine Magazine { get; set; }
    }
}