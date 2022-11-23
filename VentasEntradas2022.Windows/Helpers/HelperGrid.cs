using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasEntradas2022.Entidades.Entidades;

namespace VentasEntradas2022.Windows.Helpers
{
    public class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Empleado empleado:
                    r.Cells[0].Value = empleado.ApellidoYNombres;
                    r.Cells[1].Value = empleado.TipoDeDocumento;
                    r.Cells[2].Value = empleado.NroDocumento;
                    r.Cells[3].Value = empleado.TelefonoFijo;
                    r.Cells[4].Value = empleado.TelefonoMovil;
                    r.Cells[5].Value = empleado.CorreoElectronico;
                    r.Cells[6].Value = empleado.Activo;
                    break;


                //case TipoDeDocumento tipoDeDocumento:
                //    r.Cells[0].Value = ((TipoDeDocumento)obj).TipoDeDoc;
                //    break;
            }

            r.Tag = obj;
        }
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

    }
}
