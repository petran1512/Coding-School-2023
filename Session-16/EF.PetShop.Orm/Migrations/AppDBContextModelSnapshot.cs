﻿// <auto-generated />
using System;
using EF.Course.Orm.AppDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.Petshop.Orm.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary1.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("TIN")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("ClassLibrary1.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmpType")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("SalaryPerMonth")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("ClassLibrary1.Pet", b =>
                {
                    b.Property<Guid?>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animaltype")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("Bought")
                        .HasMaxLength(25)
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Cost")
                        .HasPrecision(5, 5)
                        .HasColumnType("decimal(5,5)");

                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Petstatus")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 5)
                        .HasColumnType("decimal(5,5)");

                    b.HasKey("TransactionID");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("ClassLibrary1.PetFood", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animaltype")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(5, 5)
                        .HasColumnType("decimal(5,5)");

                    b.Property<decimal?>("CurrentStock")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 5)
                        .HasColumnType("decimal(5,5)");

                    b.Property<decimal?>("Qty")
                        .HasPrecision(5, 5)
                        .HasColumnType("decimal(5,5)");

                    b.HasKey("ID");

                    b.ToTable("PetFood", (string)null);
                });

            modelBuilder.Entity("ClassLibrary1.PetFoodTransaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("PetFoodTransaction");
                });

            modelBuilder.Entity("ClassLibrary1.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(15)
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PetFoodID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PetFoodPrice")
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("PetFoodQty")
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<Guid?>("PetID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PetPrice")
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("TotalPrice")
                        .HasPrecision(5)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ID");

                    b.ToTable("Transaction", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
