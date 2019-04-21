using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Models;
using PaymentSystem.Models.Repository;

namespace PaymentSystem.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentApiController : ControllerBase
    {
        private readonly IPaymentDataRepo<Payment> _paymentDataRepo;

        public PaymentApiController(IPaymentDataRepo<Payment> paymentDataRepo)
        {
            _paymentDataRepo = paymentDataRepo;
        }
        [HttpGet]
        public IActionResult ListPayments()
        {
            IEnumerable<Payment> payments = _paymentDataRepo.GetAll();
            return Ok(payments);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(long id)
        {
            Payment payment = _paymentDataRepo.GetById(id);
            if (payment == null)
            {
                return NotFound($"Payment {id} could not be found");
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult AddPayment([FromBody] Payment payment)
        {
            if (payment == null)
            {
                return BadRequest("new payment data is required");
            }

            _paymentDataRepo.Add(payment);
            return CreatedAtRoute(
                "Get",
                new { Id = payment.PaymentId },
                payment);
        }

        [HttpDelete("{id}")]

        public IActionResult DeletePayment(long id)
        {
            Payment payment = _paymentDataRepo.GetById(id);
            if (payment == null)
            {
                return NotFound($"Payment {id} could not be found");
            }

            _paymentDataRepo.Delete(payment);
            return NoContent();
        }
    }
}
