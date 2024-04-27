using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TIX_API.Models;

namespace TIX_API.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } = default!;
        public DbSet<OutputUser> OutputUsers { get; set; } = default!;
    }
}
