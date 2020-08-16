using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            //Builder utiliza o padrão FLUENT

            builder
                .Property(u => u.Name)
                .IsRequired()
                  .HasMaxLength(50);

            builder
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(500);

          
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(u => u.Orders)
                .WithOne(p => p.User);
             


        }
    }
}
