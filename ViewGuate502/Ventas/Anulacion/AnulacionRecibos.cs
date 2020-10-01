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
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using DevExpress.XtraEditors.Controls;
using ControllerSoft502;
using MODELOS502;

namespace ViewGuate502.Ventas.Anulacion
{
    public partial class AnulacionRecibos : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        tbl_ventas_encTableAdapter tbl_ventas_enc = new tbl_ventas_encTableAdapter();
        tbl_ventas_detTableAdapter tbl_ventas_det = new tbl_ventas_detTableAdapter();
        tbl_ventas_promesas_pago_encTableAdapter tbl_ventas_promesas_pago_enc = new tbl_ventas_promesas_pago_encTableAdapter();
        tbl_ventas_promesas_pago_detTableAdapter tbl_ventas_promesas_pago_det = new tbl_ventas_promesas_pago_detTableAdapter();
        tbl_venta_abonosTableAdapter tbl_venta_abonos = new tbl_venta_abonosTableAdapter();
        tbl_auditoria_ventasTableAdapter tbl_auditoria_ventas = new tbl_auditoria_ventasTableAdapter();
        tbl_auditoria_revision_doctosTableAdapter tbl_auditoria_revision_doctos = new tbl_auditoria_revision_doctosTableAdapter();
        tbl_venta_fiadoresTableAdapter tbl_venta_fiadores = new tbl_venta_fiadoresTableAdapter();
        tbl_ventas_aprobacion_creditoTableAdapter tbl_ventas_aprobacion_credito = new tbl_ventas_aprobacion_creditoTableAdapter();
        ExistenciaDetalleTableAdapter tbl_existencia_detalle = new ExistenciaDetalleTableAdapter();
        tbl_recibos_anticiposTableAdapter tbl_recibos_anticipos = new tbl_recibos_anticiposTableAdapter();
        tbl_facturacion_encTableAdapter tbl_facturacion_enc = new tbl_facturacion_encTableAdapter();
        tbl_facturacion_detTableAdapter tbl_facturacion_det = new tbl_facturacion_detTableAdapter();


        public AnulacionRecibos()
        {
            InitializeComponent();
        }

        private void AnulacionRecibos_Load(object sender, EventArgs e)
        {
            CargarTablas();
            var series = (from a in db.tbl_series
                          where a.activo == true
                          && a.id_tienda == Configuraciones.Configuraciones.idtienda
                          && a.id_tipo_documento == 2
                          select new
                          {
                              a.id_serie,
                              a.serie
                          }).ToList();

            lueserie.Properties.DataSource = series;
            lueserie.Properties.DisplayMember = "serie";
            lueserie.Properties.ValueMember = "id_serie";


            if (lueserie.Properties.Columns.Count == 0)
            {
                lueserie.Properties.Columns.Add(new LookUpColumnInfo("id_serie", "Id"));
                lueserie.Properties.Columns.Add(new LookUpColumnInfo("serie", "Series"));
            }

            lueserie.Properties.Columns[0].Visible = false;
        }

