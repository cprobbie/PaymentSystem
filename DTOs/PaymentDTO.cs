using PaymentSystem.Models.Enums;

namespace PaymentSystem.DTOs
{
    public class PaymentDTO
    {
        public decimal Amount { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal ProcessingFee => CalculateFees();
        public decimal SettlementAmount => Amount - ProcessingFee;
        private decimal CalculateFees()
        {
            switch (PaymentType)
            {
                case PaymentType.Bronze:
                    return 1.25m;
                case PaymentType.Silver:
                    return (decimal)((double)Amount * 0.002);
                case PaymentType.Gold:
                    return 0;
                default:
                    return 1.25m;
            }
        }
    }
}
