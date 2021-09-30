using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RawCritic.Web.Data;
using RawCritic.Web.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class SeedData
    {
        private static IList<Game> games = new List<Game>();
        private static readonly ApplicationDbContext _context;


        private static Game game;

        public static async void InitializeAsync(IServiceProvider serviceProvider)
        {
            Debug.AutoFlush = true;
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                IGDBApi client = Client.Create(""); //your IGDB API Key here
                if (context.Game.Any())
                {
                    return;   // db has been seeded
                }
                GameJSON[] GameJSONs = new GameJSON[1000];

                // Task.Run(async () =>
                //{
                var coverSmall = "";
                var artworkImageId = "";
                //loop through the API and add Games to Database
                for (int i = 32001; i <= 33000; i++)
                {
                    try
                    {


                        GameJSONs = await client.QueryAsync<GameJSON>(Client.Endpoints.Games, query: "fields name,cover.*,genres.*,platforms.*,artworks.image_id,release_dates.*,involved_companies.*,aggregated_rating,storyline,summary,rating_count; where id =(" + i.ToString() + ");");
                        System.Diagnostics.Trace.WriteLine(client.ToString());



                        if (GameJSONs.FirstOrDefault() != null)
                        {


                            var genres = "";
                            var platforms = "";
                            var developer = "";

                            var bigCover = "";
                            if (coverSmall != null)
                            {
                                foreach (var item in GameJSONs)
                                {
                                    if (item != null)
                                    {
                                        if (item.Artworks != null)
                                            artworkImageId = item.Artworks.Values.First().ImageId;
                                        else
                                            artworkImageId = "";
                                        // coverSmall = ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.CoverBig, retina: false);
                                        if (artworkImageId != "")
                                            bigCover = ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.ScreenshotBig, retina: false);
                                        foreach (var item2 in item.Genres.Values)
                                        {
                                            genres = genres + item2.Name + "/";
                                        }
                                        foreach (var item2 in item.Platforms.Values)
                                        {
                                            platforms += item2.Name + "/";
                                        }
                                        //we need to trim the storyline and summary if higher than 4000 characters
                                        if (item.Storyline.Length > 4000)
                                        {
                                            game = new Game(item.Id, item.Name, DateTimeOffset.Parse(item.ReleaseDates.Values.First().Human), "http:" + item.Cover.Value.Url, genres, platforms, item.AggregatedRating, developer, "http:" + bigCover, item.Storyline.Substring(0, 4000), item.Summary, item.AggregatedRatingCount);
                                        }
                                        else if (item.Summary.Length > 4000)
                                        {
                                            game = new Game(item.Id, item.Name, DateTimeOffset.Parse(item.ReleaseDates.Values.First().Human), "http:" + item.Cover.Value.Url, genres, platforms, item.AggregatedRating, developer, "http:" + bigCover, item.Storyline, item.Summary.Substring(0, 4000), item.AggregatedRatingCount);
                                        }
                                        else
                                            game = new Game(item.Id, item.Name, DateTimeOffset.Parse(item.ReleaseDates.Values.First().Human), "http:" + item.Cover.Value.Url, genres, platforms, item.AggregatedRating, developer, "http:" + bigCover, item.Storyline, item.Summary, item.AggregatedRatingCount);
                                        //used for testing locally
                                        // Game.GetAllProperties(game);
                                        if (game != null)
                                            games.Prepend(game);
                                        try
                                        {

                                            await context.AddAsync(game);
                                        }
                                        catch (Exception e1)
                                        {

                                            System.Diagnostics.Trace.WriteLine(e1.ToString());
                                        }

                                    }
                                    genres = "";
                                    platforms = "";

                                }
                            }

                        }

                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Trace.WriteLine(client.ToString());
                        System.Diagnostics.Trace.WriteLine(e.ToString());
                    }
                }
                context.SaveChanges();
            }




        }

    }
}
