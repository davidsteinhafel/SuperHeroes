using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroesProject.Models;

namespace SuperHeroesProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            DbSet<Hero> heroes;
        }
        public DbSet<SuperHeroesProject.Models.Hero> Heroes { get; set; }
    }
}
