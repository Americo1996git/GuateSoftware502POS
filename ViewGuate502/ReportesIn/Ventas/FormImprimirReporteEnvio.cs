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

namespace ViewGuate502.Reportes.Ventas
{
    public partial class FormImprimirReporteEnvio : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_tienda, id_venta_enc;
        public FormImprimirReporteEnvio()
        {
            InitializeComponent();
        }

        private void FormImprimirReporteEnvio_Load(object sender, EventArgs e)
        {
            ReporteEnvioCompleto reporte = new ReporteEnvioCompleto();
            reporte.MostrarReporte(id_tienda,id_venta_enc);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}