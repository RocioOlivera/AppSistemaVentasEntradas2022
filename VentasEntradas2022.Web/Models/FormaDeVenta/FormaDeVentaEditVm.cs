using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentasEntradas2022.Web.Models.FormaDeVenta
{
    public class FormaDeVentaEditVm
    {
        public int FormaDeVentaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 2)]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
    }
}