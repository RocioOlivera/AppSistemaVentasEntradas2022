using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEntradas2022.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string ApellidoYNombres { get; set; }
        public int TipoDeDocumentoId { get; set; }
        public string NroDocumento { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Activo { get; set; }
        public TipoDeDocumento TipoDeDocumento { get; set; }
    }
}
