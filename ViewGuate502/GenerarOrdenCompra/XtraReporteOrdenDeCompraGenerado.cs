using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.GenerarOrdenCompra
{
    public partial class XtraReporteOrdenDeCompraGenerado : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReporteOrdenDeCompraGenerado()
        {
            InitializeComponent();
        }
        public void mostrarReporte(int idtienda, int idordenDeCompra)
        {
            this.spMostrar_ReporteOrdenDeCompraDetalladoTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteOrdenDeCompraDetallado, idtienda, idordenDeCompra);
        }

    }
}
