using GarderShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Hosting;

namespace GarderShop
{
    public class DBConnect:DbContext
    {
        public DBConnect(DbContextOptions<DBConnect> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }

    }
}
