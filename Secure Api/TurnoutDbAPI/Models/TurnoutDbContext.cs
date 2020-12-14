using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnoutDbAPI.Models
{
    public class TurnoutDbContext : DbContext
    {
        public TurnoutDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Turnout> Turnouts { get; set; }
    }
}
