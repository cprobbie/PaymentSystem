using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PaymentId { get; set; }
        [Required(ErrorMessage ="Payment amount is required")]
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required(ErrorMessage ="Payment type is required")]
        public PaymentType PaymentType { get; set; }
        public double ProcessingFees => CalculateFees();
        public decimal SettlementAmount { get; set; }

        private double CalculateFees()
        {
            switch (PaymentType)
            {
                case PaymentType.Bronze:
                    return 1.25;
                case PaymentType.Silver:
                    return (double)Amount * 0.2;
                case PaymentType.Gold:
                    return 0;
                default:
                    return 1.25;
            }
        }
    }
}
