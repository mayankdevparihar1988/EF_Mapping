using System;
using EFDbRelationshipsExamples.Entities;
using Microsoft.EntityFrameworkCore;
namespace EFDbRelationshipsExamples.DbContexts
{
	public class DbContextSqlServer : DbContext
	{
		
        public DbContextSqlServer(DbContextOptions<DbContextSqlServer> options) : base(options)
        {
        }

        public DbSet<Backpack> Backpacks { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Fraction> Fractions { get; set; }

        public DbSet<Weapon> Weapons { get; set; }
    }
}

