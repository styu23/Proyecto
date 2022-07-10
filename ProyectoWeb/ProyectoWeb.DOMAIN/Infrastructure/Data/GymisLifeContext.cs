using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Infrastructure.Data
{
    public partial class GymisLifeContext : DbContext
    {
        public GymisLifeContext()
        {
        }

        public GymisLifeContext(DbContextOptions<GymisLifeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Areas> Areas { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Empleado> Empleado { get; set; } = null!;
        public virtual DbSet<Entrenador> Entrenador { get; set; } = null!;
        public virtual DbSet<Persona> Persona { get; set; } = null!;
        public virtual DbSet<Planes> Planes { get; set; } = null!;
        public virtual DbSet<Producto> Producto { get; set; } = null!;
        public virtual DbSet<Promocion> Promocion { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedor { get; set; } = null!;
        public virtual DbSet<Puesto> Puesto { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-OP27JP9\\SQLEXPRESS;Database=GymisLife;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.IdAreas)
                    .HasName("id_areas_PK");

                entity.ToTable("areas");

                entity.Property(e => e.IdAreas)
                    .ValueGeneratedNever()
                    .HasColumnName("id_areas");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdDni)
                    .HasName("id_dni_PK");

                entity.ToTable("cliente");

                entity.Property(e => e.IdDni)
                    .ValueGeneratedNever()
                    .HasColumnName("id_dni");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ini");

                entity.Property(e => e.IdPlanes).HasColumnName("id_planes");

                entity.Property(e => e.IdPromocion).HasColumnName("id_promocion");

                entity.Property(e => e.NumBoleta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num_boleta");

                entity.Property(e => e.Ocupacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ocupacion");

                entity.Property(e => e.TelefonoEmergencia).HasColumnName("telefono_emergencia");

                entity.HasOne(d => d.IdPlanesNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdPlanes)
                    .HasConstraintName("id_planes_FK");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdPromocion)
                    .HasConstraintName("id_promocion_FK");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("id_empleado_PK");

                entity.ToTable("empleado");

                entity.Property(e => e.IdEmpleado)
                    .ValueGeneratedNever()
                    .HasColumnName("id_empleado");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.Sueldo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sueldo");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("id_persona_FK");
            });

            modelBuilder.Entity<Entrenador>(entity =>
            {
                entity.HasKey(e => e.IdEntrenador)
                    .HasName("id_entrenador_PK");

                entity.ToTable("entrenador");

                entity.Property(e => e.IdEntrenador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_entrenador");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Entrenador)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("id_persona_LK");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("id_persona_PK");

                entity.ToTable("persona");

                entity.Property(e => e.IdPersona)
                    .ValueGeneratedNever()
                    .HasColumnName("id_persona");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.IdPlanes)
                    .HasName("id_planes_PK");

                entity.ToTable("planes");

                entity.Property(e => e.IdPlanes)
                    .ValueGeneratedNever()
                    .HasColumnName("id_planes");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Planes1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("planes");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("id_producto_PK");

                entity.ToTable("producto");

                entity.Property(e => e.IdProducto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_producto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrecioCompra).HasColumnName("precio_compra");

                entity.Property(e => e.PrecioVenta).HasColumnName("precio_venta");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("id_proveedor_FK");
            });

            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.HasKey(e => e.IdPromocion)
                    .HasName("id_promocion_PK");

                entity.ToTable("promocion");

                entity.Property(e => e.IdPromocion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_promocion");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ini");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("id_proveedor_PK");

                entity.ToTable("proveedor");

                entity.Property(e => e.IdProveedor)
                    .ValueGeneratedNever()
                    .HasColumnName("id_proveedor");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ruc");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.IdPuesto)
                    .HasName("id_puesto_PK");

                entity.ToTable("puesto");

                entity.Property(e => e.IdPuesto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_puesto");

                entity.Property(e => e.IdAreas).HasColumnName("id_areas");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdAreasNavigation)
                    .WithMany(p => p.Puesto)
                    .HasForeignKey(d => d.IdAreas)
                    .HasConstraintName("id_areas_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
