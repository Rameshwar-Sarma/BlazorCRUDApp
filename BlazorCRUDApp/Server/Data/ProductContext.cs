﻿using BlazorCRUDApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDApp.Server.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
