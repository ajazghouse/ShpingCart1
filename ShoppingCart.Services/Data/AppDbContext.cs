using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Data
{
    class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
