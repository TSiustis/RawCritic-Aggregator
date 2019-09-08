using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RawCritic2.Models;

namespace RawCritic2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RawCritic2.Models.Game> Game { get; set; }        //public DbSet<RawCritic2.Models.Genre> Genre{ get; set; }
        //public DbSet<RawCritic2.Models.Platform> Platform { get; set; }
        public DbSet<RawCritic2.Models.GameJSON> GameJSON { get; set; }
    }
}
