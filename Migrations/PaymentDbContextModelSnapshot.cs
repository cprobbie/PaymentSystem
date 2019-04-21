﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentSystem.Models;

namespace PaymentSystem.Migrations
{
    [DbContext(typeof(PaymentDbContext))]
    partial class PaymentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PaymentSystem.Models.Payment", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("PaymentType");

                    b.Property<decimal>("SettlementAmount");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1L,
                            Amount = 1000m,
                            CreatedOn = new DateTime(2019, 4, 20, 17, 21, 5, 116, DateTimeKind.Local).AddTicks(3866),
                            PaymentType = 1,
                            SettlementAmount = 998.75m
                        },
                        new
                        {
                            PaymentId = 2L,
                            Amount = 678m,
                            CreatedOn = new DateTime(2019, 3, 21, 17, 21, 5, 118, DateTimeKind.Local).AddTicks(6195),
                            PaymentType = 2,
                            SettlementAmount = 676.644m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
