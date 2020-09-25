using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorMSDNTest.Data
{
    public class RazorMSDNTestArtsDbContext : DbContext
    {
        public RazorMSDNTestArtsDbContext (DbContextOptions<RazorMSDNTestArtsDbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMSDNTest.Data.RazorMSDNTestArt> RazorMSDNTestArt { get; set; }
    }
}
