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
    public partial class AnulacionFacturas : DevExpress.XtraEditors.XtraForm
    {
        public AnulacionFacturas()
        {
            InitializeComponent();
        }

        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_facturacion_encTableAdapter tbl_facturacion_enc = new tbl_facturacion_encTableAdapter();
        tbl_facturacion_detTableAdapter tbl_facturacion_det = new tbl_facturacion_detTableAdapter();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (tbserieenvio.Text != null && tbcorrelativo.Text != "")
            {
                string serie = lueserie.Text;
                int correlativo = int.Parse(tbcorrelativo.Text);
                var info_envio = (from a in db.tbl_facturacion_enc
                                  where a.activo == true &&
                                  a.serie == serie &&
                                  a.correlativo == correlativo
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
                    tbenvio.Text = info_envio.id_factura.ToString();
                    tbserieenvio.Text = info_envio.serie;
                    tbcorrelativoenvio.Text = info_envio.correlativo.ToString();
                    tbidcliente.Text = info_envio.id_cliente.ToString();
                    tbcliente.Text = info_envio.nombre_cliente;
                    tbmontofactura.Text = info_envio.total.ToString();
                }
            }
        }

        private void AnulacionFacturas_Load(object sender, EventArgs e)
        {
            tbl_facturacion_enc.Fill(db.tbl_facturacion_enc);
            tbl_facturacion_det.Fill(db.tbl_facturacion_det);
            tbl_series.Fill(db.tbl_series);
            var series = (from a in db.tbl_series
                          where a.activo == true
                          && a.id_tienda == Configuraciones.Configuraciones.idtienda
                          && a.id_tipo_documento == 1
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

        private void btnimprimirenvio_Click(object sender, EventArgs e)
        {
            if (tbenvio.Text != "" && tbenvio.Text != null)
            {
                DialogResult anular = MessageBox.Show("¿Desea anular esta factura?", "Anular factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if (anular == DialogResult.Yes)
                    {
                        int id_venta_enc = int.Parse(tbenvio.Text);

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

                        MessageBox.Show("¡Factura anulada exitosamente!", "Anulación de factura", MessageBoxButtons.OK);
                        tbenvio.Text = null;
                        tbserieenvio.Text = null;
                        tbcorrelativoenvio.Text = null;
                        tbidcliente.Text = null;
                        tbcliente.Text = null;
                        tbmontofactura.Text = null;
                        tbl_facturacion_enc.Fill(db.tbl_facturacion_enc);
                        tbl_facturacion_det.Fill(db.tbl_facturacion_det);
                        tbl_series.Fill(db.tbl_series);
                    }
                }
            }
            else
            {
                MessageBox.Show("Busque la factura que desea anular");
            }
        }
    }
}