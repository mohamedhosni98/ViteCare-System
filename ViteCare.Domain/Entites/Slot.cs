using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViteCare.Domain.Entites
{
    public class Slot
    {
        public int Id { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsReserved { get; set; }
        public Guid RowVersion { get; set; }

        public Doctor Doctor { get; set; }

    }
}
