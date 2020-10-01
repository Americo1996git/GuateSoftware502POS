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
    public partial class ReimpresionRecibos : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        ListadoSeriesTableAdapter listadoSeries = new ListadoSeriesTableAdapter();
        tbl_recibos_anticiposTableAdapter tbl_recibos = new tbl_recibos_anticiposTableAdapter();
        public ReimpresionRecibos()
        {
            InitializeComponent();
        }

        private void ReimpresionRecibos_Load(object sender, EventArgs e)
        {
            btnimprimirrecibo.Enabled = false;
            CargarTablas();

            lueserie.Properties.DataSource = dbSoftwareGTDataSet.ListadoSeries;

            lueserie.Properties.DisplayMember = "serie";
            lueserie.Properties.ValueMember = "Id";


            lueserie.Properties.Columns.Add(new LookUpColumnInfo("Id", "Id"));
            lueserie.Properties.Columns.Add(new LookUpColumnInfo("serie", "Serie"));

            lueserie.Properties.Columns["Id"].Visible = false;
        }

        public void CargarTablas()
        {
            listadoSeries.Fill(dbSoftwareGTDataSet.ListadoSeries, 2, 1);
            tbl_recibos.Fill(dbSoftwareGTDataSet.tbl_recibos_anticipos);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (lueserie.EditValue != null && tbcorrelativo.Text != "")
            {
                int id_serie = int.Parse(lueserie.EditValue.ToString());
                int correlativo = int.Parse(tbcorrelativo.Text);
                var envio = (from a in dbSoftwareGTDataSet.tbl_recibos_anticipos
                             where a.id_serie == id_serie &&
                             a.correlativo == correlativo &&
                             a.id_tienda == 1 &&
                             a.activo == true
                             select a).SingleOrDefault();

                if (envio != null)
                {
                    tbenvio.Text = envio.id_recibos_anticipo.ToString();
                    tbserieenvio.Text = envio.serie.ToString();
                    tbcorrelativoenvio.Text = envio.correlativo.ToString();
                    tbidcliente.Text = envio.id_cliente.ToString();
                    tbcliente.Text = envio.nombre_cliente.ToString();
                    tbmontofactura.Text = envio.monto_recibo.ToString();
                    btnimprimirrecibo.Enabled = true;
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

        private void btnimprimirrecibo_Click(object sender, EventArgs e)
        {
            int id_serie = int.Parse(lueserie.EditValue.ToString());
            int correlativo = int.Parse(tbcorrelativo.Text.ToString());

            int id_recibo = (from a in dbSoftwareGTDataSet.tbl_recibos_anticipos
                             where a.id_serie == id_serie &&
                             a.correlativo == correlativo
                             select a.id_recibos_anticipo).Max();

            Complementos.ImprimirRecibo imprimir = new Complementos.ImprimirRecibo(id_recibo);
            imprimir.ShowDialog();
        }
    }
}