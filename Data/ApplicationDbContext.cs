using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLeagueDashboard.Models;
using MyLeagueDashboard.Models.DB;

namespace MyLeagueDashboard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Summoner> Summoners { get; set; }
        public DbSet<MatchDB> Matches { get; set; }

        // Will add DB stuff once I get all the APIs working correctly
    }
}
