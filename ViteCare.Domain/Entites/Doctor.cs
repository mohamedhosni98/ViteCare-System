using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Enums;

namespace ViteCare.Domain.Entites
{
    public class Doctor
    {
        public Guid UserId { get; set; }
        public string Specialization { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public int YearsOfExperience { get; set; }
        public decimal ConsultationFee { get; set; }
        public string Address { get; set; }

        public ICollection<Slot> Slots { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
