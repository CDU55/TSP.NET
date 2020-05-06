using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Susan_Stefan_Claudiu_Rp.Models;

namespace Asp_Susan_Stefan_Claudiu_Rp.Data
{
    public class Asp_Susan_Stefan_Claudiu_RpContext : DbContext
    {
        public Asp_Susan_Stefan_Claudiu_RpContext (DbContextOptions<Asp_Susan_Stefan_Claudiu_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Susan_Stefan_Claudiu_Rp.Models.Movie> Movie { get; set; }
    }
}
