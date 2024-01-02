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
    [Migration("20240102214320_authandwebuser")]
    partial class authandwebuser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrderWebUser", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("WebUsersId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId", "WebUsersId");

                    b.HasIndex("WebUsersId");

                    b.ToTable("OrderWebUser");
                });

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
                            AddDate = new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4674),
                            Address = "Kadıköy",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Bilge Berivan",
                            LastName = "Zincir"
                        },
                        new
                        {
                            Id = 2,
                            AddDate = new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4682),
                            Address = "Beyoğlu",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Aykut",
                            LastName = "Karakuzu"
                        },
                        new
                        {
                            Id = 3,
                            AddDate = new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4684),
                            Address = "Kadıköy",
                            BirthDate = new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "İstanbul",
                            FirstName = "Derin ",
                            LastName = "Çağdaş"
                        });
                });

            modelBuilder.Entity("TechCareer.Models.ORM.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TechCareer.Models.ORM.WebUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebUsers");
                });

            modelBuilder.Entity("OrderWebUser", b =>
                {
                    b.HasOne("TechCareer.Models.ORM.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechCareer.Models.ORM.WebUser", null)
                        .WithMany()
                        .HasForeignKey("WebUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}