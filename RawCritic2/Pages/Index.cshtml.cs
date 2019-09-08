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

namespace RawCritic2.Pages
{
    public class IndexModel : GamePageModelService 
    {
        private readonly RawCritic2.Data.ApplicationDbContext _context;
        [BindProperty(SupportsGet =true)]
        public new string SearchString { get; set; }
        public IndexModel(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }

        public Game Game { get; set; }
        public IList<Game> ListGames { get; set; }
        public IQueryable<Game> Games { get; set; }
        public IQueryable<Game> UpcomingGames { get; set; }
        public Game GetGame(int i)
        {
            Game = _context.Game.FirstOrDefault(m => m.GameID == i);
            return Game;
        }
        public IQueryable<Game> GetGames(int i)
        {
            Games = _context.Game.Take(i).OrderByDescending(s => s.AggregatedRating);
            return Games;
        }
        public IQueryable<Game> GetUpcoming(int i)
        {
            Games = _context.Game.Take(i).OrderByDescending(g => g.AggregatedRating);
            return Games;
        }
        public IQueryable<Game> GetReviewedToday(int i)
        {
            Games = _context.Game.Take(i).Where(g => g.ReleaseDate.Date.Year == DateTime.Now.Year && g.ReleaseDate.Month == DateTime.Now.Year && g.ReleaseDate.Day == DateTime.Now.Day);
            return Games;
        }
        public async Task OnGetAsync()
        {
            var game = from g in _context.Game
                       select g;
            if (!string.IsNullOrEmpty(SearchString))
            {
                game = game.Where(s => s.Title.Equals(SearchString)).OrderByDescending(s => s.AggregatedRating);
            }
            ListGames = await game.ToListAsync();
        }
        //public async Task OnGetAsync(int? id)
        //{



        //    Game = await _context.Game.ToListAsync();

        //}

    }
}
