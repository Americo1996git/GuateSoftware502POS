using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Cobros
{
    public partial class SubReporteObservacionesEstadoDeCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteObservacionesEstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void SubReporteObservacionesEstadoDeCuenta_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_ReporteObsevacionesEstadoDeCuentaTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteObsevacionesEstadoDeCuenta, Convert.ToInt32(Parameters["id_promesa_pago_det"].Value));
        }

        private void detailTable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var value = GetCurrentColumnValue("descripcion");
            e.Cancel = value == null || value.ToString() == string.Empty;
        }
    }
}
