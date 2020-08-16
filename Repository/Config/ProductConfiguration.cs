using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
   public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.ID);

            builder.Property(p => p.Avaliation).IsRequired();

            builder.Property(p => p.Name).IsRequired().IsRequired().HasMaxLength(50);

        }
    }
}
