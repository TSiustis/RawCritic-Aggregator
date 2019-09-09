using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RawCritic2.Models;
using RawCritic2.Services;

namespace RawCritic2.Pages
{
    public class SearchResults : GamePageModelService
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        private readonly RawCritic2.Data.ApplicationDbContext _context;

        public SearchResults(RawCritic2.Data.ApplicationDbContext context) : base(context)
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