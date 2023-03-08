using System;
using YbadgesAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace YbadgesAPI.Data
{
    public class ArchiDB : DbContext
    {
        public ArchiDB(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<YbadgesAPI.Models.Badge>? Badge { get; set; }

        public DbSet<YbadgesAPI.Models.Obtenu>? Obtenu { get; set; }

    }
}
