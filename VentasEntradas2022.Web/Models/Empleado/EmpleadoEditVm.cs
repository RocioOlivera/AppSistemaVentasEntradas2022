using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentasEntradas2022.Web.Models.Empleado
{
    public class EmpleadoEditVm
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ApellidoYNombre { get; set; }

        public int TipoDeDocumentoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string NroDocumento { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Activo { get; set; }
    }
}