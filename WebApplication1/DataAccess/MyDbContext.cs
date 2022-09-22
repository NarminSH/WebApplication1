using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
Console.WriteLine("here");
namespace WebApplication1.DataAccess
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPhoto> Photos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=Product;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
