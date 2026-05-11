using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Entites;
using ViteCare.Infrastructure.Identity;

namespace ViteCare.Infrastructure.Presistence.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.UserId);
            builder.Property(d => d.Title).HasMaxLength(60);
            builder.Property(d => d.ConsultationFee).HasColumnType("decimal(18,2)");
            builder.Property(d => d.Address).HasMaxLength(60);
            builder.Property(d => d.Specialization).HasMaxLength(60).IsRequired();

           builder.HasOne<ApplicationUser>()
                .WithOne()
                .HasForeignKey<Doctor>(d=>d.UserId)
                .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
