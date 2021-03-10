﻿// <auto-generated />
using System;
using GRDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GRDL.Migrations
{
    [DbContext(typeof(GRDBContext))]
    [Migration("20210310035807_SeedDataTest")]
    partial class SeedDataTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GRModels.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("GRModels.CartProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("integer");

                    b.Property<int>("RecID")
                        .HasColumnType("integer");

                    b.Property<int>("RecQuan")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("GRModels.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GRModels.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LocID")
                        .HasColumnType("integer");

                    b.Property<int>("RecID")
                        .HasColumnType("integer");

                    b.Property<int>("RecQuan")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("GRModels.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("GRModels.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("integer");

                    b.Property<int>("CusID")
                        .HasColumnType("integer");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<int>("LocalID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OrDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GRModels.OrderProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("OrdID")
                        .HasColumnType("integer");

                    b.Property<int>("RecID")
                        .HasColumnType("integer");

                    b.Property<int>("RecQuan")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("GRModels.Record", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Artist")
                        .HasColumnType("text");

                    b.Property<int>("DaCondition")
                        .HasColumnType("integer");

                    b.Property<int>("DaFormat")
                        .HasColumnType("integer");

                    b.Property<int>("GenreType")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("RecordName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            ID = 1000,
                            Artist = "Noname",
                            DaCondition = 1,
                            DaFormat = 1,
                            GenreType = 1,
                            Price = 249.99m,
                            RecordName = "Telefone"
                        });
                });

            modelBuilder.Entity("GRModels.Order", b =>
                {
                    b.HasOne("GRModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
