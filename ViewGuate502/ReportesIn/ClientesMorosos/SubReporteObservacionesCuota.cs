using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class SubReporteObservacionesCuota : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteObservacionesCuota()
        {
            InitializeComponent();
        }

        private void SubReporteObservacionesCuota_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_ReportePrimeraObservacionDeCuotsTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReportePrimeraObservacionDeCuots, Convert.ToInt32(Parameters["id_ventas_promesas_pago_det"].Value),Configuraciones.Configuraciones.idtienda);
        }

        private void detailTable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var value = GetCurrentColumnValue("descripcion");
            e.Cancel = value == null || value.ToString() == string.Empty;
        }
    }
}
