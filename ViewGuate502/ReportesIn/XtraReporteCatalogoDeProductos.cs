using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Reportes
{
    public partial class XtraReporteCatalogoDeProductos : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReporteCatalogoDeProductos()
        {
            InitializeComponent();
        }

        public void mostrarReporte(int id_linea, int id_sublinea, int opcion,int id_tienda)
        {
            this.sPMostrar_ReporteCatalogoProductosTableAdapter.Fill(this.dataSetReportes1.SPMostrar_ReporteCatalogoProductos,id_linea,id_sublinea,opcion,id_tienda);
        }
    }
}
