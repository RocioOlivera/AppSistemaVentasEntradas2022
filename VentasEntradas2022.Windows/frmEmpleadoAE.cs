using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasEntradas2022.Entidades.Entidades;
using VentasEntradas2022.Servicios.Servicios;
using VentasEntradas2022.Servicios.Servicios.Facades;
using VentasEntradas2022.Windows.Helpers;

namespace VentasEntradas2022.Windows
{
    public partial class frmEmpleadoAE : Form
    {
        public frmEmpleadoAE()
        {
            InitializeComponent();
        }

        private Empleado empleado;
        private IServicioEmpleados servicio;
        private List<Empleado> lista;
        public Empleado GetEmpleado()
        {
            return empleado;
        }

        private IServicioTiposDeDocumentos servicioTipoDoc;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //servicioTipoDoc = new ServicioTiposDeDocumentos();
            //HelperCombos.CargarDatosComboTipos(ref cbxTipoDocumento);
            if (empleado != null)
            {
                txtApellidoYNombres.Text = empleado.ApellidoYNombres;
                //cbxTipoDocumento.SelectedValue = empleado.TipoDeDocumentoId;
                txtTipoDoc.Text = empleado.TipoDeDocumento.TipoDeDoc;
                txtNroDocumento.Text = empleado.NroDocumento;
                txtTelefonoFijo.Text = empleado.TelefonoFijo;
                txtTelMovil.Text = empleado.TelefonoMovil;
                txtCorreo.Text = empleado.CorreoElectronico;
                ckbActivo.Checked = empleado.Activo;

            }

        }
        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                
                if (empleado == null)
                {
                    empleado = new Empleado();
                }

                empleado.ApellidoYNombres = txtApellidoYNombres.Text;
                //empleado.TipoDeDocumentoId = (int)cbxTipoDocumento.SelectedValue;
                //empleado.TipoDeDocumento = (TipoDeDocumento)cbxTipoDocumento.SelectedItem;
                empleado.TipoDeDocumento.TipoDeDoc = txtTipoDoc.Text;
                empleado.NroDocumento = txtNroDocumento.Text;
                empleado.TelefonoFijo = txtTelefonoFijo.Text;
                empleado.TelefonoMovil = txtTelMovil.Text;
                empleado.CorreoElectronico = txtCorreo.Text;
                empleado.Activo = ckbActivo.Checked;

                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtApellidoYNombres.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellidoYNombres, "El Apellido y el nombre es requerido.");
            }
            if (string.IsNullOrEmpty(txtNroDocumento.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellidoYNombres, "El num. de documento es requerido.");
            }

            return valido;
        }

        private void frmEmpleadoAE_Load(object sender, EventArgs e)
        {
            servicio = new ServicioEmpleados();
            //HelperCombos.CargarDatosComboTipos(ref cbxTipoDocumento);
            //lista = servicio.GetLista();
          
        }

        private TipoDeDocumento tipoDeDocumento;
        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDocumento.SelectedIndex > 0)
            {
                tipoDeDocumento = (TipoDeDocumento)cbxTipoDocumento.SelectedItem;
            }
            else
            {
                tipoDeDocumento = null;
            }

        }
    }
}
