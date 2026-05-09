using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Enums;

namespace ViteCare.Domain.Entites
{
    public class Appointment
    {
        public int Id { get; set; }
        public Guid PatientId { get; set; }
        public int SlotId { get; set; }
        public AppointmentStatus Status { get; set; }
        public string PatientComplaint { get; set; }
        public string DoctorNotes { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Patient Patient { get; set; }
        public Slot Slot { get; set; }
        public Payment Payment { get; set; }
    }
}
