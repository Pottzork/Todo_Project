using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTodo.Data
{
    public class TheDbContext : TheDbContext
    {

        public TheDbContext(DbContextOptions<TheDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }






    }
}
