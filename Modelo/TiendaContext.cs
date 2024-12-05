using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Modelo;

namespace Modelo
{
    public class TiendaContext : DbContext
    {


        public TiendaContext() { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<DetalleFactura> DetallesFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set;}

        //conexion a la BD

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Server=LegionNachi\\SQLSERVER;Database=TPFinalDAS;Trusted_Connection=True;TrustServerCertificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<DetalleFactura>().ToTable("DetalleFactura");
            modelBuilder.Entity<Factura>().ToTable("Factura");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");

            modelBuilder.Entity<Cliente>()
                .HasDiscriminator<string>("TipoCliente")
                .HasValue<ClienteIndividual>("Individual")
                .HasValue<ClienteEmpresarial>("Empresarial");
        }




    }


}
