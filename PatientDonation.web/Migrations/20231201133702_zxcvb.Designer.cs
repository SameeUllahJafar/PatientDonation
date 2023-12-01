﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientDonation.web.Models;

#nullable disable

namespace PatientDonation.web.Migrations
{
    [DbContext(typeof(PDContext))]
    [Migration("20231201133702_zxcvb")]
    partial class zxcvb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PatientDonation.web.Models.Authority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<int>("Username")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Donar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Donated_Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Needy_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Needy_Id");

                    b.ToTable("Donars");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Needy", b =>
                {
                    b.Property<int>("Needy_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Needy_Id"));

                    b.Property<string>("CNIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Donation_Demanded")
                        .HasColumnType("int");

                    b.Property<int>("Donation_Received")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Needy_Id");

                    b.ToTable("Needies");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Donar", b =>
                {
                    b.HasOne("PatientDonation.web.Models.Needy", "Needy")
                        .WithMany("Donars")
                        .HasForeignKey("Needy_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Needy");
                });

            modelBuilder.Entity("PatientDonation.web.Models.Needy", b =>
                {
                    b.Navigation("Donars");
                });
#pragma warning restore 612, 618
        }
    }
}
