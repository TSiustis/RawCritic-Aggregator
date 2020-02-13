using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using RawCritic2.Data;
using RawCritic2.Models;
using RawCritic2.Services;

namespace RawCritic2.Pages
{
    public class SearchResults : GamePageModelService
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        private readonly RawCritic2.Data.ApplicationDbContext _context;

        public SearchResults(ApplicationDbContext context, IMemoryCache memoryCache) : base(context, memoryCache)
        {
            _context = context;
        }

        public IList<Game> Game { get; set; }

        public async Task OnGetAsync()
        {
            Game = await GetCategoryAsync("", SearchString);
        }
    }
}