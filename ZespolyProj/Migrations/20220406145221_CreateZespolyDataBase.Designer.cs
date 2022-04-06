﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZespolyProj;

namespace ZespolyProj.Migrations
{
    [DbContext(typeof(ZespolContext))]
    [Migration("20220406145221_CreateZespolyDataBase")]
    partial class CreateZespolyDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZespolyProj.CzlonekZespolu", b =>
                {
                    b.Property<int>("CzlonekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataZapisu")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funkcja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plec")
                        .HasColumnType("int");

                    b.Property<int?>("ZespolId")
                        .HasColumnType("int");

                    b.HasKey("CzlonekId");

                    b.HasIndex("ZespolId");

                    b.ToTable("Czlonkowie");
                });

            modelBuilder.Entity("ZespolyProj.KierownikZespolu", b =>
                {
                    b.Property<int>("KierownikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("Doswiadczenie")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plec")
                        .HasColumnType("int");

                    b.Property<int>("ZespolId")
                        .HasColumnType("int");

                    b.HasKey("KierownikId");

                    b.HasIndex("ZespolId")
                        .IsUnique();

                    b.ToTable("Kierownik");
                });

            modelBuilder.Entity("ZespolyProj.Zespol", b =>
                {
                    b.Property<int>("ZespolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LiczbaCzlonkow")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZespolId");

                    b.ToTable("Zespoly");
                });

            modelBuilder.Entity("ZespolyProj.CzlonekZespolu", b =>
                {
                    b.HasOne("ZespolyProj.Zespol", "Zespol")
                        .WithMany("Czlonkowie")
                        .HasForeignKey("ZespolId");
                });

            modelBuilder.Entity("ZespolyProj.KierownikZespolu", b =>
                {
                    b.HasOne("ZespolyProj.Zespol", "Zespol")
                        .WithOne("Kierownik")
                        .HasForeignKey("ZespolyProj.KierownikZespolu", "ZespolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
