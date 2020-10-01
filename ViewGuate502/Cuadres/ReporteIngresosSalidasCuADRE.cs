using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Cuadres
{
    public partial class ReporteIngresosSalidasCuADRE : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteIngresosSalidasCuADRE()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda,DateTime fecha_inicial, DateTime fecha_final)
        {
            this.spMostrar_ReporteCuadreDeDiaTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteCuadreDeDia,id_tienda,fecha_inicial,fecha_final);
        }

        private void ReporteIngresosSalidasCuADRE_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
