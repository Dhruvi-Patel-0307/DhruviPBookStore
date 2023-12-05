﻿using DhruviPBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviPBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public object Category { get; internal set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public object CoverType { get; internal set; }
        public DbSet<Product> Products { get; set; }

    }
}