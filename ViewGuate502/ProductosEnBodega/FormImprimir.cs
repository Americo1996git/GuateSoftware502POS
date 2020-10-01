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

namespace ViewGuate502.ProductosEnBodega
{
    public partial class FormImprimir : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id;
        public FormImprimir()
        {
            InitializeComponent();
        }

        private void FormImprimir_Load(object sender, EventArgs e)
        {

            //ReporteProductosEnBodega reporte = new ReporteProductosEnBodega();
            //reporte.mostrarReporte(id);
            //reporte.CreateDocument();
            //documentViewer1.DocumentSource = reporte;
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}