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

namespace ViewGuate502.Reportes.DocumentosInventario
{
    public partial class FormImprimirDocGenerado : DevExpress.XtraEditors.XtraForm
    {
        public int codigo, id_tienda, id_tipo_documento_inventario, id_origen, id_destino,opcion;
        public bool ingresado;
        public FormImprimirDocGenerado()
        {
            InitializeComponent();
        }

        private void FormImprimirDocGenerado_Load(object sender, EventArgs e)
        {
            Ingresos.ReporteDocumentoIngreso reporte = new Ingresos.ReporteDocumentoIngreso();
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.MostrarReporte(codigo,id_tienda,id_tipo_documento_inventario,id_origen,id_destino, ingresado, opcion);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}