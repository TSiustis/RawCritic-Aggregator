using Microsoft.AspNetCore.Mvc.RazorPages;
using RawCritic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Services
{
    public abstract class PageModelService : PageModel
    {
        protected abstract Task<List<Game>> GetCategoryAsync(string platform, string searchString);
    }
}
