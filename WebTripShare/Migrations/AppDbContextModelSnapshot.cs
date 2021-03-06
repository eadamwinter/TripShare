﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTripShare.Models;

namespace WebTripShare.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TripShare.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamesOfMembersInvolved")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("NumberOfMembersInvolved")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TableNumber")
                        .HasColumnType("tinyint");

                    b.Property<string>("TimeOfExpense")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("TripShare.MembersInfo", b =>
                {
                    b.Property<byte>("MembersInfoId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("TableInfoId")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TableNumber")
                        .HasColumnType("tinyint");

                    b.HasKey("MembersInfoId");

                    b.HasIndex("TableInfoId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("TripShare.TableInfo", b =>
                {
                    b.Property<byte>("TableInfoId")
                        .HasColumnType("tinyint");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TableInfoId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("TripShare.MembersInfo", b =>
                {
                    b.HasOne("TripShare.TableInfo", null)
                        .WithMany("Members")
                        .HasForeignKey("TableInfoId");
                });

            modelBuilder.Entity("TripShare.TableInfo", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
