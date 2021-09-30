using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class InvolvedCompany : ITimeStamps
    {
        public DateTimeOffset? CreatedAt { get; set; }
        public bool? Developer { get; set; }
        public IdentityOrValue<Game> Game { get; set; }
        public int? Id { get; set; }
        public bool? Porting { get; set; }
        public bool? Publisher { get; set; }
        public bool? Supporting { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
