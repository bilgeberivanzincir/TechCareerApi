﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechCareer.Models.ORM;

#nullable disable

namespace TechCareer.Migrations
{
    [DbContext(typeof(TechDbContext))]
    [Migration("20231226215407_addedSeedData")]
    partial class addedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TechCareer.Models.ORM.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddDate = new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7780),
                            Address = "Kadıköy",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Bilge Berivan",
                            LastName = "Zincir"
                        },
                        new
                        {
                            Id = 2,
                            AddDate = new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7794),
                            Address = "Beyoğlu",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Aykut",
                            LastName = "Karakuzu"
                        },
                        new
                        {
                            Id = 3,
                            AddDate = new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7797),
                            Address = "Kadıköy",
                            BirthDate = new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Derin ",
                            LastName = "Çağdaş"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
