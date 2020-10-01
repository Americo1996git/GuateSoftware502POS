using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Requisicioes
{
    public partial class XtraReporteDeRequisicion : DevExpress.XtraReports.UI.XtraReport
    {
        

        public XtraReporteDeRequisicion()
        {
            InitializeComponent();

        }

        public void mostrarReporte(int idtienda,  int idcapturapedido)
        {
            this.sPMostrar_ReporteRequisicionTableAdapter.Fill(this.dataSetReportes1.SPMostrar_ReporteRequisicion, idtienda, idcapturapedido);
        }

        private void xrLine1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
