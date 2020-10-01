using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.Ventas
{
    public partial class SubRepFiadores : DevExpress.XtraReports.UI.XtraReport
    {
        public SubRepFiadores()
        {
            InitializeComponent();
        }

        private void SubRepFiadores_DataSourceDemanded(object sender, EventArgs e)
        {
            this.reporte_EC_LFTableAdapter1.Fill(this.dataSetReportes1.Reporte_EC_LF,Convert.ToInt32(Parameters["id_venta_enc"].Value));
        }
    }
}
