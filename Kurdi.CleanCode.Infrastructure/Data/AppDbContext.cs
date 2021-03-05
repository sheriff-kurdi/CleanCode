﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Kurdi.CleanCode.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Kurdi.CleanCode.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite("Data Source=blogging.db");
        public DbSet<Employee> employees { get; set; }
    }
}