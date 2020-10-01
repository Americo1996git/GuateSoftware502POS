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

namespace ViewGuate502.Cobros.PagosEnTransito
{
    public partial class FormPagosTransito : DevExpress.XtraEditors.XtraForm
    {
        private static FormPagosTransito _Instacia;
        public FormPagosTransito()
        {
            InitializeComponent();
        }
        public static FormPagosTransito GetInstancia()
        {
            if (_Instacia == null)
            {
                _Instacia = new FormPagosTransito();
            }
            return _Instacia;
        }

        void OperarPago(string tipo_de_operacion,int id_estado_recibo,int opcion)
        {
            FormOperarPago modal = new FormOperarPago(tipo_de_operacion);
            modal.txtEnvio.Text = Convert.ToString(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "envio"));
            modal.txtCorrelativo.Text = Convert.ToString(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "correlativo"));
            modal.txtSerie.Text = Convert.ToString(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "serie"));
            modal.txtCliente.Text = Convert.ToString(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "nombre_cliente"));
            modal.id_pago_recibo_enc = Convert.ToInt32(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "id_recibos_anticipo"));
            modal.txtMontoTotal.Text = Convert.ToString(gridViewPasgosTransito.GetRowCellValue(gridViewPasgosTransito.FocusedRowHandle, "monto_recibo"));
            modal.id_estado_recibo = id_estado_recibo;
            modal.opcion = opcion;
            modal.ShowDialog();
        }
        public void MostrarPagosEnTransitoPendientesDeAplicar()
        {
            gridControlPagos.DataSource = ControllerPagoCredito.MostrarPagosEnTransito(Configuraciones.Configuraciones.idtienda);
            gridControlPagos.ForceInitialize();
            gridViewPasgosTransito.BestFitColumns();
        }
        private void FormPagosTransito_Load(object sender, EventArgs e)
        {
            MostrarPagosEnTransitoPendientesDeAplicar();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            OperarPago("APLICAR",1,0);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            OperarPago("RECHAZAR", 3,1);
        }

        private void gridViewPasgosTransito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OperarPago("APLICAR", 1, 0);
            }
            if (e.KeyCode == Keys.Delete)
            {
                OperarPago("RECHAZAR", 3, 1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPagosTransito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormPagosTransito_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instacia = null;
        }

        private void gridViewPasgosTransito_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "codigo_de_pago_lugar" || e.Column.FieldName == "lugar_de_pago" || e.Column.FieldName == "fecha_de_pago")
            {

            }
        }
    }
}