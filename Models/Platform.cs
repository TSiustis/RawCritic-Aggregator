using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RawCritic2.Models
{
    public class Platform : ITimestamps
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
    [NotMapped]
    public IdentityOrValue<PlatformLogo> PlatformLogo { get; set; }
   
    public string Slug { get; set; }
    public string Summary { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string Url { get; set; }
        [NotMapped]
        public IdentitiesOrValues<PlatformVersion> Versions { get; set; }
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