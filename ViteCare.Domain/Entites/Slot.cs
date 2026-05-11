using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViteCare.Domain.Entites
{
    public class Slot
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsReserved { get; set; }
        public string Name { get; set; }

        // public Guid RowVersion { get; set; }
        [Timestamp]
       public byte[] Rowversion { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Appointment Appointment { get; set; }

    }
}
