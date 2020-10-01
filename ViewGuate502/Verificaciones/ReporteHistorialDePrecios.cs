using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.Verificaciones
{
    public partial class ReporteHistorialDePrecios : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteHistorialDePrecios()
        {
            InitializeComponent();
        }
        public void MostrarReporte(DateTime fecha_inicial, DateTime fecha_final,int id_producto)
        {
            this.spMostrar_ReporteDeHistorialDePreciosTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeHistorialDePrecios,fecha_inicial,fecha_final,id_producto);
        }

    }
}
