﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2106_Project.Data;

namespace _2106_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220215160611_Guest Creation")]
    partial class GuestCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("_2106_Project.Models.Guest", b =>
                {
                    b.Property<Guid>("account_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("account_id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("_2106_Project.Models.Hotel", b =>
                {
                    b.Property<Guid>("hotel_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("HotelName")
                        .HasColumnType("TEXT");

                    b.HasKey("hotel_id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("_2106_Project.Models.Staff", b =>
                {
                    b.Property<Guid>("account_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<int>("hotel_id")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("hotel_id1")
                        .HasColumnType("TEXT");

                    b.HasKey("account_id");

                    b.HasIndex("hotel_id1");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("_2106_Project.Models.Staff", b =>
                {
                    b.HasOne("_2106_Project.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("hotel_id1");

                    b.Navigation("Hotel");
                });
#pragma warning restore 612, 618
        }
    }
}
