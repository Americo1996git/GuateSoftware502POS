using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ViewGuate502.Cuadres
{
    public partial class FormImprimirReporte : DevExpress.XtraEditors.XtraForm
    {
        public int id_tienda;
        public DateTime fecha_inicial, fecha_final;
        public string tienda;
        public FormImprimirReporte()
        {
            InitializeComponent();
        }

        private void FormImprimirReporte_Load(object sender, EventArgs e)
        {
            ReporteIngresosSalidasCuADRE reporte = new ReporteIngresosSalidasCuADRE();
            reporte.Parameters["tienda"].Value = tienda;
            reporte.Parameters["fecha_emision"].Value = DateTime.Now.Date; 
            reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            reporte.Parameters["fecha_final"].Value = fecha_final;
            reporte.MostrarReporte(id_tienda,fecha_inicial,fecha_final);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}