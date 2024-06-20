using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestKT.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TestKT.Models.Test> Test { get; set; } = default!;

        public DbSet<TestKT.Models.People> People { get; set; } = default!;

        public DbSet<TestKT.Models.Linh> Linh { get; set; } = default!;
    }
