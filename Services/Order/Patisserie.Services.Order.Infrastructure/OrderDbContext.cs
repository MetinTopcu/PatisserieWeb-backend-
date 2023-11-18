using Microsoft.EntityFrameworkCore;
using Patisserie.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Infrastructure
{
    public class OrderDbContext:DbContext
    {

        //public const string DEFAULT_SCHEMA = "ordering";

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        public DbSet<Domain.OrderAggregate.Order> Orders { get; set; } //DB de Orders sütunu

        public DbSet<OrderItem> OrderItems { get; set; } //DB de OrderItems sütunu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // tüm configuration dosyalarını buluyor işliyor

            base.OnModelCreating(modelBuilder);
        }


    }
}
