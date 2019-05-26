using PaymentSystem.Models.Enums;
using System;

namespace PaymentSystem.DTOs
{
    public class PaymentViewDTO
    {
        public long PaymentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public decimal ProcessingFees { get; set; }
        public decimal SettlementAmount { get; set; }
    }
}
