using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoCarePro;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoCarePro
{
    class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\User\Desktop\database.db");
        }
    }
}
