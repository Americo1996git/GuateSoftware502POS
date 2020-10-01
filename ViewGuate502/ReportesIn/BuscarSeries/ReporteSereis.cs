using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.BuscarSeries
{
    public partial class ReporteSereis : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteSereis()
        {
            InitializeComponent();
        }
        public void MostarReprote(int id_tienda, string serie)
        {
            this.spMostrar_BuscarSeriesTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_BuscarSeries,id_tienda,serie);
        }
        private void ReporteSereis_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
