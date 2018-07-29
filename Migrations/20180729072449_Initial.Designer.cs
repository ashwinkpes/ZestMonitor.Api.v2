﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZestMonitor.Api.Data.Contexts;

namespace ZestMonitor.Api.Migrations
{
    [DbContext(typeof(ZestContext))]
    [Migration("20180729072449_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ZestMonitor.Api.Data.Entities.ProposalPayments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("ExpectedPayment");

                    b.Property<string>("Hash")
                        .IsRequired();

                    b.Property<string>("ShortDescription");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("ProposalPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
