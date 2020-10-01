using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Ingresos
{
    public partial class SubReporteDeTodosDocumentosDeInvetario : DevExpress.XtraReports.UI.XtraReport
    {
        public SubReporteDeTodosDocumentosDeInvetario()
        {
            InitializeComponent();
        }

        private void SubReporteDeTodosDocumentosDeInvetario_DataSourceDemanded(object sender, EventArgs e)
        {
            this.spMostrar_ReporteDeDocumentosOperadosDetalleTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeDocumentosOperadosDetalle,Configuraciones.Configuraciones.idtienda,Convert.ToInt32(Parameters["id_movimiento_enc"].Value));
        }
    }
}
