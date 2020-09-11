using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApiTodo.Data;
using DataAccess.Models;

namespace WebApiTodo.Data
{
    public class TheDbContext : DbContext
    {
        public TheDbContext(DbContextOptions<TheDbContext> options) : base(options) { }

        public DbSet<Address> Addresss { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Operator> Operators { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistorys { get; set; }


        



        public DbContextOptions<TheDbContext> Options { get; }
    }
}
