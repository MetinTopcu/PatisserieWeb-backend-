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
    internal class OrderConfiguration : IEntityTypeConfiguration<Domain.OrderAggregate.Order>
    {
        public const string DEFAULT_SCHEMA = "ordering";

        public void Configure(EntityTypeBuilder<Domain.OrderAggregate.Order> builder)
        {
            builder.ToTable("Orders",DEFAULT_SCHEMA);
            builder.OwnsOne(o => o.Address).WithOwner();
        }
    }
}
