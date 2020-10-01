using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ViewGuate502.SalidasDinero.Gastos
{
    public partial class ReporteSalidasGastos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteSalidasGastos()
        {
            InitializeComponent();
        }
        public void MostrarReporte(int id_tienda,int id_tipo_salida_dinero, int id_usuario, DateTime fecha_inicial,DateTime fecha_final,int opcion)
        {
            this.spMostrar_ReporteDeSalidasDineroTableAdapter1.Fill(this.dataSetReportes1.SPMostrar_ReporteDeSalidasDinero,id_tienda,fecha_inicial,fecha_final,id_tipo_salida_dinero,id_usuario,opcion);
        }

        private void ReporteSalidasGastos_DataSourceDemanded(object sender, EventArgs e)
        {

        }
    }
}
