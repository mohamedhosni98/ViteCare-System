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
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p=>p.UserId);
            builder.HasOne<ApplicationUser>()
                .WithOne()
                .HasForeignKey<Patient>(p=>p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.EmergencyContact)
              .HasMaxLength(20);
            builder.Property(p => p.BloodGroup)
                .HasMaxLength(5);

        }
    }
}
