using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class Artwork
    {
        public bool? AlphaChannel { get; set; }
        public bool? Animated { get; set; }
        public IdentityOrValue<Game> Game { get; set; }
        public int? Height { get; set; }
        public int? Id { get; set; }
        public string ImageId { get; set; }
        public string Url { get; set; }
        public int? Width { get; set; }
    }
}
