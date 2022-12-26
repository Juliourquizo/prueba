﻿// <auto-generated />
using System;
using FACTURA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FACTURA.Migrations
{
    [DbContext(typeof(FacturaContext))]
    [Migration("20221214082449_Add-IdHojaFactura")]
    partial class AddIdHojaFactura
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FACTURA.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("FACTURA.Models.HojaFactura", b =>
                {
                    b.Property<int>("IdHojaFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHojaFactura"));

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdHojaFactura");

                    b.HasIndex("IdCliente");

                    b.ToTable("HojaFactura");
                });

            modelBuilder.Entity("FACTURA.Models.Linea", b =>
                {
                    b.Property<int>("IdLinea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLinea"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Concepto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHojaFactura")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("IdLinea");

                    b.HasIndex("IdHojaFactura");

                    b.ToTable("Linea");
                });

            modelBuilder.Entity("FACTURA.Models.HojaFactura", b =>
                {
                    b.HasOne("FACTURA.Models.Cliente", "Cliente")
                        .WithMany("HojaFacturas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("FACTURA.Models.Linea", b =>
                {
                    b.HasOne("FACTURA.Models.HojaFactura", "HojaFactura")
                        .WithMany("Lineas")
                        .HasForeignKey("IdHojaFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HojaFactura");
                });

            modelBuilder.Entity("FACTURA.Models.Cliente", b =>
                {
                    b.Navigation("HojaFacturas");
                });

            modelBuilder.Entity("FACTURA.Models.HojaFactura", b =>
                {
                    b.Navigation("Lineas");
                });
#pragma warning restore 612, 618
        }
    }
}
