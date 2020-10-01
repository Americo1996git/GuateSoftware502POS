using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Verificaciones
{
    public partial class ReporteHistorialPreciosCostos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteHistorialPreciosCostos()
        {
            InitializeComponent();
        }
        public void MostrarReporte(DateTime fecha_inicial, DateTime fecha_final, int id_producto)
        {
            this.spMostrar_ReporteDeHistorialDePreciosTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeHistorialDePrecios, fecha_inicial, fecha_final, id_producto);
        }
    }
}
