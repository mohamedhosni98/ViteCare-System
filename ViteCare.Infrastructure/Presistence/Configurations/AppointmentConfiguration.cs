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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a=>a.Patient)
                .WithMany(p=>p.Appointments)
                .HasForeignKey(a=>a.PatientId)
                .OnDelete(DeleteBehavior.Restrict); 


            builder.HasOne(a => a.Slot)
               .WithOne() // الـ Slot مش محتاج Navigation property للـ Appointment
               .HasForeignKey<Appointment>(a => a.SlotId)
               .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
