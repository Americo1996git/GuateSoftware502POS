using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Ingresos
{
    public partial class ReporteDeTodosDocumentosDeInvetario : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteDeTodosDocumentosDeInvetario()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int codigo, int id_tienda, int id_tipo_documento, int id_origine, int id_destino,DateTime fecha_inicial, DateTime fecha_final)
        {
            this.spMostrar_ReporteDeDocumentosOperadosTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeDocumentosOperados,codigo,id_tienda,id_tipo_documento,id_origine,id_destino,fecha_inicial,fecha_final);
        }

        private void ReporteDeTodosDocumentosDeInvetario_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
