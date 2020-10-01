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

namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class FormImprimirReporteMorosos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DateTime fecha;
        public int desde, hasta, id_tienda, opcion;
        public decimal monto;
        public bool hastaLaFecha;
        
        public FormImprimirReporteMorosos()
        {
            InitializeComponent();
        }

        private void FormImprimirReporteMorosos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormImprimirReporteMorosos_Load(object sender, EventArgs e)
        {
            ReporteClientesDeudorMoroso reporte = new ReporteClientesDeudorMoroso();
            reporte.MostrarReporte(fecha,desde,hasta,monto,hastaLaFecha,id_tienda,opcion);
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.Parameters["a_la_fecha"].Value = DateTime.Now;
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}