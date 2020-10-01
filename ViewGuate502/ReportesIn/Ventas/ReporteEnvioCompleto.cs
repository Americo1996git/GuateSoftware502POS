using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes.Ventas
{
    public partial class ReporteEnvioCompleto : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteEnvioCompleto()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda, int id_venta_enc)
        {
            this.reporte_EC_ENCTableAdapter.Fill(this.dataSetReportes1.Reporte_EC_ENC,id_tienda,id_venta_enc);
        }

    }
}
