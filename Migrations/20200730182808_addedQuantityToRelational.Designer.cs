﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestorantManagement.Models;

namespace RestorantManagement.Migrations
{
    [DbContext(typeof(RestorantManagementDbContext))]
    [Migration("20200730182808_addedQuantityToRelational")]
    partial class addedQuantityToRelational
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestorantManagement.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RestorantManagement.Models.ProductReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("ReceiptId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("ProductReceipts");
                });

            modelBuilder.Entity("RestorantManagement.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateClosed");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("TableId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("RestorantManagement.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsTaken");

                    b.Property<string>("TableName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestorantManagement.Models.ProductReceipt", b =>
                {
                    b.HasOne("RestorantManagement.Models.Product", "Product")
                        .WithMany("ProductReceipts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RestorantManagement.Models.Receipt", "Receipt")
                        .WithMany("ProductReceipts")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RestorantManagement.Models.Receipt", b =>
                {
                    b.HasOne("RestorantManagement.Models.Table", "Table")
                        .WithMany("Receipts")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
