using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Models.Repository
{
    public class PaymentDataRepo : IPaymentDataRepo<Payment>
    {
        private readonly PaymentDbContext _paymentContext;

        public PaymentDataRepo(PaymentDbContext context)
        {
            _paymentContext = context;
        }
        public IEnumerable<Payment> GetAll()
        {
            return _paymentContext.Payments.ToList().OrderByDescending(p => p.CreatedOn);
        }
        public async Task AddAsync(Payment payment)
        {
            await _paymentContext.Payments.AddAsync(payment);
            await _paymentContext.SaveChangesAsync();
        }

        public void Delete(Payment payment)
        {
            _paymentContext.Payments.Remove(payment);
            _paymentContext.SaveChanges();
        }

        public Payment GetById(long id)
        {
            return _paymentContext.Payments.FirstOrDefault(p => p.PaymentId == id);
        }
    }
}
