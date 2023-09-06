using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projects.Models;

namespace Projects.Data
{
    public class ProjectsDbContext : DbContext
    {
        public ProjectsDbContext (DbContextOptions<ProjectsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Projects.Models.Laptop> Laptop { get; set; } = default!;
    }
}