        public void CargarTablas()
        {
            tbl_series.Fill(db.tbl_series);
            tbl_ventas_enc.Fill(db.tbl_ventas_enc);
            tbl_ventas_det.Fill(db.tbl_ventas_det);
            tbl_ventas_promesas_pago_enc.Fill(db.tbl_ventas_promesas_pago_enc);
            tbl_ventas_promesas_pago_det.Fill(db.tbl_ventas_promesas_pago_det);
            tbl_venta_abonos.Fill(db.tbl_venta_abonos);
            tbl_auditoria_ventas.Fill(db.tbl_auditoria_ventas);
            tbl_auditoria_revision_doctos.Fill(db.tbl_auditoria_revision_doctos);
            tbl_venta_fiadores.Fill(db.tbl_venta_fiadores);
            tbl_ventas_aprobacion_credito.Fill(db.tbl_ventas_aprobacion_credito);
            tbl_existencia_detalle.Fill(db.ExistenciaDetalle);
            tbl_recibos_anticipos.Fill(db.tbl_recibos_anticipos);
            tbl_facturacion_enc.Fill(db.tbl_facturacion_enc);
            tbl_facturacion_det.Fill(db.tbl_facturacion_det);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (tbserieenvio.Text != null && tbcorrelativo.Text != "")
            {
                DataTable dt = new DataTable();
                string serie = lueserie.Text;
                int correlativo = int.Parse(tbcorrelativo.Text);
                var info_recibo = (from a in db.tbl_recibos_anticipos
                                   where a.activo == true &&
                                   a.serie == serie &&
                                   a.correlativo == correlativo &&
                                   a.id_tienda == Configuraciones.Configuraciones.idtienda
                                  select a).FirstOrDefault();


                if (info_recibo == null)
                {
                    MessageBox.Show("No existen resultados!");
                    tbenvio.Text = null;
                    tbserieenvio.Text = null;
                    tbcorrelativoenvio.Text = null;
                    tbcliente.Text = null;
                    tbmontofactura.Text = null;
                }
                else
                {
                    tbenvio.Text = info_recibo.id_recibos_anticipo.ToString();
                    tbserieenvio.Text = info_recibo.serie;
                    tbcorrelativoenvio.Text = info_recibo.correlativo.ToString();
                    tbcliente.Text = info_recibo.nombre_cliente;
                    tbmontofactura.Text = info_recibo.monto_recibo.ToString();

                    dt = ControllerPagoCredito.MostrarDetalleDePago(Configuraciones.Configuraciones.idtienda, info_recibo.id_recibos_anticipo);
                    if (dt.Rows.Count > 0)
                    {
                        gridControlDetalleDePago.Visible = true;
                        gridControlDetalleDePago.DataSource = dt;
                        gridControlDetalleDePago.ForceInitialize();
                        gridViewDetallePago.BestFitColumns();
                    }
                    
                }
            }
        }

        private void btnimprimirenvio_Click(object sender, EventArgs e)
        {
            if (tbenvio.Text != "" && tbenvio.Text != null)
            {
                DialogResult anular = MessageBox.Show("¿Desea anular este recibo?", "Anular recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if (anular == DialogResult.Yes)
                    {
                        string rpta = "";
                        CargarTablas();
                        int id_recibo = int.Parse(tbenvio.Text);

                        (from a in db.tbl_venta_abonos
                         where a.id_recibo_anticipo == id_recibo
                         && a.activo == true
                         select a).ToList().ForEach(a => a.activo = false);

                        tbl_venta_abonos.Update(db);

                        var recibos = (from a in db.tbl_recibos_anticipos
                                       where a.id_recibos_anticipo == id_recibo
                                       && a.activo == true
                                       select a).ToList();

                        recibos.ForEach(a => a.activo = false);


                        List<MPagoCreditoDetalle> detalleInsercion = new List<MPagoCreditoDetalle>();
                        for (int i = 0; i < gridViewDetallePago.DataRowCount; i++)
                        {
                            MPagoCreditoDetalle detalle = new MPagoCreditoDetalle();
                            detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                            detalle.IdPromesaPagoDet = Convert.ToInt32(gridViewDetallePago.GetRowCellValue(i, "id_promesa_pago_det"));
                            detalle.MontoCuota = Convert.ToDecimal(gridViewDetallePago.GetRowCellValue(i, "monto"));
                            detalle.Opcion = 1;
                            detalleInsercion.Add(detalle);
                        }

                        rpta = ControllerPagoCredito.ActualizarEstadoDelPago(detalleInsercion);

                        tbl_recibos_anticipos.Update(db);



                        CargarTablas();
                        if (rpta == "OK")
                        {
                            MessageBox.Show("¡Recibo anulado exitosamente!", "Anulación de recibo", MessageBoxButtons.OK);
                            tbenvio.Text = null;
                            tbserieenvio.Text = null;
                            tbcorrelativoenvio.Text = null;
                            tbcliente.Text = null;
                            tbmontofactura.Text = null;
                            this.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Busque el recibo que desea anular");
            }
        }
    }
}