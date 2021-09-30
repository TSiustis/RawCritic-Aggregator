using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class Genre : ITimeStamps
    {
        public DateTimeOffset? CreatedAt { get; set; }
        [Key]
        public int GenreID { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Url { get; set; }
        public static string GetAllProperties(object obj)
        {
            return string.Join(" ", obj.GetType()
                                        .GetProperties()
                                        .Select(prop => prop.GetValue(obj)));
        }
    }
}
