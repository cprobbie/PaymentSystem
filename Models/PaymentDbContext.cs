using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Models
{
    public class PaymentDbContext : DbContext
    {
        public PaymentDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                PaymentId = 1,
                Amount = 1000m,
                CreatedOn = DateTime.Now.AddDays(-1),
                PaymentType = PaymentType.Bronze,
                SettlementAmount = 1000m - 1.25m
            }, new Payment
            {
                PaymentId = 2,
                Amount = 678m,
                CreatedOn = DateTime.Now.AddMonths(-1),
                PaymentType = PaymentType.Silver,
                SettlementAmount = (decimal)(678 - 678 * 0.002)
            });
        }
    }
}
