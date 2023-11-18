using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Patisserie.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Infrastructure.Configurations
{
    internal class OrderItemconfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public const string DEFAULT_SCHEMA = "ordering";
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems", DEFAULT_SCHEMA);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
        }
    }
}
