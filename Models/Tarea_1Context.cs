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
        public virtual DbSet<PersonasProyectoView> PersonasProyectoViews { get; set; } = null!;
        public virtual DbSet<ProyectoCorreción> ProyectoCorrecións { get; set; } = null!;
        public virtual DbSet<ProyectoError> ProyectoErrors { get; set; } = null!;
        public virtual DbSet<Servidor> Servidors { get; set; } = null!;
        public virtual DbSet<ServidorProyecto> ServidorProyectos { get; set; } = null!;
        public virtual DbSet<Software> Softwares { get; set; } = null!;
        public virtual DbSet<SoftwaresView> SoftwaresViews { get; set; } = null!;

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
                entity.HasKey(e => e.CedulaEmpleado)
                    .HasName("PK__Empleado__F18B58290FEB8FC6");

                entity.ToTable("Empleado_departamento");

                entity.Property(e => e.CedulaEmpleado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");

                entity.HasOne(d => d.CedulaEmpleadoNavigation)
                    .WithOne(p => p.EmpleadoDepartamento)
                    .HasForeignKey<EmpleadoDepartamento>(d => d.CedulaEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Cedul__6E01572D");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithMany(p => p.EmpleadoDepartamentos)
                    .HasForeignKey(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Codig__6C190EBB");
            });

            modelBuilder.Entity<EmpleadoProyecto>(entity =>
            {
                entity.HasKey(e => new { e.CedulaEmpleado, e.NumeroProyecto })
                    .HasName("PK__Empleado__2FAF84CEFE6E6962");

                entity.ToTable("Empleado_proyecto");

                entity.Property(e => e.CedulaEmpleado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado");

                entity.Property(e => e.NumeroProyecto).HasColumnName("Numero_proyecto");

                entity.HasOne(d => d.CedulaEmpleadoNavigation)
                    .WithMany(p => p.EmpleadoProyectos)
                    .HasForeignKey(d => d.CedulaEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Cedul__02FC7413");

                entity.HasOne(d => d.NumeroProyectoNavigation)
                    .WithMany(p => p.EmpleadoProyectos)
                    .HasForeignKey(d => d.NumeroProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado___Numer__03F0984C");
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
                entity.HasKey(e => e.CodigoDepartamento)
                    .HasName("PK__Manager___60D0E07974A93BD9");

                entity.ToTable("Manager_Departamento");

                entity.Property(e => e.CodigoDepartamento)
                    .ValueGeneratedNever()
                    .HasColumnName("Codigo_departamento");

                entity.Property(e => e.CedulaEmpleadoManager)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_empleado_manager");

                entity.HasOne(d => d.CedulaEmpleadoManagerNavigation)
                    .WithMany(p => p.ManagerDepartamentos)
                    .HasForeignKey(d => d.CedulaEmpleadoManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_D__Cedul__628FA481");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithOne(p => p.ManagerDepartamento)
                    .HasForeignKey<ManagerDepartamento>(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_D__Codig__6383C8BA");
            });

            modelBuilder.Entity<ManagerSoftware>(entity =>
            {
                entity.HasKey(e => e.CodigoSoftware)
                    .HasName("PK__Manager___E57790F997BB7C39");

                entity.ToTable("Manager_Software");

                entity.Property(e => e.CodigoSoftware)
                    .ValueGeneratedNever()
                    .HasColumnName("Codigo_software");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("Codigo_departamento");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithMany(p => p.ManagerSoftwares)
                    .HasForeignKey(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_S__Codig__7D439ABD");

                entity.HasOne(d => d.CodigoSoftwareNavigation)
                    .WithOne(p => p.ManagerSoftware)
                    .HasForeignKey<ManagerSoftware>(d => d.CodigoSoftware)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Manager_S__Codig__7F2BE32F");
            });

            modelBuilder.Entity<PersonasProyectoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("personasProyectoView");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroProyecto).HasColumnName("Numero_proyecto");

                entity.Property(e => e.Rol)
                    .HasMaxLength(25)
                    .IsUnicode(false);
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
                    .HasConstraintName("FK__Proyecto___Error__3864608B");
            });

            modelBuilder.Entity<ProyectoError>(entity =>
            {
                entity.HasKey(e => new { e.Proyecto, e.Error })
                    .HasName("PK__Proyecto__A739749BAEA1BF01");

                entity.ToTable("Proyecto_Error");

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ErrorNavigation)
                    .WithMany(p => p.ProyectoErrors)
                    .HasForeignKey(d => d.Error)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proyecto___Error__3493CFA7");

                entity.HasOne(d => d.ProyectoNavigation)
                    .WithMany(p => p.ProyectoErrors)
                    .HasForeignKey(d => d.Proyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proyecto___Proye__32AB8735");
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
                entity.HasKey(e => e.NumeroSerieServidor)
                    .HasName("PK__Servidor__BA3EF0ABE0E506EF");

                entity.ToTable("Servidor_proyecto");

                entity.Property(e => e.NumeroSerieServidor)
                    .ValueGeneratedNever()
                    .HasColumnName("Numero_serie_servidor");

                entity.Property(e => e.Rol)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSoftwareNavigation)
                    .WithMany(p => p.ServidorProyectos)
                    .HasForeignKey(d => d.CodigoSoftware)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servidor___Codig__08B54D69");

                entity.HasOne(d => d.NumeroSerieServidorNavigation)
                    .WithOne(p => p.ServidorProyecto)
                    .HasForeignKey<ServidorProyecto>(d => d.NumeroSerieServidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Servidor___Numer__06CD04F7");
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

            modelBuilder.Entity<SoftwaresView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("softwaresView");

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

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombreDepartamento");

                entity.Property(e => e.NumeroPatente).HasColumnName("Numero_patente");

                entity.Property(e => e.NumeroSerieServidor).HasColumnName("Numero_serie_servidor");

                entity.Property(e => e.Rol)
                    .HasMaxLength(40)
                    .IsUnicode(false);

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
