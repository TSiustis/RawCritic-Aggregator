using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using RawCritic.Web.Data;
using RawCritic.Web.Services;

namespace RawCritic.Web.Pages
{
    public class ContactModel : GamePageModelService
    {
        public string Message { get; set; }
        public ContactModel(ApplicationDbContext context, IMemoryCache memoryCache) : base(context, memoryCache)
        {
            _context = context;
        }
        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}
