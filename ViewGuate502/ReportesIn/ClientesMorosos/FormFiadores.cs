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

namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class FormFiadores : DevExpress.XtraEditors.XtraForm
    {
        public int id_venta_enc,id_cliente;
        public int numero_reporte = 0;
        public FormFiadores()
        {
            InitializeComponent();
        }

        private void FormFiadores_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (numero_reporte == 0)
            {
                dt = ControllerClientesMorosos.MostrarFiadores(Configuraciones.Configuraciones.idtienda, id_venta_enc);
                gridControlFiadores.DataSource = dt;
                txtEnvio.Text = dt.Rows[0]["envio"].ToString();
                gridViewFiadores.Columns["id_venta_fiador"].Visible = false;
                gridViewFiadores.Columns["id_fiador"].Visible = false;
                gridViewFiadores.Columns["id_venta_enc"].Visible = false;
                gridViewFiadores.Columns["activo"].Visible = false;
                gridViewFiadores.Columns["fecha_creacion"].Visible = false;
                gridViewFiadores.Columns["id_usuario_creacion"].Visible = false;
                gridViewFiadores.Columns["envio"].Visible = false;
                layoutControlItemBtnEstadoDeCuenta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {

                layoutControlGroup2.Text = "Envios asociados a un cliente";
                layoutControlItemNumeroEnvio.Text = "Fiador";
                dt = ControllerClientesMorosos.EnviosAsociadosAlClienteFiador(Configuraciones.Configuraciones.idtienda, id_cliente);
                gridControlFiadores.DataSource = dt;
                txtEnvio.Text = dt.Rows[0]["fiador"].ToString();
                gridViewFiadores.Columns["id_cliente"].Visible = false;
                gridViewFiadores.Columns["id_venta_enc"].Visible = false;
                gridViewFiadores.Columns["fiador"].Visible = false;
            }

        }

        private void btnEstadoDeCuenta_Click(object sender, EventArgs e)
        {

            //Cobros.FormImprimirEstadoDeCuenta modal = new Cobros.FormImprimirEstadoDeCuenta();
            //modal.id_promesas_enca = Convert.ToInt32(gridViewFiadores.GetRowCellValue(gridViewFiadores.FocusedRowHandle,"Envio"));
            //modal.cliente = "";
            //modal.producto = "";
            //modal.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}