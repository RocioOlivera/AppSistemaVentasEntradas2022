using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasEntradas2022.Datos;
using VentasEntradas2022.Datos.Repositorios;
using VentasEntradas2022.Datos.Repositorios.Facades;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Servicios.Servicios;
using VentasEntradas2022.Servicios.Servicios.Facades;
using VentasEntradas2022.Windows.Helpers;

namespace VentasEntradas2022.Windows
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private IRepositorioEmpleados repositorio;
        private VentasEntradasDbContext context;
        private IServicioEmpleados servicio;
        private List<Empleado> lista;

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            frmEmpleadoAE frm = new frmEmpleadoAE() { Text = "Agregar nuevo Empleado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Empleado empleado = frm.GetEmpleado();

                if (!servicio.Existe(empleado))
                {
                    servicio.Guardar(empleado);
                    var r = HelperGrid.ConstruirFila(dgvDatos);
                    HelperGrid.SetearFila(r, empleado);
                    HelperGrid.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(HelperTipoMensaje.OK, "Registro agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(HelperTipoMensaje.Error, "Registro existente!!!", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(HelperTipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Empleado empleado = (Empleado) r.Tag;
            try
            {
                frmEmpleadoAE frm = new frmEmpleadoAE() {Text = "Editar Empleado"};
                frm.SetEmpleado(empleado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                empleado = frm.GetEmpleado();
                if (!servicio.Existe(empleado))
                {
                    servicio.Guardar(empleado);
                    HelperGrid.SetearFila(r, empleado);
                    MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    HelperGrid.SetearFila(r, dgvDatos);
                    MessageBox.Show("Registro existente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnBORRAR_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Empleado empleado = (Empleado)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje("¿Desea borrar el empleado?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(empleado))
                {
                    servicio.Borrar(empleado);
                    HelperMensaje.Mensaje(HelperTipoMensaje.OK, "Empleado borrado!!", "Mensaje");
                    HelperFormulario.MostrarDatosEnGrilla(dgvDatos,lista);
                }
                else
                {
                    {
                        HelperMensaje.Mensaje(HelperTipoMensaje.Error, "Registro relacionado", "Error");
                    }
                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(HelperTipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            servicio = new ServicioEmpleados();
            try
            {
                lista = servicio.GetLista();
                HelperFormulario.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(HelperTipoMensaje.Error, exception.Message, "Error");
            }
        }
    }
}
