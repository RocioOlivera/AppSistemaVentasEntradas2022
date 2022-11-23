using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Datos
{
    public class VentasEntradasDbContext:DbContext
    {
        public VentasEntradasDbContext() : base("name=MiConexion")
        {
            Database.CommandTimeout = 45;
            Configuration.UseDatabaseNullSemantics = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VentasEntradasDbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<TipoDeDocumento> TipoDeDocumentos { get; set; }
        public DbSet<FormaDePago> FormaDePagos { get; set; }
        public DbSet<FormaDeVenta> FormaDeVentas { get; set; }
    }
}
