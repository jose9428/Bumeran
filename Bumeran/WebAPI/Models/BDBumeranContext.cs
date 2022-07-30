using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Models
{
    public partial class BDBumeranContext : DbContext
    {
        public BDBumeranContext()
        {
        }

        public BDBumeranContext(DbContextOptions<BDBumeranContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Postulante> Postulantes { get; set; } = null!;
        public virtual DbSet<Publicacion> Publicacions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer("Data source=(local); Initial Catalog=bdBumeran;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postulante>(entity =>
            {
                entity.HasKey(e => e.IdPostulante)
                    .HasName("PK__Postulan__9EA5C4D1B4B4E4B9");

                entity.ToTable("Postulante");

                entity.Property(e => e.IdPostulante).HasColumnName("id_postulante");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Celular)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Conocimientos)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dni");

                entity.Property(e => e.Expericencia)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("expericencia");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Foracademica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foracademica");

                entity.Property(e => e.Genero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.Idioma)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("idioma");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nacionalidad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("salario");
            });

            modelBuilder.Entity<Publicacion>(entity =>
            {
                entity.HasKey(e => e.IdPublicacion)
                    .HasName("PK__Publicac__7C3851737AA8D5DB");

                entity.ToTable("Publicacion");

                entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");

                entity.Property(e => e.Area)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Distrito)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Habilidades)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idDepartamento");

                entity.Property(e => e.Jerarquia)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Lugar)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Modalidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEmpresa)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("sueldo");

                entity.Property(e => e.Tipempleo)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Vacantes).HasColumnName("vacantes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
