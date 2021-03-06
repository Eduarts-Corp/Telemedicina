// <auto-generated />
using System;
using MascotasEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotasEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AuxVeterinarioId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuxVeterinarioId");

                    b.HasIndex("HistoriaId");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.ToTable("SugerenciasCuidados");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.AuxVeterinario", b =>
                {
                    b.HasBaseType("MascotasEnCasa.App.Dominio.Persona");

                    b.Property<DateTime>("HorasLaborales")
                        .HasColumnType("datetime2");

                    b.Property<string>("Licencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AuxVeterinario");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("MascotasEnCasa.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("MascotasEnCasa.App.Dominio.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Licencia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Veterinario_Licencia");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Paciente", b =>
                {
                    b.HasOne("MascotasEnCasa.App.Dominio.AuxVeterinario", "AuxVeterinario")
                        .WithMany()
                        .HasForeignKey("AuxVeterinarioId");

                    b.HasOne("MascotasEnCasa.App.Dominio.Historia", "Historia")
                        .WithMany()
                        .HasForeignKey("HistoriaId");

                    b.HasOne("MascotasEnCasa.App.Dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId");

                    b.HasOne("MascotasEnCasa.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("AuxVeterinario");

                    b.Navigation("Historia");

                    b.Navigation("Propietario");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.SignoVital", b =>
                {
                    b.HasOne("MascotasEnCasa.App.Dominio.Paciente", null)
                        .WithMany("SignosVitales")
                        .HasForeignKey("PacienteId");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("MascotasEnCasa.App.Dominio.Historia", null)
                        .WithMany("SugerenciasCuidados")
                        .HasForeignKey("HistoriaId");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Historia", b =>
                {
                    b.Navigation("SugerenciasCuidados");
                });

            modelBuilder.Entity("MascotasEnCasa.App.Dominio.Paciente", b =>
                {
                    b.Navigation("SignosVitales");
                });
#pragma warning restore 612, 618
        }
    }
}
