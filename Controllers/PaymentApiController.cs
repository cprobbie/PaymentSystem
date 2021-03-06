using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentSystem.DTOs;
using PaymentSystem.Models;
using PaymentSystem.Models.Enums;
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
            var vm = payments.Select(p => new PaymentViewDTO
            {
                PaymentId = p.PaymentId,
                CreatedOn = p.CreatedOn,
                PaymentType = Enum.GetName(typeof(PaymentType), p.PaymentType),
                Amount = p.Amount,
                ProcessingFees = p.ProcessingFees,
                SettlementAmount = p.SettlementAmount
            });

            return Ok(vm);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(long id)
        {
            Payment payment = _paymentDataRepo.GetById(id);
            if (payment == null)
            {
                return NotFound($"Payment {id} could not be found");
            }

            return Ok(payment);
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDTO payment)
        {
            if (payment == null)
            {
                return BadRequest("new payment data is required");
            }

            if (payment.Amount < 1)
            {
                return BadRequest("minimum payment is $1");
            }
            try
            {
                var dataModel = new Payment()
                {
                    Amount = payment.Amount,
                    CreatedOn = DateTime.Now,
                    PaymentType = payment.PaymentType,
                    ProcessingFees = payment.ProcessingFee,
                    SettlementAmount = payment.SettlementAmount
                };
                await _paymentDataRepo.AddAsync(dataModel);
                return Ok("Payment successfully added");
            }
            catch(DbUpdateException ex)
            {
                throw new Exception("Error while adding payment", ex);
            }
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
            return Ok($"Payment {id} deleted successfully.");
        }
    }
}
