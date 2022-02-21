using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apocalypse.Models
{
    public class ApocalyseDbContext : DbContext
    {
        public ApocalyseDbContext(DbContextOptions<ApocalyseDbContext> options)
         : base(options)
        {

        }
        public DbSet<Survivor> survivors { get; set; }
        public DbSet<Robots> robots { get; set; }
        
    }

}
