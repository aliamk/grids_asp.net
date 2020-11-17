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
        internal object FundName;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Fund> Funds { get; set; }       // set DbSet to the Model file name
    }
}
