using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.Models;

namespace Tourism.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base (options) { }
        public DbSet<Region> Region { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
