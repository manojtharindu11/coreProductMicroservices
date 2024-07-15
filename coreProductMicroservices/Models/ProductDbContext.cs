﻿using Microsoft.EntityFrameworkCore;

namespace coreProductMicroservices.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
