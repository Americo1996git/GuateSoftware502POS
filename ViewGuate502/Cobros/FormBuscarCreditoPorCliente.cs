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
    public partial class FormBuscarCreditoPorCliente : DevExpress.XtraEditors.XtraForm
    {
        public int id_cliente;
        public bool pagar = false;
        int tipo_de_busqueda;
        public string texto_inciail = "";

        public string cliente;
        DashBoard menu;
        public FormBuscarCreditoPorCliente(int tipo_busquda,DashBoard dashboard)
        {
            InitializeComponent();
            tipo_de_busqueda = tipo_busquda;
            menu = dashboard;
        }
        public FormBuscarCreditoPorCliente()
        {
            InitializeComponent();
        }

        private void txtBuscarCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (tipo_de_busqueda == 1)
            {
                gridControlClietnesConCredito.DataSource = ControllerPagoCredito.MostrarClienteConCredito(txtBuscarCliente.Text,0);
                gridControlClietnesConCredito.ForceInitialize();
                gridViewClientesConCredito.BestFitColumns();
            }
            else
            {
                gridControlClietnesConCredito.DataSource = ControllerPagoCredito.MostrarClienteConCredito(txtBuscarCliente.Text, 1);
                gridControlClietnesConCredito.ForceInitialize();
                gridViewClientesConCredito.BestFitColumns();
            }


        }

        private void gridViewClientesConCredito_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (tipo_de_busqueda == 1)
            {
                gridControlCreditosPorCliente.DataSource = ControllerPagoCredito.MostrarCreditoPorCliente(Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(e.RowHandle, "id_cliente")),0);
                gridControlCreditosPorCliente.ForceInitialize();
                gridViewCreditosPorCliente.BestFitColumns();
                id_cliente = Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(e.RowHandle, "id_cliente"));
            }
            if (tipo_de_busqueda == 2)
            {
                gridControlCreditosPorCliente.DataSource = ControllerPagoCredito.MostrarCreditoPorCliente(Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(e.RowHandle, "id_cliente")), 1);
                gridControlCreditosPorCliente.ForceInitialize();
                gridViewCreditosPorCliente.BestFitColumns();
                id_cliente = Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(e.RowHandle, "id_cliente"));
            }

        }

        private void FormBuscarCreditoPorCliente_Load(object sender, EventArgs e)
        {
            if (tipo_de_busqueda == 1) //si es 1 solo muestra creditos vigentes
            {
 
                txtBuscarCliente.Text = cliente;
                gridControlClietnesConCredito.DataSource = ControllerPagoCredito.MostrarClienteConCredito(texto_inciail, 0);
                gridControlClietnesConCredito.ForceInitialize();
                gridViewClientesConCredito.BestFitColumns();

                gridControlCreditosPorCliente.DataSource = ControllerPagoCredito.MostrarCreditoPorCliente(id_cliente, 0);
                gridControlCreditosPorCliente.ForceInitialize();
                gridViewCreditosPorCliente.BestFitColumns();

                //gridViewCreditosPorCliente.Columns[5].Visible = false;
                //gridViewCreditosPorCliente.Columns[6].Visible = false;
                layoutControlItemRecargos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else // de lo contrario o si es 2 muestra vigentes y cancelados creditos
            {
                this.Text = "Otros movimientos";
                gridViewCreditosPorCliente.Columns[4].Visible = true;
                gridViewCreditosPorCliente.Columns[5].Visible = false;
                gridViewCreditosPorCliente.Columns[6].Visible = true;
                layoutControlItemRecargos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                pagar = false;
            }



        }

        private void gridViewCreditosPorCliente_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
 
        }

        private void btnEstadoDeCuenta_Click(object sender, EventArgs e)
        {
            if (gridViewCreditosPorCliente.DataRowCount > 0)
            {
                FormImprimirEstadoDeCuenta modal = new FormImprimirEstadoDeCuenta();
                modal.id_promesas_enca = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "id_promesa_pago"));
                modal.cliente = Convert.ToString(gridViewClientesConCredito.GetRowCellValue(gridViewClientesConCredito.FocusedRowHandle, "nombre_cliente"));
                modal.producto = Convert.ToString(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "producto"));
                modal.ShowDialog();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarCreditoPorCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridViewCreditosPorCliente_DoubleClick(object sender, EventArgs e)
        {
            if (tipo_de_busqueda == 1)
            {
                if (gridViewCreditosPorCliente.DataRowCount > 0)
                {
                    FormCobros cobros = FormCobros.GetInstancia(menu);
                    cobros.MostrarPromesasPago(Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "id_promesa_pago")), id_cliente, Convert.ToString(gridViewClientesConCredito.GetRowCellValue(gridViewClientesConCredito.FocusedRowHandle, "nombre_cliente")), Convert.ToString(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "correlativo")));
                    cobros.MdiParent = menu;
                    cobros.Show();
                    this.Close();
                }
            }

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

  

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            if (gridViewCreditosPorCliente.DataRowCount > 0)
            {
                FormImprimirReporteRecibosAsociados modalReporte = new FormImprimirReporteRecibosAsociados();
                modalReporte.id_ventas_enc = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "id_venta_enc"));
                modalReporte.correlativo = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "correlativo"));
                modalReporte.ShowDialog();
            }

        }

        private void btnRecargos_Click(object sender, EventArgs e)
        {
            if (gridViewCreditosPorCliente.DataRowCount > 0)
            {
                FormRecargos recargosModal = new FormRecargos();
                recargosModal.id_promesa_pago_enc = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "id_promesa_pago"));
                recargosModal.correlativo = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "cuotas"));
                recargosModal.envio = Convert.ToInt32(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "correlativo"));
                recargosModal.serie = Convert.ToString(gridViewCreditosPorCliente.GetRowCellValue(gridViewCreditosPorCliente.FocusedRowHandle, "serie"));
                recargosModal.ShowDialog();

                gridControlCreditosPorCliente.DataSource = ControllerPagoCredito.MostrarCreditoPorCliente(Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(gridViewClientesConCredito.FocusedRowHandle, "id_cliente")), 1);
                gridControlCreditosPorCliente.ForceInitialize();
                gridViewCreditosPorCliente.BestFitColumns();
                id_cliente = Convert.ToInt32(gridViewClientesConCredito.GetRowCellValue(gridViewClientesConCredito.FocusedRowHandle, "id_cliente"));
            }
        }

        private void btnImprimirAnalisisCredito_Click(object sender, EventArgs e)
        {
            ReportesIn.CobrosPagos.AnalisisCreditos.FormImprimirAnalisisCredito formReporte = new ReportesIn.CobrosPagos.AnalisisCreditos.FormImprimirAnalisisCredito();
            formReporte.id_cliente = id_cliente;
            formReporte.id_tienda = Configuraciones.Configuraciones.idtienda;
            formReporte.opcion = 0;
            formReporte.cliente = Convert.ToString(gridViewClientesConCredito.GetRowCellValue(gridViewClientesConCredito.FocusedRowHandle, "nombre_cliente"));
            formReporte.tienda = Configuraciones.Configuraciones.tienda;
            formReporte.ShowDialog();

        }
    }
}