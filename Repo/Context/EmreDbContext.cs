using Microsoft.EntityFrameworkCore;
using Repo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Context
{
    public class EmreDbContext : DbContext
    {
        public EmreDbContext(DbContextOptions<EmreDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
