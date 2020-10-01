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
using MODELOS502;

namespace ViewGuate502.Cobros.PagosEnTransito
{
    public partial class FormOperarPago : DevExpress.XtraEditors.XtraForm
    {
        string operacion = "";
        public int id_pago_recibo_enc;
        public int opcion;
        public int id_estado_recibo;

        public FormOperarPago(string tipo_de_operacion)
        {
            InitializeComponent();
            this.Text = tipo_de_operacion;
            operacion = tipo_de_operacion;
        }

        private void FormOperarPago_Load(object sender, EventArgs e)
        {
            gridControlDetalleDePago.DataSource = ControllerPagoCredito.MostrarDetalleDePago(Configuraciones.Configuraciones.idtienda,id_pago_recibo_enc);
            gridControlDetalleDePago.ForceInitialize();
            gridViewDetallePago.BestFitColumns();

            if (operacion.Equals("APLICAR"))
            {
                btnOperar.Text = "APLICAR";
                lyRazon.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyNumeroPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (operacion.Equals("RECHAZAR"))
            {
                btnOperar.Text = "RECHAZAR";
                lyRazon.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                dxErrorProvider1.SetError(txtRazon,"ESTE CAMPO ES OBLIGATORIO");
                lyNumeroPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            bool grabar = true;
            string rpta = "";
            if (operacion.Equals("RECHAZAR"))
            {
                if(string.IsNullOrWhiteSpace(txtRazon.Text))
                {
                    grabar = false;
                }
            }
            if (grabar)
            {
                MPagoCreditoEncabezado pago = new MPagoCreditoEncabezado();
                pago.IdTienda = Configuraciones.Configuraciones.idtienda;
                pago.IdPagoCreditoEnc = id_pago_recibo_enc;
                pago.IdTipoPagoCredito = 4;
                pago.IdEstadoRecibo = id_estado_recibo;
                pago.Opcion = opcion;

                List<MPagoCreditoDetalle> detalleInsercion = new List<MPagoCreditoDetalle>();
                for (int i = 0; i < gridViewDetallePago.DataRowCount; i++)
                {
                    if (Convert.ToDecimal(gridViewDetallePago.GetRowCellValue(i, "monto_pagar")) > 0)
                    {
                        MPagoCreditoDetalle detalle = new MPagoCreditoDetalle();
                        detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        detalle.IdPromesaPagoDet = Convert.ToInt32(gridViewDetallePago.GetRowCellValue(i, "id_promesa_pago_det"));
                        detalle.MontoCuota = Convert.ToDecimal(gridViewDetallePago.GetRowCellValue(i, "monto"));
                        detalle.Opcion = 0;
                        detalleInsercion.Add(detalle);
                    }
                }

                rpta = ControllerPagoCredito.ActualizarEstadoDelPago(pago, detalleInsercion);
                if (rpta == "OK")
                {
                    XtraMessageBox.Show("LA OPERACION SE REALIZO CORRECTAMENTE", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPagosTransito form = FormPagosTransito.GetInstancia();
                    form.MostrarPagosEnTransitoPendientesDeAplicar();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al realizar la operación, por favor consulte a su administrador de datos " + rpta, "Erro del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}