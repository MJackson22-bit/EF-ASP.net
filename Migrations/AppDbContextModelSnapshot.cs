﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practica_2.Models;

namespace Practica_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Practica_2.Models.Noticias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Posteo")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("Practica_2.Models.Veterinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aplicabilidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DosisAdm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Formulacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageDetail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Indicaciones")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Presentacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Veterinarias");
                });

            modelBuilder.Entity("Practica_2.Models.Noticias", b =>
                {
                    b.HasOne("Practica_2.Models.Veterinaria", "Veterinaria")
                        .WithMany("Noticias")
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("Practica_2.Models.Veterinaria", b =>
                {
                    b.Navigation("Noticias");
                });
#pragma warning restore 612, 618
        }
    }
}
