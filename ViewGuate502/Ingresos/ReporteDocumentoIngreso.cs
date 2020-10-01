using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Ingresos
{
    public partial class ReporteDocumentoIngreso : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteDocumentoIngreso()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int codigo, int id_tienda, int id_tipo_documento_inventario, int id_origen, int id_destino, bool ingresado, int opcion)
        {
            this.spMostrar_ReporteDeDocumentoGeneradoTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeDocumentoGenerado, codigo,id_tienda,id_tipo_documento_inventario,id_origen,id_destino, ingresado, opcion);
        }

        private void ReporteDocumentoIngreso_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
