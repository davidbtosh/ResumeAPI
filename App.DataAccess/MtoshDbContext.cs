using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataAccess
{
    public class MtoshDbContext : DbContext
    {
        public DbSet<Job> Jobs {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"tcp:mtosh.database.windows.net,1433;Initial Catalog=mtosh_resume_db;Persist Security Info=False;User ID=davidbtosh;Password=R1ch0M@n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
