﻿// <auto-generated />
using AppointmentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppointmentAPI.Migrations
{
    [DbContext(typeof(AppointmentDetailContext))]
    [Migration("20201230093507_UserCreated")]
    partial class UserCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AppointmentAPI.Models.AppointmentDetail", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PatientAge")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("PatientGender")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PatientNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SelectDate")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SelectDoctor")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.ToTable("AppointmentDetails");
                });

            modelBuilder.Entity("AppointmentAPI.Models.UserDetail", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("UserDetails");
                });
#pragma warning restore 612, 618
        }
    }
}