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

namespace ViewGuate502.HistorialDePrecios
{
    public partial class FormImprimirHistorial : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DateTime fecha_inicial, fecha_final;
        public int id_producto;
        public FormImprimirHistorial()
        {
            InitializeComponent();
        }

        private void FormImprimirHistorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormImprimirHistorial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormImprimirHistorial_Load(object sender, EventArgs e)
        {
            Verificaciones.ReporteHistorialPreciosCostos reporte = new Verificaciones.ReporteHistorialPreciosCostos();
            reporte.MostrarReporte(fecha_inicial,fecha_final,id_producto);
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            reporte.Parameters["fecha_final"].Value = fecha_final;
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}