using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeCademyCapstone.Models;

namespace CodeCademyCapstone.Data
{
    public class CodeCademyCapstoneContext : DbContext
    {
        public CodeCademyCapstoneContext (DbContextOptions<CodeCademyCapstoneContext> options)
            : base(options)
        {
        }

        public DbSet<CodeCademyCapstone.Models.Book> Book { get; set; }
        public DbSet<CodeCademyCapstone.Models.League> Leagues { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodeCademyCapstone.Models.League>().ToTable("League");
            modelBuilder.Entity<Conference>().ToTable("Conference");
            modelBuilder.Entity<Division>().ToTable("Division");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Player>().ToTable("Player");
        }
    }
}
