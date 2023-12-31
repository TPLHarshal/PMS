﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS.Data;

#nullable disable

namespace PMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230803065426_migrate")]
    partial class migrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PMS.Models.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("End_Time_Plan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Project_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Project_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Reasons")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Start_Time_Plan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("PMS.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
