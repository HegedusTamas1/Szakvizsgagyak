using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MyWorldDbContext : DbContext
    {
        public class SQL : DbContext
        {
            public SQL()
            {
            }

            public SQL(DbContextOptions<MyWorldDbContext> options) : base(options)
            {
            }
            public DbSet<logentries> LogEntries { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=logprocessor;User=root;Password=;",
                    new MySqlServerVersion(new Version(8, 0, 30)));
            }
        }
    }
}