using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RawCritic2.Data;
using RawCritic2.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace RawCritic2.Models
{
    public class SeedData
    {
        private static IList<Game> games = new List<Game>();
        private static readonly RawCritic2.Data.ApplicationDbContext _context;


        private static Game game;

        public static async void InitializeAsync(IServiceProvider serviceProvider)
        {
            Debug.AutoFlush = true;
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                IGDBApi client = Client.Create("7aaa66047512155bfb9c4383cc87337f");
                //if (context.Game.Any())
                //{
                //    return;   // DB has been seeded
                //}
                GameJSON[] GameJSONs = new GameJSON[1000];

                // Task.Run(async () =>
                //{
                var coverSmall = "";
                var artworkImageId = "";

                
                try
                {
                    //int i = _context.Game
                    //   .OrderByDescending(p => p.GameID)
                    //   .FirstOrDefault().GameID; ;
                    int k = 10;
                    string id = "";
                    //for (; i < 100; i++)
                    //{
                        
                            GameJSONs = await client.QueryAsync<GameJSON>(Client.Endpoints.Games, query: "fields name,cover.*,genres.*,platforms.*,artworks.image_id,release_dates.*,involved_companies.*,aggregated_rating,storyline,summary,rating_count; where id =(171,172,173,174,175,176,177,178,179,180);");
                        System.Diagnostics.Trace.WriteLine(client.ToString());
                   

                        //  context.GameJSON.Add(GameJSONs.FirstOrDefault());
                        //     GameJSONs=JsonConvert.DeserializeObject<GameJSON>(GameJSONs.FirstOrDefault());

                        if (GameJSONs.FirstOrDefault() != null)
                        {
                        
                         
                            var genres = "";
                            var platforms = "";
                            var developer = "";
                            //foreach (var item in GameJSONs)
                            //{
                            //    foreach (var item2 in item.Genres.Values)
                            //    {
                            //        genres.Add(item2);
                            //        await context.AddAsync(item2);
                            //    }
                            //}
                            //foreach (var item in GameJSONs)
                            //{
                            //    foreach (var item2 in item.Platforms.Values)
                            //    {
                            //        platforms.Add(item2);
                            //        await context.AddAsync(item2);
                            //    }
                            //}
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
                                        //foreach (var item2 in item.InvolvedCompanies.Values)
                                        //{
                                        //    if (item2.Developer == true)
                                        //    {
                                        //        if (item2.Company.Value != null)
                                        //            developer = item2.Company.Value.Name;
                                        //    }
                                        //}
                                        game = new Game(item.Id, item.Name, DateTimeOffset.Parse(item.ReleaseDates.Values.First().Human), "http:" + item.Cover.Value.Url, genres, platforms, item.AggregatedRating, developer, "http:" + bigCover, item.Storyline, item.Summary, item.AggregatedRatingCount);
                                        //   System.Diagnostics.Trace.WriteLine("game: " + Game.GetAllProperties(game));
                                        Game.GetAllProperties(game);
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
                            //try
                            //{

                            //    await context.AddRangeAsync(games);
                            //}
                            //catch (Exception e1)
                            //{

                            //    System.Diagnostics.Trace.WriteLine(e1.ToString());
                            //}
                        //}

                       // System.Diagnostics.Trace.WriteLine("genres: " + genres);
//System.Diagnostics.Trace.WriteLine("platforms: " + platforms);
                        //System.Diagnostics.Trace.WriteLine("JSON: " + GameJSONs.FirstOrDefault().Name + GameJSONs.FirstOrDefault().Artworks.Values + GameJSONs.FirstOrDefault().Cover.Value.Url + GameJSONs.FirstOrDefault().Genres.Values.FirstOrDefault().Name + GameJSONs.FirstOrDefault().ReleaseDates.Values + GameJSONs.FirstOrDefault().Platforms.Values.FirstOrDefault().Name);
                        //  System.Diagnostics.Trace.WriteLine(GameJSON.GetAllProperties(GameJSONs.FirstOrDefault()));
                    }

                }
                catch (Exception e)
                {
                    System.Diagnostics.Trace.WriteLine(client.ToString());
                    System.Diagnostics.Trace.WriteLine(e.ToString());
                    //System.Diagnostics.Trace.WriteLine("JSON: " + GameJSONs.FirstOrDefault().Name + GameJSONs.FirstOrDefault().Artworks.Values + GameJSONs.FirstOrDefault().Cover.Value.Url + GameJSONs.FirstOrDefault().Genres.Values.FirstOrDefault().Name + GameJSONs.FirstOrDefault().ReleaseDates.Values);
                    //System.Diagnostics.Trace.WriteLine(GameJSON.GetAllProperties(GameJSONs.FirstOrDefault()));
                }

                context.SaveChanges();
            }




            //if (GameJSONs != null)
            //{



            //}

            //     context.Game.Add(game);


            //System.Diagnostics.Trace.WriteLine("Cover: " + coverSmall);
            //}
            //}).GetAwaiter().GetResult();


        }

    
    }

}
