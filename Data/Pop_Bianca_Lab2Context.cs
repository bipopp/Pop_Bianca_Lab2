﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Bianca_Lab2.Models;

namespace Pop_Bianca_Lab2.Data
{
    public class Pop_Bianca_Lab2Context : DbContext
    {
        public Pop_Bianca_Lab2Context (DbContextOptions<Pop_Bianca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Bianca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Pop_Bianca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Pop_Bianca_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
