using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.Ventas
{
    public partial class SubRepPromesasPago : DevExpress.XtraReports.UI.XtraReport
    {
        public SubRepPromesasPago()
        {
            InitializeComponent();
        }

        private void SubRepPromesasPago_DataSourceDemanded(object sender, EventArgs e)
        {
            this.reporte_EC_PPTableAdapter1.Fill(this.dataSetReportes1.Reporte_EC_PP,Convert.ToInt32(Parameters["id_venta_enc"].Value));
        }
    }
}
