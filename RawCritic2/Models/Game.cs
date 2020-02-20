using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic2.Models
{
    public class Game
    {
        public string genres { get; set; }
        public string platforms { get; set; }
        [Column(name: "release")]
        public int? releaseDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameID { get; set; }
        public string Storyline { get; set; }
        public string Summary { get; set; }
        [StringLength(60, MinimumLength = 3)]
        
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset  ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public ICollection<Genre> Genre { get; set; }
        public string Cover { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public ICollection<Platform> Platform { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]

 
        [StringLength(30)]
        public string Developer { get; set; }
        public int RatingCount { get; set; }
        public double AggregatedRating { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string BigCover { get; set; }
        public ICollection<UserReview> UserReview { get; set; }
        [ForeignKey(name: "PlatformID")]
        [Required]
        public int PlatformId { get; set; }
        [ForeignKey(name:  "GenreID")]
        [Required]
        public int GenreId { get; set; }
      

        public static string GetAllProperties(object obj)
        {
            return string.Join(" ", obj.GetType()
                                        .GetProperties()
                                        .Select(prop => prop.GetValue(obj)));
        }
      

        public Game(int id, string Title, DateTimeOffset ReleaseDate, string Cover, string genres, string platforms,double AggregatedRating,string Developer,string BigCover,string Storyline, string Summary,int RatingCount)
        {
            this.BigCover = BigCover;
            this.Developer = Developer;
            Id = id;
            this.Title = Title;
            this.ReleaseDate = ReleaseDate;
            this.Cover = Cover;
            this.genres = genres;
            this.platforms = platforms;
            this.AggregatedRating = AggregatedRating;
            this.Storyline = Storyline;
            this.Summary = Summary;
            this.RatingCount = RatingCount;

        }
    }
}
