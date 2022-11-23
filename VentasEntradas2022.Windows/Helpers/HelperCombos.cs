using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Servicios.Servicios;
using VentasEntradas2022.Servicios.Servicios.Facades;

namespace VentasEntradas2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboTipos(ref ComboBox combo)
        {
            IServicioTiposDeDocumentos servicio = new ServicioTiposDeDocumentos();
            var lista = servicio.GetLista();
            TipoDeDocumento tdDefault = new TipoDeDocumento()
            {
                TipoDeDocumentoId = 0,
                TipoDeDoc = "Seleccione Tipo Producto"
            };
            lista.Insert(0, tdDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NroDocumento";
            combo.ValueMember = "TipoDeDocumentoId";
            combo.SelectedIndex = 0;
        }
    }

}
