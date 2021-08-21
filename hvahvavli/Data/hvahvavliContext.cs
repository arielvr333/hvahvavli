using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using havhavli.Models;
using hvahvavli.Models;

namespace hvahvavli.Data
{
    public class hvahvavliContext : DbContext
    {
        public hvahvavliContext (DbContextOptions<hvahvavliContext> options)
            : base(options)
        {
        }

        public DbSet<havhavli.Models.Product> Product { get; set; }

        public DbSet<hvahvavli.Models.Category> Category { get; set; }

        public DbSet<hvahvavli.Models.User> User { get; set; }
    }
}
