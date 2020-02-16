using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using RawCritic2.Data;
using RawCritic2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace RawCritic2.Services
{
    public class GamePageModelService : PageModelService
    {

        public IMemoryCache _memoryCache;
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(_context.Game.Count(), PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public bool ShowFirst => CurrentPage != 1;
        public bool ShowLast => CurrentPage != TotalPages;
        public IList<Game> ListGames { get; set; }
        public  RawCritic2.Data.ApplicationDbContext _context;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public GamePageModelService(ApplicationDbContext context,IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _context = context;
        }
        public GamePageModelService(ApplicationDbContext context)
        {
            _context = context;
        }
        static readonly object cacheLock = new object();

        public async Task<IEnumerable<Game>> GetPaginatedResult(int currentPage,  string platform,int pageSize = 10)
        {
            IList<Game> data = new List<Game>();



            // Look for cache key.
            if (_memoryCache != null)
            {
                if (!_memoryCache.TryGetValue(CacheKeys.Entry, out data))
                {
                    // Key not in cache, so get data.
                    if (!string.IsNullOrEmpty(SearchString))
                    {
                        data = await _context.Game.Where(s => s.Title.Contains(SearchString)).OrderByDescending(d => d.AggregatedRating).ToListAsync();
                    }
                    else
                    {
                        data = await _context.Game.Select(s => s).Where(s => s.platforms.Contains(platform)).OrderByDescending(d => d.AggregatedRating).ToListAsync();
                    }
                    data = data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                    // Set cache options.
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        // Keep in cache for this time, reset time if accessed.
                        .SetSlidingExpiration(TimeSpan.FromSeconds(3));

                    // Save data in cache.
                    _memoryCache.Set(CacheKeys.Entry, data, cacheEntryOptions);
                }
            }
            else
            {
                data = data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            }

          
            return data;
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
