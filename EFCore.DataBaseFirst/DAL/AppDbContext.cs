﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataBaseFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}
