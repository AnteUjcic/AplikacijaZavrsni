﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServisAplikacija.Data;

#nullable disable

namespace AplikacijaZavrsni2.Migrations
{
    [DbContext(typeof(MechanicContext))]
    [Migration("20240204232748_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ServisAplikacija.Models.LoginInfo", b =>
                {
                    b.Property<long>("OIB")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IDLogin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OIB", "IDLogin");

                    b.HasIndex("OIB")
                        .IsUnique();

                    b.ToTable("LoginInfos");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Service", b =>
                {
                    b.Property<long>("OIB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDVehicle")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DateOfservice")
                        .HasColumnType("TEXT");

                    b.Property<double>("KMService")
                        .HasColumnType("REAL");

                    b.Property<double>("NextKMService")
                        .HasColumnType("REAL");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OIB", "IDVehicle");

                    b.HasIndex("IDVehicle");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Vehicle", b =>
                {
                    b.Property<int>("IDVehicle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BodyStyle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DriveType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfDoors")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfWheels")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDVehicle");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Worker", b =>
                {
                    b.Property<long>("OIB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkerSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OIB");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("ServisAplikacija.Models.LoginInfo", b =>
                {
                    b.HasOne("ServisAplikacija.Models.Worker", "Worker")
                        .WithOne("LoginInfo")
                        .HasForeignKey("ServisAplikacija.Models.LoginInfo", "OIB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Service", b =>
                {
                    b.HasOne("ServisAplikacija.Models.Vehicle", "Vehicle")
                        .WithMany("Services")
                        .HasForeignKey("IDVehicle")
                        .IsRequired();

                    b.HasOne("ServisAplikacija.Models.Worker", "Worker")
                        .WithMany("Services")
                        .HasForeignKey("OIB")
                        .IsRequired();

                    b.Navigation("Vehicle");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Vehicle", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("ServisAplikacija.Models.Worker", b =>
                {
                    b.Navigation("LoginInfo")
                        .IsRequired();

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
