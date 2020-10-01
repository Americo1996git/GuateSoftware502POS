using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using System.Data;
using System.Linq;

namespace ViewGuate502.Cobros
{
    public partial class ReporteEstadoDeCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_seriesTableAdapter tbl_Series = new tbl_seriesTableAdapter();
        tbl_ventas_encTableAdapter tbl_Ventas_Enc = new tbl_ventas_encTableAdapter();
        public int id_serie = 2;
        int id_venta_enc = 0;
        int correlativo = 0;
        int id_tienda = 1;

        public ReporteEstadoDeCuenta()
        {
            InitializeComponent();
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.dbSoftwareGTDataSet.Tienda);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_series' Puede moverla o quitarla según sea necesario.
            this.tbl_seriesTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_series);
            this.tbl_Ventas_Enc.Fill(db.tbl_ventas_enc);
            tbl_Series.Fill(db.tbl_series);
       
        }
        public void MostrarReporte(int id)
        {
            this.spMostrar_ReporteEstadoDeCuentaTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteEstadoDeCuenta, id);
        }

        private void xrLabel7_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            string res = e.Brick.Text;
            string[] val = res.Split(':');

            //Ventas.Reportes1.VistaEnvioCompleto vistaEnvioCompleto = new
            //Ventas.Reportes1.VistaEnvioCompleto(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(val[1]));
            //vistaEnvioCompleto.ShowDialog();
        }

        private void xrLabel4_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            //ViewGuate502.Reportes.Ventas.FormImprimirReporteEnvio modal = new ViewGuate502.Reportes.Ventas.FormImprimirReporteEnvio();
            //modal.id_tienda = Configuraciones.Configuraciones.idtienda;
            //modal.id_venta_enc = Convert.ToInt32(e.Brick.Text);
            //modal.ShowDialog();


            id_venta_enc = (from a in db.tbl_ventas_enc
                            where a.id_serie == id_serie
                            && a.correlativo == Convert.ToInt32(e.Brick.Text)
                            select a.id_venta_enc).FirstOrDefault();

            Ventas.Reportes.VistaEnvioCompleto vistaEnvioCompleto = new Ventas.Reportes.VistaEnvioCompleto(Configuraciones.Configuraciones.idtienda, id_venta_enc);
            vistaEnvioCompleto.ShowDialog();
        }

        private void ReporteEstadoDeCuenta_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
