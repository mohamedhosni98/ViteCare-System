using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Entites;

namespace ViteCare.Infrastructure.Presistence.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Appointment)
            .WithOne(a => a.Payment)
            .HasForeignKey<Payment>(p => p.AppointmentId);

            builder.Property(p => p.Amount)
            .HasColumnType("decimal(18,2)");
        }
    }
}
