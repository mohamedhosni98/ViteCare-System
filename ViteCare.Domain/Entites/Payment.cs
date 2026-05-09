using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Domain.Enums;

namespace ViteCare.Domain.Entites
{
    public class Payment
    {
        public Guid Id { get; set; }
        public int AppointmentId { get; set; }
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; }
        public string ProviderResponse { get; set; }
        public DateTime CreatedAt { get; set; }

        public Appointment Appointment { get; set; }

    }
}
