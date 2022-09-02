using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tarea_1.Models
{
    public partial class Tarea_1Context : DbContext
    {
        public Tarea_1Context()
        {
        }

        public Tarea_1Context(DbContextOptions<Tarea_1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<DepartamentoManagerView> DepartamentoManagerViews { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<EmpleadoDepartamento> EmpleadoDepartamentos { get; set; } = null!;
        public virtual DbSet<EmpleadoProyecto> EmpleadoProyectos { get; set; } = null!;
        public virtual DbSet<ErrorDeProducción> ErrorDeProduccións { get; set; } = null!;
        public virtual DbSet<ManagerDepartamento> ManagerDepartamentos { get; set; } = null!;
        public virtual DbSet<ManagerSoftware> ManagerSoftwares { get; set; } = null!;
        public virtual DbSet<ProyectoCorreción> ProyectoCorrecións { get; set; } = null!;
        public virtual DbSet<Servidor> Servidors { get; set; } = null!;
        public virtual DbSet<ServidorProyecto> ServidorProyectos { get; set; } = null!;
        public virtual DbSet<Software> Softwares { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-RIB9CLGL; Database=Tarea_#1; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.CodigoDepartamento)
                    .HasName("PK__Departam__60D0E07912AA8F65");

                entity.ToTable("Departamento");

                entity.Property(e => e.CodigoDepartamento)
                    .ValueGeneratedNever()
                    .HasColumnName("Codigo_departamento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartamentoManagerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("departamentoManagerView");

                entity.Property(e => e.CedulaEmpleadoManager)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado_manager");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombreEmpleado");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__Empleado__B4ADFE392A8DB00F");

                entity.ToTable("Empleado");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apelllido2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rol)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpleadoDepartamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Empleado_departamento");

                entity.Property(e => e.CedulaEmpleado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");

                entity.HasOne(d => d.CedulaEmpleadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CedulaEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Cedul__412EB0B6");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Codig__4222D4EF");
            });

            modelBuilder.Entity<EmpleadoProyecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Empleado_proyecto");

                entity.Property(e => e.CedulaEmpleado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado");

                entity.Property(e => e.NumeroProyecto).HasColumnName("Numero_proyecto");

                entity.HasOne(d => d.CedulaEmpleadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CedulaEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Cedul__3B75D760");

                entity.HasOne(d => d.NumeroProyectoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NumeroProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Numer__3C69FB99");
            });

            modelBuilder.Entity<ErrorDeProducción>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("PK__Error_de__F2374EB194D23D88");

                entity.ToTable("Error_de_producción");

                entity.Property(e => e.Identificador).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Hora");

                entity.Property(e => e.Impacto)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.SoftwareNavigation)
                    .WithMany(p => p.ErrorDeProduccións)
                    .HasForeignKey(d => d.Software)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Error_de___Softw__35BCFE0A");
            });

            modelBuilder.Entity<ManagerDepartamento>(entity =>
            {
                entity.HasKey(e => new { e.CedulaEmpleadoManager, e.CodigoDepartamento })
                    .HasName("PK__Manager___5A39C0C80B3DF2C8");

                entity.ToTable("Manager_Departamento");

                entity.Property(e => e.CedulaEmpleadoManager)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado_manager");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");
            });

            modelBuilder.Entity<ManagerSoftware>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manager_Software");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");

                entity.Property(e => e.CodigoSoftware).HasColumnName("Codigo_software");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_S__Codig__47DBAE45");

                entity.HasOne(d => d.CodigoSoftwareNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoSoftware)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_S__Codig__49C3F6B7");
            });

            modelBuilder.Entity<ProyectoCorreción>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("PK__Proyecto__F2374EB1CADEC890");

                entity.ToTable("Proyecto_correción");

                entity.Property(e => e.Identificador).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsfuerzoEstimado).HasColumnName("Esfuerzo_estimado");

                entity.Property(e => e.EsfuerzoReal).HasColumnName("Esfuerzo_real");

                entity.Property(e => e.FechaFinalización)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_finalización");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_inicio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.ErrorNavigation)
                    .WithMany(p => p.ProyectoCorrecións)
                    .HasForeignKey(d => d.Error)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proyecto___Error__398D8EEE");
            });

            modelBuilder.Entity<Servidor>(entity =>
            {
                entity.HasKey(e => e.NumeroSerie)
                    .HasName("PK__Servidor__B377BCD58FE83917");

                entity.ToTable("Servidor");

                entity.Property(e => e.NumeroSerie)
                    .ValueGeneratedNever()
                    .HasColumnName("Numero_serie");

                entity.Property(e => e.CapacidadAlmacenamiento).HasColumnName("Capacidad_almacenamiento");

                entity.Property(e => e.CapacidadProcesamiento).HasColumnName("Capacidad_procesamiento");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_compra");

                entity.Property(e => e.Marca)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MemoriaRam).HasColumnName("Memoria_RAM");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServidorProyecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Servidor_proyecto");

                entity.Property(e => e.NumeroSerieServidor).HasColumnName("Numero_serie_servidor");

                entity.Property(e => e.Rol)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSoftwareNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodigoSoftware)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servidor___Codig__30F848ED");

                entity.HasOne(d => d.NumeroSerieServidorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NumeroSerieServidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servidor___Numer__2F10007B");
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.HasKey(e => e.CodigoSoftware)
                    .HasName("PK__Software__B29B17A4B46BD5C1");

                entity.ToTable("Software");

                entity.Property(e => e.CodigoSoftware).ValueGeneratedNever();

                entity.Property(e => e.Descripción)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaExpiraciónLicencia)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_expiración_licencia");

                entity.Property(e => e.FechaPuestaProducción)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_puesta_producción");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPatente).HasColumnName("Numero_patente");

                entity.Property(e => e.TipoSoftware)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_software");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
