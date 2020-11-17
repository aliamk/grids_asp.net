using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grids.Models;
using Microsoft.EntityFrameworkCore;    // DbContext

namespace Grids.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Fund> Students { get; set; }       // set DbSet to the Model file name
    }
}
