using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.ID);
            //Builder utiliza o padrão FLUENT

            builder
           .Property(o => o.UserID)
           .IsRequired();

            builder
        .Property(o => o.PaymentOptionID)
        .IsRequired();

            builder
                .Property(o => o.InitialTime)
                .IsRequired();

            builder
           .Property(o => o.DeliverTime)
           .IsRequired();

            builder
           .Property(o => o.Address)
           .IsRequired();

            builder
           .Property(o => o.Status)
           .IsRequired()
           .HasMaxLength(50);

         
            builder
                .Property(o => o.PaymentOption)
                .IsRequired();
            
            builder
                .Property(o => o.OrderItems)
                .IsRequired();

    }
    }
}
