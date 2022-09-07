using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project2_32368984.Models;

namespace Project2_32368984.Data
{
    public class Project2_32368984Context : DbContext
    {
        public Project2_32368984Context (DbContextOptions<Project2_32368984Context> options)
            : base(options)
        {
        }

        public DbSet<Project2_32368984.Models.Device> Device { get; set; }

        public DbSet<Project2_32368984.Models.Zone> Zone { get; set; }
    }
}
