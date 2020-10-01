using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class ReporteClientesDeudorMoroso : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteClientesDeudorMoroso()
        {
            InitializeComponent();
        }
        public void MostrarReporte(DateTime fecha, int desde, int hasta, decimal monto, bool hastaLaFecha, int idtienda, int opcion)
        {
            this.spMostrar_ReporteClienteDeudorTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteClienteDeudor,fecha,desde,hasta,monto,hastaLaFecha,idtienda,opcion);
        }

        private void ReporteClientesDeudorMoroso_DataSourceDemanded(object sender, EventArgs e)
        {

        }

        private void xrTableCell2_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            if (e.Brick.Text != string.Empty)
            {
                string dat = "";
                string[] dato_final;
                dat = e.Brick.Text;
                dato_final = dat.Split(':');
                FormFiadores modal = new FormFiadores();
                modal.numero_reporte = 1;
                modal.id_cliente = int.Parse(dato_final[1]);
                modal.ShowDialog();
            }

        }

        private void quantity_PreviewClick(object sender, PreviewMouseEventArgs e)
        {

          
            Cobros.FormBuscarCreditoPorCliente modal = new Cobros.FormBuscarCreditoPorCliente();
            modal.texto_inciail = e.Brick.Text;
            modal.ShowDialog();
        }
    }
}
