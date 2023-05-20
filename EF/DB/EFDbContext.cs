using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF.DB
{
    public class EFDbContext : DbContext
    {
                public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=EF; Truested_Connection=True; TrustServerCertificate =True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}