using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;
using ControllerSoft502;
namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class SubReportePormesasDePagoCliente : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReportePormesasDePagoCliente()
        {
            InitializeComponent();
        }

   

        private void SubReportePormesasDePagoCliente_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_PromesasDePagoDeClienteVentaEnvioTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_PromesasDePagoDeClienteVentaEnvio, Convert.ToInt32(Parameters["id_promesa_pago_det"].Value));
        }

  

        private void xrTableCell2_PreviewClick(object sender, PreviewMouseEventArgs e)
        {

            //DataRowView dataRow = e.Brick.Value as DataRowView;
            string dat = "";
            string[] dato_final;
            dat = e.Brick.Text;
            dato_final = dat.Split(':');
            DataTable dt;
            dt = ControllerClientesMorosos.ObtenerNumeroDeCuota(Configuraciones.Configuraciones.idtienda,int.Parse(dato_final[1]));
            if (dt.Rows.Count > 0)
            {
                Cobros.FormModalObservaciones modal = new Cobros.FormModalObservaciones();
                modal.id_promesas_pago_det = int.Parse(dato_final[1]);
                modal.numero_cuota = Convert.ToString(dt.Rows[0]["numero_cutoa"]);
                modal.ShowDialog();
            }

        }

        private void detailTable_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            //DataRowView dataRow = e.Brick.Value as DataRowView;
            MessageBox.Show(GetCurrentColumnValue("numero_cutoa").ToString());
        }

        private void detailTable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTable)sender).Tag = GetCurrentRow();
            
        }

      

        private void quantity_PreviewClick(object sender, PreviewMouseEventArgs e)
        {

            Cobros.FormImprimirEstadoDeCuenta modal = new Cobros.FormImprimirEstadoDeCuenta();
            modal.id_promesas_enca = int.Parse(e.Brick.Text);
            modal.cliente = "";
            modal.producto = "";
            modal.ShowDialog();
        }

        private void xrTableCell12_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            string dat = "";
            string[] dato_final;
            dat = e.Brick.Text;
            dato_final = dat.Split(':');

            FormFiadores modal = new FormFiadores();
            modal.id_venta_enc = int.Parse(dato_final[1]);
            modal.ShowDialog();
        }
    }
}
