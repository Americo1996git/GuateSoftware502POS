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
using DevExpress.XtraEditors.Controls;
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;

namespace ViewGuate502.Cobros
{
    public partial class FormCobros : DevExpress.XtraEditors.XtraForm
    {
        private static FormCobros _instancia;
        public int id_promesa_pago_enc;
        public int id_cliente;
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_recibos_anticiposTableAdapter tbl_recibos_anticipos = new tbl_recibos_anticiposTableAdapter();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        DashBoard principal;

        
        public FormCobros(DashBoard dashBoard)
        {
            InitializeComponent();
            principal = dashBoard;
        }

        public static FormCobros GetInstancia(DashBoard dash)
        {
            if (_instancia == null)
            {
                _instancia = new FormCobros(dash);
            }
            return _instancia;
        }
        public void MostrarPromesasPago(int id_promesa_pago_enc,int id_cliente,string cliente,string envio)
        {
            decimal saldo=0;
            this.id_cliente = id_cliente;
            this.id_promesa_pago_enc = id_promesa_pago_enc;
            txtNumeroDeEnvio.Text = envio;
            txtCliente.Text = cliente;
            gridControlDetallePromesasPago.DataSource = ControllerPagoCredito.MostrarDetallePromesasDePagoParaCobros(id_promesa_pago_enc);
            gridControlDetallePromesasPago.ForceInitialize();
            gridViewDetallePromesasPago.BestFitColumns();
            for (int i = 0; i < gridViewDetallePromesasPago.DataRowCount; i++)
            {
                saldo = saldo + (Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "saldo")));
            }
            spinEditSaldoAcutal.Value = saldo;
        }

        private void FormCobros_Load(object sender, EventArgs e)
        {
            radioGroupTiposPagos.SelectedIndex = 0;
            spinEditAbonoTotal.Value = 0;
            layoutControlGroupDatosDePago.Enabled = false;

            DataTable dt = new DataTable();
            dt = ControllerMostrar.TiposDePagos();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    radioGroupTiposPagos.Properties.Items.Add(new RadioGroupItem(dt.Rows[i]["id_tipo_pago"], Convert.ToString(dt.Rows[i]["tipo_pago"])));
                }
                radioGroupTiposPagos.SelectedIndex = 0;
            }


        }

        private void FormCobros_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void gridViewDetallePromesasPago_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "monto_pagar")
            {

                decimal saldo = Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(e.RowHandle,"saldo1"));
                decimal monto_pagar = Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(e.RowHandle, "monto_pagar"));
                decimal resultado,saldo_cuenta=0,abono_total=0;
                decimal ultimo_monto=0;

                if (monto_pagar > saldo)
                {
                    XtraMessageBox.Show("El monto a pagar debe ser menor al monto total", "Realizando pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewDetallePromesasPago.SetRowCellValue(e.RowHandle, "monto_pagar", ultimo_monto);
                }
                else
                {
                    ultimo_monto = monto_pagar;
                    resultado = saldo - monto_pagar;
                    gridViewDetallePromesasPago.SetRowCellValue(e.RowHandle, "saldo", resultado);

                    for (int i = 0; i < gridViewDetallePromesasPago.DataRowCount; i++)
                    {
                        saldo_cuenta += Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "saldo"));
                        abono_total += Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "monto_pagar"));
                    }
                    spinEditSaldoAcutal.Value = saldo_cuenta;
                    spinEditAbonoTotal.Value = abono_total;
                }
            }
        }

        private void radioGroupTiposPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupTiposPagos.SelectedIndex == 3)
            {
                layoutControlGroupDatosDePago.Enabled = true;
            }
            else
            {
                layoutControlGroupDatosDePago.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool guardar = true;
            string rpta = "",descripcionPago;
            if (radioGroupTiposPagos.SelectedIndex == 3)
            {
                if (string.IsNullOrWhiteSpace(txtNumeroBoleta.Text))
                {
                    XtraMessageBox.Show("Debe escribir el número de boleta","Realizando pagos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    guardar = false;
                }
                if (string.IsNullOrWhiteSpace(dateEditFechaPago.Text))
                {
                    XtraMessageBox.Show("Debe indicar la fecha de pago del deposito", "Realizando pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                }
                if (string.IsNullOrWhiteSpace(txtBanco.Text))
                {
                    XtraMessageBox.Show("Debe indicar el banco de pago", "Realizando pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                }
            }
            if (radioGroupTiposPagos.SelectedIndex != 3)
            {
                guardar = true;
            }
            if (radioGroupTiposPagos.SelectedIndex < 0)
            {
                XtraMessageBox.Show("Debe indicar el tipo de pago", "Realizando pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }

            //for (int i = 0; i < gridViewDetallePromesasPago.DataRowCount; i++)
            //{
            //    if (Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "monto_pagar")) > 0)
            //    {

            //    }
            //    if (Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "monto_pagar")) == 0)
            //    {
            //        XtraMessageBox.Show("EL monto de uno o varios pagos debe ser mayor a 0", "Realizando pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        guardar = false;
            //        break;
            //    }
            //}
            if (guardar)
            {
                MPagoCreditoEncabezado pago = new MPagoCreditoEncabezado();
                pago.MontoRecibido = spinEditAbonoTotal.Value;
                pago.IdTipoPagoCredito = Convert.ToInt32(radioGroupTiposPagos.EditValue);
                pago.IdCliente = id_cliente;
                pago.NombreCliente = txtCliente.Text;
                pago.DetalleRecibo = radioGroupTiposPagos.SelectedIndex == 3 ? "Banco: "+txtBanco.Text+", Número de boleta: "+txtNumeroBoleta.Text+", Fecha de pago: "+dateEditFechaPago.EditValue.ToString() : "";
                pago.Banco = txtBanco.Text;
                pago.NumeroDeposito = txtNumeroBoleta.Text;
                pago.FechaDepositoBanco = Convert.ToDateTime(dateEditFechaPago.EditValue);
                pago.IdUsuario = Configuraciones.Configuraciones.idusuario;
                pago.IdTienda = Configuraciones.Configuraciones.idtienda;
                pago.IdSerie = 7;
                pago.Serie = "A";
                pago.IdOrigenAnticipo = 3;

                List<MPagoCreditoDetalle> detalleInsercion = new List<MPagoCreditoDetalle>();
                for (int i = 0; i < gridViewDetallePromesasPago.DataRowCount; i++)
                {
                    if (Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i,"monto_pagar")) > 0)
                    {
                        MPagoCreditoDetalle detalle = new MPagoCreditoDetalle();
                        detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        detalle.IdPromesaPagoDet = Convert.ToInt32(gridViewDetallePromesasPago.GetRowCellValue(i, "id_promesa_pago_det"));
                        detalle.IdUsuario = Configuraciones.Configuraciones.idusuario;
                        detalle.MontoPagar = Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "monto_pagar"));
                        detalle.MontoCuota = Convert.ToDecimal(gridViewDetallePromesasPago.GetRowCellValue(i, "saldo1"));
                        detalle.MontoInteres = 0;
                        detalleInsercion.Add(detalle);
                    }
                }

                rpta = ControllerPagoCredito.RealizarPago(pago,detalleInsercion);
                if (rpta == "OK")
                {

                    XtraMessageBox.Show("EL PAGO SE REALIZO CORRECTAMENTE",Configuraciones.Configuraciones.NombreDelSistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    gridControlDetallePromesasPago.DataSource = ControllerPagoCredito.MostrarDetallePromesasDePagoParaCobros(id_promesa_pago_enc);
                    gridControlDetallePromesasPago.ForceInitialize();
                    gridViewDetallePromesasPago.BestFitColumns();
                    spinEditAbonoTotal.Value = 0;

                    ControllerMovimientoDinero.GrabarEntrada(ControllerPagoCredito.IdPagoEnc
    , Configuraciones.Configuraciones.idtienda
    , Configuraciones.Configuraciones.idusuario
    , 7
    , spinEditAbonoTotal.Value
    , "A"
    ,  0);

                    if (gridViewDetallePromesasPago.DataRowCount == 0)
                    {
                        string res = "";
                        res = ControllerPagoCredito.CancelarCreditoVenta(id_promesa_pago_enc);
                        if (res!="OK")
                        {
                            XtraMessageBox.Show("Error al cancelar el credito");
                        }
                    }

                    Ventas.Complementos.ImprimirRecibo recibo = new Ventas.Complementos.ImprimirRecibo(ControllerPagoCredito.IdPagoEnc);
                    recibo.ShowDialog();


                    FormBuscarCreditoPorCliente modalBuscar = new FormBuscarCreditoPorCliente(1, principal);
                    modalBuscar.cliente = txtCliente.Text;
                    modalBuscar.id_cliente = this.id_cliente;
                    modalBuscar.ShowDialog();

                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al realizar el pago, por favor consulte a su administrador de datos "+rpta, "Erro del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            FormModalObservaciones modal = new FormModalObservaciones();
            modal.id_promesas_pago_det = Convert.ToInt32(gridViewDetallePromesasPago.GetRowCellValue(gridViewDetallePromesasPago.FocusedRowHandle, "id_promesa_pago_det"));
            modal.numero_cuota = Convert.ToString(gridViewDetallePromesasPago.GetRowCellValue(gridViewDetallePromesasPago.FocusedRowHandle, "cuota"));
            modal.ShowDialog();

        }
    }
}