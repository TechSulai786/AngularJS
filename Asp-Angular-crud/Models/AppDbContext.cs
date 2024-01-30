﻿using Microsoft.EntityFrameworkCore;

namespace Asp_Angular_crud.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
