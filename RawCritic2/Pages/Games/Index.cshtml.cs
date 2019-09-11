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
    public class IndexModel : GamePageModelService
    {
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;
        private readonly RawCritic2.Data.ApplicationDbContext _context;
        public IQueryable<Game> Games { get; set; }
        public IndexModel(RawCritic2.Data.ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(_context.Game.Count(), PageSize));
        public IList<Game> Game { get; set; }

        public IList<Models.Game> Data { get; set; }
        public async Task OnGetAsync()
        {
           Data =await  GetPaginatedResult(CurrentPage, PageSize);
            Game = await GetCategoryAsync("", SearchString);
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
        public async Task<IList<Game>> GetPaginatedResult(int currentPage, int pageSize = 10)
        {
            var data =  _context.Game.Select(s => s);
            return  await data.OrderByDescending(d => d.AggregatedRating).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<int> GetCount()
        {

            return _context.Game.Count();
        }

        
    }
}
