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

namespace ViewGuate502.Productos
{
    public partial class FormImprimirProducto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_linea,  id_sublinea, opcion,id_tienda;
        public string tienda;
        public DateTime fecha;

        private void FormImprimirProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormImprimirProducto()
        {
            InitializeComponent();
        }

        private void FormImprimirProducto_Load(object sender, EventArgs e)
        {
            Reportes.XtraReporteCatalogoDeProductos reporte = new Reportes.XtraReporteCatalogoDeProductos();
            reporte.mostrarReporte(id_linea,id_sublinea,opcion,id_tienda);
            reporte.Parameters["Empresa"].Value = tienda;
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}