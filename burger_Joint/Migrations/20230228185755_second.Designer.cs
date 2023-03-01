﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace burger_Joint.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230228185755_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("OrderPayment", b =>
                {
                    b.Property<int>("OrdersOrder_Id")
                        .HasColumnType("int");

                    b.Property<int>("PaymentsPayment_Id")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrder_Id", "PaymentsPayment_Id");

                    b.HasIndex("PaymentsPayment_Id");

                    b.ToTable("OrderPayment");
                });

            modelBuilder.Entity("burger_Joint.Models.Administrator", b =>
                {
                    b.Property<int>("Administrator_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Administrator_ID");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("burger_Joint.Models.Customer", b =>
                {
                    b.Property<int>("Cus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Phone_num")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("district")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Cus_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("burger_Joint.Models.Employee", b =>
                {
                    b.Property<int>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Employee_ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("burger_Joint.Models.Order", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cus_Id")
                        .HasColumnType("int");

                    b.Property<int>("CustomerCus_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Total_amount")
                        .HasColumnType("int");

                    b.HasKey("Order_Id");

                    b.HasIndex("CustomerCus_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("burger_Joint.Models.Payment", b =>
                {
                    b.Property<int>("Payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("method")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Payment_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("burger_Joint.Models.Store", b =>
                {
                    b.Property<int>("Item_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Item_ID");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("OrderPayment", b =>
                {
                    b.HasOne("burger_Joint.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrder_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("burger_Joint.Models.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsPayment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("burger_Joint.Models.Order", b =>
                {
                    b.HasOne("burger_Joint.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerCus_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("burger_Joint.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}