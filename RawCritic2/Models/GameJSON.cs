using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic2.Models
{
    public class GameJSON
    {
        [Column("GameId")]
        [Key]
        public int GameId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [NotMapped]
        [JsonProperty("artworks")]
        public IdentitiesOrValues<Artwork> Artworks { get; set; }

        

        [JsonProperty("aggregated_rating")]
        public double AggregatedRating { get; set; }

        [JsonProperty("aggregated_rating_count")]
        public int AggregatedRatingCount { get; set; }

        [JsonProperty("category")]
        public Category? Category { get; set; }

        [NotMapped]
        [JsonProperty("cover")]
        public IdentityOrValue<Cover> Cover { get; set; }

        [NotMapped]
        [JsonProperty("expansions")]
        public IList<int> Expansions { get; set; }


        [JsonProperty("first_release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [NotMapped]
        [JsonProperty("game_engines")]
        public IList<int> GameEngines { get; set; }
        [NotMapped]
        [JsonProperty("genres")]
        public IdentitiesOrValues<Genre> Genres { get; set; }



        [JsonProperty("name")]
        public string Name { get; set; }
        [NotMapped]
        [JsonProperty("platforms")]
        public IdentitiesOrValues<Platform> Platforms { get; set; }


        [JsonProperty("popularity")]
        public double Popularity { get; set; }


        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("storyline")]
        public string Storyline { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rating_count")]
        public int TotalRatingCount { get; set; }




        [NotMapped]
        public IdentitiesOrValues<Game> Bundles { get; set; }

      


        [NotMapped]
        public IdentitiesOrValues<Game> Dlcs { get; set; }

    


        public int? Follows { get; set; }
     
        

      
        public int? Hypes { get; set; }
        [NotMapped]
        public IdentitiesOrValues<InvolvedCompany> InvolvedCompanies { get; set; }
       
        [NotMapped]
        public IdentityOrValue<Game> ParentGame { get; set; }



        public int? PulseCount { get; set; }


        [NotMapped]
        public IdentitiesOrValues<ReleaseDate> ReleaseDates { get; set; }
        [NotMapped]
        public IdentitiesOrValues<Game> SimilarGames { get; set; }

        [NotMapped]
        public IdentitiesOrValues<Game> StandaloneExpansions { get; set; }

        public GameStatus? Status { get; set; }

        [NotMapped]
        public int[] Tags { get; set; }

        public double? TotalRating { get; set; }


        public string Url { get; set; }
        [NotMapped]
        public IdentityOrValue<Game> VersionParent { get; set; }

        public string VersionTitle { get; set; }
        /// <summary>
        ///  Used for testing the received properties
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>A list of properties and their respective values.</returns>
        public static string GetAllProperties(object obj)
        {
            return string.Join(" ", obj.GetType()
                                        .GetProperties()
                                        .Select(prop => prop.GetValue(obj)));
        }

    }

public enum Category
{
    MainGame = 0,
    DlcAddon = 1,
    Expansion = 2,
    Bundle = 3,
    StandaloneExpansion = 4
}

public enum GameStatus
{
    Released = 0,
    Alpha = 2,
    Beta = 3,
    EarlyAccess = 4,
    Offline = 5,
    Cancelled = 6
}
}
