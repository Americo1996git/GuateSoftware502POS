using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Requisicioes
{
    public partial class XtraReporteDeRequisicionesPorRangoDeFechas : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReporteDeRequisicionesPorRangoDeFechas()
        {
            InitializeComponent();
        }

        public void mostrarReporte(int idtienda,DateTime fechaIncial, DateTime fechaFinal)
        {
            this.spMostrar_ReporteDeRequisicionesTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeRequisiciones, idtienda,fechaIncial,fechaFinal);
        }

    }
}
