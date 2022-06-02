using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DudnikAlex.Models;

namespace DudnikAlex.Data
{
    public class DudnikAlexContext : DbContext
    {
        public DudnikAlexContext (DbContextOptions<DudnikAlexContext> options)
            : base(options)
        {
        }

        public DbSet<DudnikAlex.Models.Movie>? Movie { get; set; }
    }
}
