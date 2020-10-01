using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.ReportesIn.CobrosPagos.IngresosDiarios
{
    public partial class ReporteIngresosDiarios : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteIngresosDiarios()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda, int id_usuario, int id_tipo_doc, DateTime fecha_inicial, DateTime fecha_final, int opcion)
        {
            this.spMostrar_ReportePagosEfecutadosPorClienteTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReportePagosEfecutadosPorCliente, id_tienda, id_usuario, id_tipo_doc, fecha_inicial, fecha_final, opcion);
        }

        private void ReporteIngresosDiarios_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
