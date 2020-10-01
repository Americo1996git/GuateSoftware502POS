using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ControllerSoft502;

namespace ViewGuate502.Cobros
{
    public partial class FormModalObservaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_promesas_enc;
        public int id_promesas_pago_det;
        public string numero_cuota;
        public FormModalObservaciones()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool guardar = true;
            string rpta = "";
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                XtraMessageBox.Show("Debe escribir la descripción de forma correcta", "Agregando observaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }
            if (guardar)
            {
                rpta = ControllerPagoCredito.AgregarObservaciones(id_promesas_pago_det,Configuraciones.Configuraciones.idtienda,txtDescripcion.Text,Configuraciones.Configuraciones.idusuario);
                if (rpta =="OK")
                {
                    gridControlObservacionesCuota.DataSource = ControllerPagoCredito.MostrarDetalleObservacionesPorCuota(id_promesas_pago_det);
                    gridControlObservacionesCuota.ForceInitialize();
                    gridViewObservacionesCuota.BestFitColumns();
                    txtDescripcion.Text = string.Empty;
                    txtDescripcion.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al agregar las observaciones, por favor consulte a su administrador de datos "+rpta, "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormModalObservaciones_Load(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
            txtNumeroCuota.Text = numero_cuota;
            gridControlObservacionesCuota.DataSource = ControllerPagoCredito.MostrarDetalleObservacionesPorCuota(id_promesas_pago_det);
            gridControlObservacionesCuota.ForceInitialize();
            gridViewObservacionesCuota.BestFitColumns();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar.Focus();

            }
        }

        private void FormModalObservaciones_Activated(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }
    }
}