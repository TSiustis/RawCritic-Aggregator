using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class UserReview
    {
        public int ID { get; set; }
        public string Score { get; set; }
        public string Review { get; set; }
        public User User { get; set; }
    }
}
