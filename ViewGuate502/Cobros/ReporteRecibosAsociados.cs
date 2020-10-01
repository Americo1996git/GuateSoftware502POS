using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Cobros
{
    public partial class ReporteRecibosAsociados : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteRecibosAsociados()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_venta_enc,int correlativo)
        {
            this.spMostrar_ReporteDeRecibosAsociadosTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeRecibosAsociados,id_venta_enc,correlativo);
        }

    }
}
