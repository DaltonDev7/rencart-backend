﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rencart.Context;

namespace rencart.Migrations
{
    [DbContext(typeof(RencarDbContext))]
    partial class RencarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("rencart.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("LimiteCredito")
                        .HasColumnType("int");

                    b.Property<string>("NoTarjetaCR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("rencart.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PorcientoComision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TandaLabor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("rencart.Entities.Inspeccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CantidadCombustible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TieneGato")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneGomaRepuesto")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneRayadura")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneRoturaCristal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Inspeccion");
                });

            modelBuilder.Entity("rencart.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("rencart.Entities.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("rencart.Entities.RentaDevolucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadPorDia")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("MontoPorDia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RentaDevolucion");
                });

            modelBuilder.Entity("rencart.Entities.TipoCombustible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoCombustible");
                });

            modelBuilder.Entity("rencart.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona");
                });

            modelBuilder.Entity("rencart.Entities.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoVehiculo");
                });

            modelBuilder.Entity("rencart.Entities.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdModelo")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoCombustible")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("NoChasis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoMotor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoPlaca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdModelo");

                    b.HasIndex("IdTipoCombustible");

                    b.HasIndex("IdTipoVehiculo");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("rencart.Entities.firtstable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrimeraTabla");
                });

            modelBuilder.Entity("rencart.Entities.Modelo", b =>
                {
                    b.HasOne("rencart.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("IdMarca")
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("rencart.Entities.Vehiculo", b =>
                {
                    b.HasOne("rencart.Entities.Modelo", "Modelo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdModelo")
                        .IsRequired();

                    b.HasOne("rencart.Entities.TipoCombustible", "TipoCombustible")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdTipoCombustible")
                        .IsRequired();

                    b.HasOne("rencart.Entities.TipoVehiculo", "TipoVehiculo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdTipoVehiculo")
                        .IsRequired();

                    b.Navigation("Modelo");

                    b.Navigation("TipoCombustible");

                    b.Navigation("TipoVehiculo");
                });

            modelBuilder.Entity("rencart.Entities.Marca", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("rencart.Entities.Modelo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("rencart.Entities.TipoCombustible", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("rencart.Entities.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
