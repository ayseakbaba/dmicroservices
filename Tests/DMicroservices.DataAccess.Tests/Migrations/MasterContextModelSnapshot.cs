﻿// <auto-generated />
using System;
using DMicroservices.DataAccess.Tests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DMicroservices.DataAccess.Tests.Migrations
{
    [DbContext(typeof(MasterContext))]
    partial class MasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Student", b =>
                {
                    b.HasBaseType("DMicroservices.DataAccess.Tests.Models.Person");

                    b.Property<long>("StudentNum")
                        .HasColumnType("bigint");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Teacher", b =>
                {
                    b.HasBaseType("DMicroservices.DataAccess.Tests.Models.Person");

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Person", b =>
                {
                    b.HasOne("DMicroservices.DataAccess.Tests.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Student", b =>
                {
                    b.HasOne("DMicroservices.DataAccess.Tests.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DMicroservices.DataAccess.Tests.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DMicroservices.DataAccess.Tests.Models.Teacher", b =>
                {
                    b.HasOne("DMicroservices.DataAccess.Tests.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DMicroservices.DataAccess.Tests.Models.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
