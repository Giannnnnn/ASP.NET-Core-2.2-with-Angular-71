using Domain.Value_Object;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.PostalCode);
            //Builder utiliza o padrão FLUENT

            builder
                .Property(a => a.Number)
                .IsRequired()
                     .HasMaxLength(5);
            builder
                .Property(a => a.State)
                .IsRequired()
        .HasMaxLength(50);
            builder
                .Property(a => a.Street)
                .IsRequired()
                         .HasMaxLength(1000);

        }
    }
}
