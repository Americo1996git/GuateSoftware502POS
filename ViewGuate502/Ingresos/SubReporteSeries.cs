using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Ingresos
{
    public partial class SubReporteSeries : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteSeries()
        {
            InitializeComponent();
        }

        private void SubReporteSeries_DataSourceDemanded(object sender, EventArgs e)
        {
          
            this.spMostrar_SeriesDeProductosPorIngresoTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_SeriesDeProductosPorIngreso,Configuraciones.Configuraciones.idtienda,Convert.ToInt32(Parameters["id_ingreso_detalle"].Value));
        }

        private void productName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var value = GetCurrentColumnValue("series");
            e.Cancel = value == null || value.ToString() == string.Empty;
        }
    }
}
