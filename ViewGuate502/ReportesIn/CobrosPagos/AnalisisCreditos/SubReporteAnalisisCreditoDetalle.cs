using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.ReportesIn.CobrosPagos.AnalisisCreditos
{
    public partial class SubReporteAnalisisCreditoDetalle : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteAnalisisCreditoDetalle()
        {
            InitializeComponent();
        }

        private void SubReporteAnalisisCreditoDetalle_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_ReporteAnalisisDeCreditoDetalleTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteAnalisisDeCreditoDetalle,Convert.ToInt32(Parameters["id_promesa_pago"].Value));
        }
    }
}
