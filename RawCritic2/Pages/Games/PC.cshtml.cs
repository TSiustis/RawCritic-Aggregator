﻿using System;
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
    public class PCModel : GamePageModelService
    {
        private readonly RawCritic2.Data.ApplicationDbContext _context;
        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }
        public PCModel(RawCritic2.Data.ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
       
        public IQueryable<Game> Games { get; set; }


        public IList<Game> Game { get; set; }

        public async Task OnGetAsync()
        {
            Game = await GetCategoryAsync("PC", SearchString);
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
