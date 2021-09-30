using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
 
        public class Platform : ITimeStamps
        {
            public string Abbreviation { get; set; }
            [Key]
            public int PlatformID { get; set; }
            public string AlternativeName { get; set; }
            public PlatformCategory Category { get; set; }
            public DateTimeOffset? CreatedAt { get; set; }
            public int? Generation { get; set; }
            public int? Id { get; set; }
            public string Name { get; set; }

            public string Slug { get; set; }
            public string Summary { get; set; }
            public DateTimeOffset? UpdatedAt { get; set; }
            public string Url { get; set; }
            public static string GetAllProperties(object obj)
            {
                return string.Join(" ", obj.GetType()
                                            .GetProperties()
                                            .Select(prop => prop.GetValue(obj)));
            }
        }

        public enum PlatformCategory
        {
            Console = 1,
            Arcade = 2,
            Platform = 3,
            OperatingSystem = 4,
            PortableConsole = 5,
            Computer = 6
        }
    
}
