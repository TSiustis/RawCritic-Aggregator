using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RawCritic2.Data;
using RawCritic2.Models;
using RawCritic2.Services;

namespace RawCritic2.Pages.Games
{
    public class DetailsModel : GamePageModelService
    {
        private readonly RawCritic2.Data.ApplicationDbContext _context;
        public IList<Game> Games { get; set; }
        public string platformsFound { get; set; }
        public DetailsModel(RawCritic2.Data.ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.GameID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
        public  async Task<List<Game>> GetGamesToday(string platform, string searchString)
        {
            var game = from m in _context.Game
                       select m;

            game = game.Where(s => s.platforms.Contains(platform));
            if (!string.IsNullOrEmpty(SearchString))
            {
                game = game.Where(s => s.Title.Equals(SearchString));
            }
            ListGames = await game.ToListAsync();
            return await game.ToListAsync();
        }
        public IList<Game> GetGamesHighScore(int rating)
        {
            var game = from m in _context.Game
                       select m;

            game = game.Where(s => s.AggregatedRating >= rating).OrderByDescending(s => s.AggregatedRating); 
            Games = game.ToList();
            return Games;
        }
        public string GetPlatforms(string platform)
        {
            string[] platforms = platform.Split("/");
            string result = platform.Replace("/",   "\n");
            List<string> temp = new List<string>();
            foreach(var item in platforms)
            {
                temp.Add(item + Environment.NewLine);
            }
            return result;
        }
    }
}
