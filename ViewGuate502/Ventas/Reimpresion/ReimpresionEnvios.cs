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

namespace ViewGuate502.Ventas.Reimpresion
{
    public partial class ReimpresionEnvios : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        ListadoSeriesTableAdapter listadoSeries = new ListadoSeriesTableAdapter();
        tbl_ventas_encTableAdapter tbl_ventas = new tbl_ventas_encTableAdapter();
        public ReimpresionEnvios()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (lueserie.EditValue != null && tbcorrelativo.Text != "")
            {
                string serie = lueserie.Text;
                int correlativo = int.Parse(tbcorrelativo.Text);
                var envio = (from a in dbSoftwareGTDataSet.tbl_ventas_enc
                             where a.serie == lueserie.Text &&
                             a.correlativo == correlativo &&
                             a.id_tienda == Configuraciones.Configuraciones.idtienda &&
                             a.activo == true
                             select a).SingleOrDefault();

                if(envio != null)
                {
                    if(lueserie.Text.ToUpper() == "A")
                    {
                        tbenvio.Text = envio.id_venta_enc.ToString();
                        tbserieenvio.Text = envio.serie.ToString();
                        tbcorrelativoenvio.Text = envio.correlativo.ToString();
                        tbidcliente.Text = envio.id_cliente.ToString();
                        tbcliente.Text = envio.nombre_cliente.ToString();
                        tbmontofactura.Text = envio.total.ToString();
                        btnimprimirenvio.Enabled = true;
                        btnreimpcontrato.Enabled = false;
                        btnreimppromesas.Enabled = false;
                    }
                    else if(lueserie.Text.ToUpper() == "B")
                    {
                        tbenvio.Text = envio.id_venta_enc.ToString();
                        tbserieenvio.Text = envio.serie.ToString();
                        tbcorrelativoenvio.Text = envio.correlativo.ToString();
                        tbidcliente.Text = envio.id_cliente.ToString();
                        tbcliente.Text = envio.nombre_cliente.ToString();
                        tbmontofactura.Text = envio.total.ToString();
                        btnimprimirenvio.Enabled = false;
                        btnreimpcontrato.Enabled = true;
                        btnreimppromesas.Enabled = true;
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el número de serie y correlativo de la factura para hacer la búsqueda.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ReimpresionEnvios_Load(object sender, EventArgs e)
        {
            btnimprimirenvio.Enabled = false;
            btnreimpcontrato.Enabled = false;
            btnreimppromesas.Enabled = false;
            CargarTablas();

            lueserie.Properties.DataSource = dbSoftwareGTDataSet.ListadoSeries;

            lueserie.Properties.DisplayMember = "serie";
            lueserie.Properties.ValueMember = "id_serie";


            lueserie.Properties.Columns.Add(new LookUpColumnInfo("id_serie", "Id"));
            lueserie.Properties.Columns.Add(new LookUpColumnInfo("serie", "Serie"));

            lueserie.Properties.Columns["id_serie"].Visible = false;
        }

        public void CargarTablas()
        {
            listadoSeries.Fill(dbSoftwareGTDataSet.ListadoSeries, 4, 1);
            tbl_ventas.Fill(dbSoftwareGTDataSet.tbl_ventas_enc);
        }

        private void btnreimpcontrato_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirContrato imprimirContrato = new Complementos.ImprimirContrato(int.Parse(tbenvio.Text));
            imprimirContrato.ShowDialog();
        }

        private void btnreimppromesas_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirPromesasPago imprimirPromesasPago = new Complementos.ImprimirPromesasPago(int.Parse(tbenvio.Text));
            imprimirPromesasPago.ShowDialog();
        }

        private void btnimprimirenvio_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirEnvio imprimirEnvio = new Complementos.ImprimirEnvio(int.Parse(tbenvio.Text));
            imprimirEnvio.ShowDialog();
        }
    }
}