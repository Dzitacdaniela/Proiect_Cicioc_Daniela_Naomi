﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Cicioc_Daniela_Naomi.Data;

#nullable disable

namespace Proiect_Cicioc_Daniela_Naomi.Migrations
{
    [DbContext(typeof(Proiect_Cicioc_Daniela_NaomiContext))]
    [Migration("20240117172237_Migrare4")]
    partial class Migrare4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Analiza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Denumire_Analiza")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("LaborantID")
                        .HasColumnType("int");

                    b.Property<int>("Pret_Analiza")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LaborantID");

                    b.ToTable("Analiza");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.AnalizaClient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnalizaID")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnalizaID");

                    b.HasIndex("ClientID");

                    b.ToTable("AnalizaClient");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AnalizeID")
                        .HasColumnType("int");

                    b.Property<string>("EMail_Client")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("LaboratorID")
                        .HasColumnType("int");

                    b.Property<string>("Nume_Client")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("AnalizeID");

                    b.HasIndex("LaboratorID")
                        .IsUnique()
                        .HasFilter("[LaboratorID] IS NOT NULL");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Laborant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("LaboratorID")
                        .HasColumnType("int");

                    b.Property<string>("Nume_Laborant")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Salar_Laborant")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LaboratorID")
                        .IsUnique()
                        .HasFilter("[LaboratorID] IS NOT NULL");

                    b.ToTable("Laborant");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Laborator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adresa_Laborator")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Denumire_Laborator")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Laborator");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Analiza", b =>
                {
                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Laborant", "Laboranti")
                        .WithMany("Analize")
                        .HasForeignKey("LaborantID");

                    b.Navigation("Laboranti");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.AnalizaClient", b =>
                {
                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Analiza", "Analize")
                        .WithMany("AnalizaClient")
                        .HasForeignKey("AnalizaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Client", "Clienti")
                        .WithMany("AnalizaClient")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Analize");

                    b.Navigation("Clienti");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Client", b =>
                {
                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Analiza", "Analize")
                        .WithMany()
                        .HasForeignKey("AnalizeID");

                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Laborator", "Laboratoare")
                        .WithOne("Clienti")
                        .HasForeignKey("Proiect_Cicioc_Daniela_Naomi.Models.Client", "LaboratorID");

                    b.Navigation("Analize");

                    b.Navigation("Laboratoare");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Laborant", b =>
                {
                    b.HasOne("Proiect_Cicioc_Daniela_Naomi.Models.Laborator", "Laboratoare")
                        .WithOne("Laboranti")
                        .HasForeignKey("Proiect_Cicioc_Daniela_Naomi.Models.Laborant", "LaboratorID");

                    b.Navigation("Laboratoare");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Analiza", b =>
                {
                    b.Navigation("AnalizaClient");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Client", b =>
                {
                    b.Navigation("AnalizaClient");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Laborant", b =>
                {
                    b.Navigation("Analize");
                });

            modelBuilder.Entity("Proiect_Cicioc_Daniela_Naomi.Models.Laborator", b =>
                {
                    b.Navigation("Clienti");

                    b.Navigation("Laboranti");
                });
#pragma warning restore 612, 618
        }
    }
}