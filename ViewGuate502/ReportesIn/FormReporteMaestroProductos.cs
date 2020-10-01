using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewGuate502.Reportes
{
    public partial class FormReporteMaestroProductos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_producto;
        public int id_documento;
        public DateTime fecha_inicial;
        public DateTime fecha_final;
        public int opcion;
        public int id_tienda;
        public FormReporteMaestroProductos()
        {
            InitializeComponent();
        }

        private void FormReporteMaestroProductos_Load(object sender, EventArgs e)
        {
            MaestroProductos.XtraReportMaestroDeProductos maestro = new MaestroProductos.XtraReportMaestroDeProductos();
            maestro.Parameters["fecha_inicial"].Value = fecha_inicial;
            maestro.Parameters["fecha_final"].Value = fecha_final;
            maestro.MostrarReporte(id_tienda,id_producto,id_documento,fecha_inicial,fecha_final,opcion);
            maestro.CreateDocument();
            documentViewer1.DocumentSource = maestro;
        }

        private void FormReporteMaestroProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
