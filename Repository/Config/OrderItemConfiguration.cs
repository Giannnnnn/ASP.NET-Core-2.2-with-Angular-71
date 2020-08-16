using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.ID);
            //Builder utiliza o padrão FLUENT

            builder
                .Property(oi => oi.ProductID)
                .IsRequired();

            builder
                .Property(oi => oi.Quantity)
                .IsRequired();
           
        }
    }
}
