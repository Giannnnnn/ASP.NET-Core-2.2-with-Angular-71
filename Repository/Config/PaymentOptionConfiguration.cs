using Domain.Value_Object;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class PaymentOptionConfiguration : IEntityTypeConfiguration<PaymentOption>
    {
        public void Configure(EntityTypeBuilder<PaymentOption> builder)
        {
            builder.HasKey(po => po.ID);
            //Builder utiliza o padrão FLUENT

            builder
                .Property(po => po.Name)
                .IsRequired();
            
            builder
                .Property(po => po.Description)
                .IsRequired();
            
            builder
                .Property(po => po._PaymentTimeEnum)
                .IsRequired();
            
          
        }
    }
}
