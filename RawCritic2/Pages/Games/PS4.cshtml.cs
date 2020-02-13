using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using RawCritic2.Data;
using RawCritic2.Models;
using RawCritic2.Services;

namespace RawCritic2.Pages.Games
{
    public class PS4Model : GamePageModelService
    {
        //private readonly RawCritic2.Data.ApplicationDbContext _context;
        public IQueryable<Game> Games { get; set; }
        public PS4Model(ApplicationDbContext context, IMemoryCache memoryCache) : base(context, memoryCache)
        {
            _context = context;
        }
        public IQueryable<Game> Game { get; set; }

        public IEnumerable<Models.Game> Data { get; set; }
        public string CurrentFilter { get;  set; }

        public async Task OnGetAsync()
        {
            var game =  from g in _context.Game
                       select g;
            string TestString;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Data = await _context.Game.Where(s => s.Title.Contains(SearchString)).OrderByDescending(d => d.AggregatedRating).ToListAsync();
            }
            else
            {
                Data = await GetPaginatedResult(CurrentPage, "Playstation 4", PageSize);
            }


          //  Game = await GetCategoryAsync("Play Station4", SearchString);

           // Game = await GetPaginatedResult(CurrentPage, PageSize);
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
