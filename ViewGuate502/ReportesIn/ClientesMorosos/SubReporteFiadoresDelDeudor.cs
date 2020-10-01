using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.ClientesMorosos
{
    public partial class SubReporteFiadoresDelDeudor : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteFiadoresDelDeudor()
        {
            InitializeComponent();
        }

        private void SubReporteFiadoresDelDeudor_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_ReporteFiadoresDeClienteDeudorTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteFiadoresDeClienteDeudor,Convert.ToInt32(Parameters["id_venta_enc"].Value));
        }
    }
}
