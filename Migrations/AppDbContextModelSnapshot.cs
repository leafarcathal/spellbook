﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spellbook.Data;

namespace Spellbook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Spellbook.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Cancelled_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Due_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("Uuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Spellbook.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardBin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardEnding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("Spellbook.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Spellbook.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("User_group_id")
                        .HasColumnType("int");

                    b.Property<string>("Uuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Spellbook.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserGroup");
                });
#pragma warning restore 612, 618
        }
    }
}