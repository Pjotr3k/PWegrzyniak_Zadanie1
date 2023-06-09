﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PWęgrzyniak_Zadanie1.Data;

#nullable disable

namespace PWęgrzyniak_Zadanie1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.Narzedzie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Narzedzias");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.NarzedzieUzycie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NarzedzieId")
                        .HasColumnType("int");

                    b.Property<int>("ZmianaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NarzedzieId");

                    b.HasIndex("ZmianaId");

                    b.ToTable("NarzedzieUzycies");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produkts");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.ProduktZmiana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataWprowadzenie")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpisZmiana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProduktId");

                    b.ToTable("ProduktZmianas");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.NarzedzieUzycie", b =>
                {
                    b.HasOne("PWęgrzyniak_Zadanie1.Models.Narzedzie", "Narzedzie")
                        .WithMany("NarzedzieUzycies")
                        .HasForeignKey("NarzedzieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PWęgrzyniak_Zadanie1.Models.ProduktZmiana", "Zmiana")
                        .WithMany("NarzedzieUzycies")
                        .HasForeignKey("ZmianaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Narzedzie");

                    b.Navigation("Zmiana");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.ProduktZmiana", b =>
                {
                    b.HasOne("PWęgrzyniak_Zadanie1.Models.Produkt", "Produkt")
                        .WithMany("ProduktZmianas")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.Narzedzie", b =>
                {
                    b.Navigation("NarzedzieUzycies");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.Produkt", b =>
                {
                    b.Navigation("ProduktZmianas");
                });

            modelBuilder.Entity("PWęgrzyniak_Zadanie1.Models.ProduktZmiana", b =>
                {
                    b.Navigation("NarzedzieUzycies");
                });
#pragma warning restore 612, 618
        }
    }
}
