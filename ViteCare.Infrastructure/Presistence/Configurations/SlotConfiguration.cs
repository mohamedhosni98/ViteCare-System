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
    public class SlotConfiguration : IEntityTypeConfiguration<Slot>
    {
        public void Configure(EntityTypeBuilder<Slot> builder)
        {
            builder.HasKey(s=>s.Id);

            builder.HasOne(s=>s.Doctor)
                .WithMany(d=>d.Slots)
                .HasForeignKey(s=>s.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.Rowversion).IsRowVersion();
            

        }
    }
}
