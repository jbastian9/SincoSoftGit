using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace WebApplication.DAL_Data_Access_Layer
{
    public class Context : DbContext
    {
        public Context() : base("ConnectionChain") { }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Correo> Correo { get; set; }
        public DbSet<HistorialCorreosEnviados> HistorialCorreosEnviados { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Conventions.Remove<PluralizingTableNameConvention>();
            
            
            //fluent Api

            mb.Entity<Pais>().HasKey(x => x.ID);
            mb.Entity<Pais>().Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            mb.Entity<Ciudad>().HasKey(x => x.ID);
            mb.Entity<Ciudad>().Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            mb.Entity<Ciudad>().HasRequired(x => x.Pais).WithMany().HasForeignKey(x=>x.PaisId).WillCascadeOnDelete(false);

            mb.Entity<Usuario>().HasKey(x => x.ID);
            mb.Entity<Usuario>().Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            mb.Entity<Usuario>().Property(x => x.Apellido).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            mb.Entity<Usuario>().Property(x => x.Correo).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            mb.Entity<Usuario>().Property(x => x.Telefono).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            mb.Entity<Usuario>().HasRequired(x => x.Pais).WithMany().HasForeignKey(x => x.PaisId).WillCascadeOnDelete(false);
            mb.Entity<Usuario>().HasRequired(x => x.Ciudad).WithMany().HasForeignKey(x => x.CiudadId).WillCascadeOnDelete(false);

            mb.Entity<Contacto>().HasKey(x => x.ID);
            mb.Entity<Contacto>().Property(x => x.Nombre).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            mb.Entity<Contacto>().Property(x => x.Apellido).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            mb.Entity<Contacto>().Property(x => x.Correo).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            mb.Entity<Contacto>().Property(x => x.Telefono).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            mb.Entity<Contacto>().HasRequired(x => x.Ciudad).WithMany().HasForeignKey(x => x.CiudadId).WillCascadeOnDelete(false);
            mb.Entity<Contacto>().HasRequired(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId).WillCascadeOnDelete(false);
   
            mb.Entity<Correo>().HasKey(x => x.ID);
            mb.Entity<Correo>().Property(x => x.Fecha).HasColumnType("smalldatetime").IsRequired();
            mb.Entity<Correo>().Property(x => x.Cuerpo).HasColumnType("varchar").HasMaxLength(500).IsRequired();
            mb.Entity<Correo>().Property(x => x.Extension).HasColumnType("varchar").HasMaxLength(5).IsRequired();
            mb.Entity<Correo>().HasRequired(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId).WillCascadeOnDelete(false);

            mb.Entity<HistorialCorreosEnviados>().HasKey(x => x.ID);
            mb.Entity<HistorialCorreosEnviados>().HasRequired(x => x.Correo).WithMany().HasForeignKey(x => x.CorreoId).WillCascadeOnDelete(false);
            mb.Entity<HistorialCorreosEnviados>().HasRequired(x => x.Contacto).WithMany().HasForeignKey(x => x.ContactoID).WillCascadeOnDelete(false);

        }

    }
}