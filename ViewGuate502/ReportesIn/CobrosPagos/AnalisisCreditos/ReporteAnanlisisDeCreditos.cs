using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.ReportesIn.CobrosPagos.AnalisisCreditos
{
    public partial class ReporteAnanlisisDeCreditos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteAnanlisisDeCreditos()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda,int id_cliente, int opcion)
        {
            this.spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteAnalisisDeCreditoEncabezado,id_tienda,id_cliente,opcion);
        }

        private void ReporteAnanlisisDeCreditos_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
