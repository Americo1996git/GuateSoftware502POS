using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.MaestroProductos
{
    public partial class XtraReportMaestroDeProductos : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportMaestroDeProductos()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda,int id_producto, int id_documento, DateTime fecha_inicial, DateTime fecha_final, int opcion)
        {
            this.spMostrar_ReporteMaestroDeProductosTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteMaestroDeProductos,id_tienda,id_producto,id_documento,fecha_inicial,fecha_final,opcion);
        }

        private void XtraReportMaestroDeProductos_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
