using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Cobros
{
    public partial class SubReporteEstadoDeCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteEstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void SubReporteEstadoDeCuenta_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_DetalleDePagoPorCuotaTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_DetalleDePagoPorCuota, Convert.ToInt32(Parameters["id_promesa_pago_det"].Value));
        }

        private void detailTable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var value = GetCurrentColumnValue("correlativo");
            e.Cancel = value == null || value.ToString() == string.Empty;
        }
    }
}
