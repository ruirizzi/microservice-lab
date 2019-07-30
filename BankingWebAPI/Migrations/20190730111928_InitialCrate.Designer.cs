﻿// <auto-generated />
using System;
using BankingWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingWebAPI.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20190730111928_InitialCrate")]
    partial class InitialCrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankingWebAPI.Models.BankAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowsOverdraft");

                    b.Property<DateTime?>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Holder")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("HolderDocument")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<decimal?>("UpdatedPosition")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("BankingWebAPI.Models.Entry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CounterPart");

                    b.Property<DateTime>("OccurenceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CounterPart");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("BankingWebAPI.Models.Entry", b =>
                {
                    b.HasOne("BankingWebAPI.Models.BankAccount", "CounterPartNavigation")
                        .WithMany("Entry")
                        .HasForeignKey("CounterPart")
                        .HasConstraintName("FK__Entry__CounterPa__6FE99F9F");
                });
#pragma warning restore 612, 618
        }
    }
}