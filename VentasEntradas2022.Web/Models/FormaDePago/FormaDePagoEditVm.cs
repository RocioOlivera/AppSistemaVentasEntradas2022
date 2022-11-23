using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentasEntradas2022.Web.Models.FormaDePago
{
    public class FormaDePagoEditVm
    {
        public int FormaDePagoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 2)]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
    }
}
