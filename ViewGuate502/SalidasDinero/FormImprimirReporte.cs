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

namespace ViewGuate502.SalidasDinero
{
    public partial class FormImprimirReporte : DevExpress.XtraEditors.XtraForm
    {
        public int id_tienda,id_usuario,id_tipo_salida_dinero;
        public DateTime fecha_inicial,  fecha_final;
        public int opcion;
        public FormImprimirReporte()
        {
            InitializeComponent();
        }

        private void FormImprimirReporte_Load(object sender, EventArgs e)
        {
            Gastos.ReporteSalidasGastos reporte = new Gastos.ReporteSalidasGastos();
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            reporte.Parameters["fecha_final"].Value = fecha_final;
            reporte.Parameters["fecha_emision"].Value = DateTime.Now.Date;
            reporte.MostrarReporte(id_tienda,id_tipo_salida_dinero,id_usuario,fecha_inicial,fecha_final,opcion);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}