﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp1MvcCrud.Data;

#nullable disable

namespace WebApp1MvcCrud.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20230608173011_columnNamesUpdate")]
    partial class columnNamesUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp1MvcCrud.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d0176b50-d177-4be2-97d9-565dc9f3b2a3"),
                            Age = (short)18,
                            FirstName = "Patricia",
                            Grade = 3.1f,
                            LastName = "White",
                            RegDate = new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2917)
                        },
                        new
                        {
                            Id = new Guid("aad3ff5a-82e3-457d-a2eb-0d94ce9019d8"),
                            Age = (short)21,
                            FirstName = "Alejandra",
                            Grade = 2.85f,
                            LastName = "Ferguson",
                            RegDate = new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2961)
                        },
                        new
                        {
                            Id = new Guid("06b8f4cf-bef7-4152-bc78-b78f97c74e09"),
                            Age = (short)22,
                            FirstName = "Bonnie",
                            Grade = 2.31f,
                            LastName = "Kingsley",
                            RegDate = new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2966)
                        },
                        new
                        {
                            Id = new Guid("81a0fe29-be21-411d-a4c4-b0dd503fbdd4"),
                            Age = (short)17,
                            FirstName = "Michelle",
                            Grade = 3.22f,
                            LastName = "Pate",
                            RegDate = new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2969)
                        },
                        new
                        {
                            Id = new Guid("4106915c-e7f3-4b93-955f-f740e406bc96"),
                            Age = (short)24,
                            FirstName = "Shirley ",
                            Grade = 3.38f,
                            LastName = "Krug",
                            RegDate = new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2984)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}