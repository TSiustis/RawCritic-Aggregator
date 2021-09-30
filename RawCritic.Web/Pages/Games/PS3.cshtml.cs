using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using RawCritic.Web.Data;
using RawCritic.Web.Models;
using RawCritic.Web.Services;

namespace RawCritic.Web.Pages.Games
{
    public class PS3Model : GamePageModelService
    {
        
        public IQueryable<Game> Games { get; set; }
        public PS3Model(ApplicationDbContext context, IMemoryCache memoryCache) : base(context, memoryCache)
        {
            _context = context;
        }
        public IList<Game> Game { get; set; }

        public IEnumerable<Models.Game> Data { get; set; }
        public async Task OnGetAsync()
        {
            Data = await GetPaginatedResult(CurrentPage, "PlayStation 3", PageSize);
            Game = await GetCategoryAsync("PlayStation 3", SearchString);
        }
        public IQueryable<Game> GetGames(int i)
        {
            Games = _context.Game.Take(i).OrderByDescending(s => s.AggregatedRating);
            return Games;
        }
        public string GetPlatforms(string platform)
        {
            string[] platforms = platform.Split("/");
            string result = platform.Replace("/", "\n");
            List<string> temp = new List<string>();
            foreach (var item in platforms)
            {
                temp.Add(item + Environment.NewLine);
            }
            return result;
        }
      

      

    }
}
