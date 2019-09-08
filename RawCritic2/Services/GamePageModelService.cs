using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RawCritic2.Data;
using RawCritic2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic2.Services
{
    public class GamePageModelService : PageModelService
    {

        public IList<Game> ListGames { get; set; }
        private readonly RawCritic2.Data.ApplicationDbContext _context;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public GamePageModelService(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task<List<Game>> GetCategoryAsync(string platform,string searchString)
        {
            var game = from m in _context.Game
                       select m;

            game = game.Where(s => s.platforms.Contains(platform));
            if (!string.IsNullOrEmpty(SearchString))
            {
                game = game.Where(s => s.Title.Equals(SearchString));
            }
         ListGames =    await game.ToListAsync();
            return await game.ToListAsync();
        }
        
    }
}
