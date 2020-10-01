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

namespace ViewGuate502.Cobros
{
    public partial class FormImprimirReporteRecibosAsociados : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_ventas_enc;
        public int correlativo;
        public FormImprimirReporteRecibosAsociados()
        {
            InitializeComponent();
        }

        private void FormImprimirReporteRecibosAsociados_Load(object sender, EventArgs e)
        {
            ReporteRecibosAsociados reporte = new ReporteRecibosAsociados();
            reporte.MostrarReporte(id_ventas_enc,correlativo);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}