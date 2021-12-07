using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HPPParcial2.Models
{
    public partial class SantaMonicaDbContext : DbContext
    {
        public SantaMonicaDbContext()
        {
        }

        public SantaMonicaDbContext(DbContextOptions<SantaMonicaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Zonas> Zonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server= LEA-E590;Database= SantaMonica;user=sa;trusted_connection=true; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.EstadoId);

                entity.HasOne(d => d.Produ)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.ProduId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Orden_Usuarios_UsuariosId");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Ingreso).HasColumnType("datetime");

                entity.Property(e => e.Marca).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();

                entity.HasOne(d => d.TipoProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.TipoProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Contrasenia).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();

                entity.HasOne(d => d.Zona)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ZonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
