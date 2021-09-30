using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RawCritic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawCritic.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Game { get; set; }        //public DbSet<RawCritic2.Models.Genre> Genre{ get; set; }
        //public DbSet<RawCritic2.Models.Platform> Platform { get; set; }
        public DbSet<GameJSON> GameJSON { get; set; }
        public async virtual Task<List<Game>> GetGamesAsync()
        {
            return await Game
                .OrderBy(game => game.Title)
                .AsNoTracking()
                .ToListAsync();
        }
        public static List<Game> GetSeedingMessages()
        {
            return new List<Game>()
            {
                new Game(9999,"Majora'S Mask",DateTime.Now,"Cover","Platformer","Nintendo64",9.10,"Nintendo","Cover","Majora's Mask","Some Text",23),
                 new Game(9998,"Twilight Sword",DateTime.Now,"Cover","Platformer","Nintendo64",9.10,"Nintendo","Cover","Twilight Sword","Some Text",23),
                new Game(9997,"Ocarina of Time",DateTime.Now,"Cover","Platformer","Nintendo64",9.10,"Nintendo","Cover","Ocarina of Time","Some Text",23)
            };
        }
    }
}
