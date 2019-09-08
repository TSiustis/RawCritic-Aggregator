namespace RawCritic2.Models
{
    public class UserReview
    {
        public int ID { get; set; }
        public string Score { get; set; }
        public string Review { get; set; }
        public User User { get; set; }
    }
}