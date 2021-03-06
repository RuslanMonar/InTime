using InTime.Infrastructure;
using InTime.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace InTime.Data
{
    public class TrelloCloneDbContext :
        IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {

        public TrelloCloneDbContext(DbContextOptions<TrelloCloneDbContext> options)
              : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Column> Columns { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
