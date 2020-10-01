using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.Ventas
{
    public partial class SubRepAprobaciones : DevExpress.XtraReports.UI.XtraReport
    {
        public SubRepAprobaciones()
        {
            InitializeComponent();
        }

        private void SubRepAprobaciones_DataSourceDemanded(object sender, EventArgs e)
        {
            this.reporte_EC_LACTableAdapter1.Fill(this.dataSetReportes1.Reporte_EC_LAC,Convert.ToInt32(Parameters["id_venta_enc"].Value));
        }
    }
}
