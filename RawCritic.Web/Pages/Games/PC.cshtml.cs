﻿using System;
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
    public class PCModel : GamePageModelService
    {
       
        public IQueryable<Game> Games { get; set; }
        public PCModel(ApplicationDbContext context, IMemoryCache memoryCache) : base(context, memoryCache)
        {
            _context = context;
        }
        public IList<Game> Game { get; set; }

        public IEnumerable<Models.Game> Data { get; set; }
        public async Task OnGetAsync()
        {
            Data = await GetPaginatedResult(CurrentPage,"Microsoft Windows", PageSize);
            Game = await GetCategoryAsync("Microsoft Windows", SearchString);
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