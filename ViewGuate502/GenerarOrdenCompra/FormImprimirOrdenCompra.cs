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

namespace ViewGuate502.GenerarOrdenCompra
{
    
    public partial class FormImprimirOrdenCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int IdOrden, IdTienda;
        public FormImprimirOrdenCompra()
        {
            InitializeComponent();
        }

        private void FormImprimirOrdenCompra_Load(object sender, EventArgs e)
        {
            XtraReporteOrdenDeCompraGenerado reporte = new XtraReporteOrdenDeCompraGenerado();
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.mostrarReporte(IdTienda, IdOrden);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }

        private void FormImprimirOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void printPreviewBarItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}