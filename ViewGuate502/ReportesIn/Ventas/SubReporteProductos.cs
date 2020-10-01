using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.Ventas
{
    public partial class SubReporteProductos : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteProductos()
        {
            InitializeComponent();
        }

        private void SubReporteProductos_DataSourceDemanded(object sender, EventArgs e)
        {
            this.reporte_EC_PRDTableAdapter4.Fill(this.dbSoftwareGTDataSet11.Reporte_EC_PRD, Convert.ToInt32(Parameters["id_venta_enc"].Value));
        }
    }
}
