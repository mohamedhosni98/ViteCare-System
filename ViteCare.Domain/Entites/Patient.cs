using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Enums;

namespace ViteCare.Domain.Entites
{
    public class Patient
    {
        public Guid UserId { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string BloodGroup { get; set; }
        public string EmergencyContact { get; set; }
        public string MedicalHistory { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
