using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewBlazorTodo.Shared.Models;

namespace NewBlazorTodo.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Developer> Developers { get; set; }

        public DbSet<Admins> Admins { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Operators> Operators { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
