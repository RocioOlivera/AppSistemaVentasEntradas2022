using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Datos.EntityTypeConfigurations
{
    public class FormasDePagoEntityTypeConfiguration:EntityTypeConfiguration<FormaDePago>
    {
        public FormasDePagoEntityTypeConfiguration()
        {
            ToTable("FormasDePago");
        }
    }
}
