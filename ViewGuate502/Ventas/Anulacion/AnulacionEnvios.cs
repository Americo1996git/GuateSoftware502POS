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

namespace ViewGuate502.Ventas.Anulacion
{
    public partial class AnulacionEnvios : DevExpress.XtraEditors.XtraForm
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

        public AnulacionEnvios()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(tbserieenvio.Text != null && tbcorrelativo.Text != "")
            {
                string serie = lueserie.Text;
                int correlativo = int.Parse(tbcorrelativo.Text);
                var info_envio = (from a in db.tbl_ventas_enc
                                  where a.activo == true &&
                                  a.serie == serie &&
                                  a.correlativo == correlativo &&
                                  a.id_tienda == Configuraciones.Configuraciones.idtienda
                                  select a).FirstOrDefault();

                if (info_envio == null)
                {
                    MessageBox.Show("No existen resultados!");
                    tbenvio.Text = null;
                    tbserieenvio.Text = null;
                    tbcorrelativoenvio.Text = null;
                    tbidcliente.Text = null;
                    tbcliente.Text = null;
                    tbmontofactura.Text = null;
                }
                else
                {
                    tbenvio.Text = info_envio.id_venta_enc.ToString();
                    tbserieenvio.Text = info_envio.serie;
                    tbcorrelativoenvio.Text = info_envio.correlativo.ToString();
                    tbidcliente.Text = info_envio.id_cliente.ToString();
                    tbcliente.Text = info_envio.nombre_cliente;
                    tbmontofactura.Text = info_envio.total.ToString();
                }
            }
        }

        private void AnulacionEnvios_Load(object sender, EventArgs e)
        {
            CargarTablas();
            var series = (from a in db.tbl_series
                          where a.activo == true
                          && a.id_tienda == Configuraciones.Configuraciones.idtienda
                          && a.id_tipo_documento == 4
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

        private void btnanularenvio_Click(object sender, EventArgs e)
        {
            if(tbenvio.Text != "" && tbenvio.Text != null)
            {
                DialogResult anular = MessageBox.Show("¿Desea anular este envío?", "Anular envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if (anular == DialogResult.Yes)
                    {
                        CargarTablas();
                        int id_venta_enc = int.Parse(tbenvio.Text);
                        var anticipos = (from a in db.tbl_venta_abonos
                                         join b in db.tbl_ventas_promesas_pago_det on a.id_promesa_pago_det equals b.id_promesa_pago_det
                                         join c in db.tbl_ventas_promesas_pago_enc on b.id_promesa_pago equals c.id_promesa_pago
                                         where c.id_venta_enc == id_venta_enc
                                         && a.activo == true
                                         select a).ToList();

                        foreach(var f in anticipos)
                        {
                            int id_recibo_anticipo = f.id_recibo_anticipo;
                            var recibos_ant = (from a in db.tbl_recibos_anticipos
                                               where a.id_recibos_anticipo == id_recibo_anticipo
                                               select a).ToList();

                            recibos_ant.ForEach(a => { a.activo = true; });
                            tbl_recibos_anticipos.Update(db);
                        }

                        anticipos.ForEach(a => { a.activo = false; });
                        tbl_venta_abonos.Update(db);

                        var promesas_enc = (from a in db.tbl_ventas_promesas_pago_enc
                                            join b in db.tbl_ventas_promesas_pago_det on a.id_promesa_pago equals b.id_promesa_pago
                                            where a.id_venta_enc == id_venta_enc
                                            select new
                                            {
                                                a,
                                                b
                                            }).ToList();

                        promesas_enc.ForEach(a => { a.a.activo = false; a.b.activo = false; });
                        tbl_ventas_promesas_pago_enc.Update(db);
                        tbl_ventas_promesas_pago_det.Update(db);

                        if (tbserieenvio.Text.ToUpper() == "B")
                        {
                            var auditoria_ventas = (from a in db.tbl_auditoria_ventas
                                                    where a.id_venta_enc == id_venta_enc
                                                    select a).ToList();

                            auditoria_ventas.ForEach(a => { a.activo = false; });
                            tbl_auditoria_ventas.Update(db);

                            var auditoria_doc = (from a in db.tbl_auditoria_revision_doctos
                                                 where a.id_venta_enc == id_venta_enc
                                                 select a).ToList();

                            auditoria_doc.ForEach(a => { a.activo = false; });
                            tbl_auditoria_ventas.Update(db);

                            var fiadores = (from a in db.tbl_venta_fiadores
                                            where a.id_venta_enc == id_venta_enc
                                            select a).ToList();
                            fiadores.ForEach(a => a.activo = false);
                            tbl_venta_fiadores.Update(db);

                            var autorizaciones = (from a in db.tbl_ventas_aprobacion_credito
                                                  where a.id_venta_enc == id_venta_enc
                                                  select a).ToList();
                            autorizaciones.ForEach(a => a.activo = false);
                            tbl_ventas_aprobacion_credito.Update(db);

                        }

                        var facturas = (from a in db.tbl_facturacion_enc
                                        join b in db.tbl_facturacion_det on a.id_factura equals b.id_factura
                                        where a.id_factura == id_venta_enc
                                        select new
                                        {
                                            a,
                                            b
                                        }).ToList();

                        facturas.ForEach(a => a.a.activo = false);
                        facturas.ForEach(a => a.b.activo = false);

                        tbl_facturacion_enc.Update(db);
                        tbl_facturacion_det.Update(db);

                        var venta = (from a in db.tbl_ventas_enc
                                     join b in db.tbl_ventas_det on a.id_venta_enc equals b.id_venta_enc
                                     where a.id_venta_enc == id_venta_enc
                                     select new
                                     {
                                         a,
                                         b
                                     }).ToList();

                        foreach(var f in venta.Select(a => a.b))
                        {
                            (from a in db.ExistenciaDetalle
                             where a.idexistenciadetalle == f.id_existencia_detalle
                             select a).ToList().ForEach(a => { a.stock = (a.stock + f.cantidad); });
                            tbl_existencia_detalle.Update(db);
                        }

                        venta.ForEach(a => { a.a.activo = false; a.b.activo = false; });
                        tbl_ventas_enc.Update(db);
                        tbl_ventas_det.Update(db);

                        CargarTablas();

                        MessageBox.Show("¡Envío anulado exitosamente!", "Anulación de envío", MessageBoxButtons.OK);
                        tbenvio.Text = null;
                        tbserieenvio.Text = null;
                        tbcorrelativoenvio.Text = null;
                        tbidcliente.Text = null;
                        tbcliente.Text = null;
                        tbmontofactura.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Busque el envío que desea anular");
            }
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
    }
}