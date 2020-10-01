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

namespace ViewGuate502.ReportesIn.CobrosPagos.IngresosDiarios
{
    public partial class FormImprimirReporte : DevExpress.XtraEditors.XtraForm
    {
        public int Id_tienda, Id_usuario, Id_tipo_doc;
        DateTime Fecha_inicial, Fecha_final;
        int Opcion;
        string tipo_reporte;

        private void FormImprimirReporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        string Tienda, Orden;

        public FormImprimirReporte(int id_tienda,int id_usuario, int id_tipo_doc, string tienda, DateTime fecha_inicial, DateTime fecha_final, string orden, int opcion, string reporte)
        {
            InitializeComponent();
            this.Id_tienda = id_tienda;
            this.Id_usuario = id_usuario;
            this.Id_tipo_doc = id_tipo_doc;
            this.Tienda = tienda;
            this.Fecha_inicial = fecha_inicial;
            this.Fecha_final = fecha_final;
            this.Orden = orden;
            this.Opcion = opcion;
            this.tipo_reporte = reporte;
        }

        private void FormImprimirReporte_Load(object sender, EventArgs e)
        {
            if (tipo_reporte == "INGRESOS")
            {
                ReporteIngresosDiarios reporte = new ReporteIngresosDiarios();
                reporte.Parameters["tienda"].Value = Tienda;
                reporte.Parameters["fecha_emision"].Value = DateTime.Now;
                reporte.Parameters["fecha_inicial"].Value = Fecha_inicial;
                reporte.Parameters["fecha_final"].Value = Fecha_final;
                reporte.Parameters["orden_reporte"].Value = Orden;
                reporte.MostrarReporte(Id_tienda, Id_usuario, Id_tipo_doc, Fecha_inicial, Fecha_final, Opcion);
                reporte.CreateDocument();
                documentViewer1.DocumentSource = reporte;
            }
            if (tipo_reporte == "NOTAS_CREDITO")
            {
                ReporteNotasCredito reporte = new ReporteNotasCredito();
                reporte.Parameters["tienda"].Value = Tienda;
                reporte.Parameters["fecha_emision"].Value = DateTime.Now;
                reporte.Parameters["fecha_inicial"].Value = Fecha_inicial;
                reporte.Parameters["fecha_final"].Value = Fecha_final;
                reporte.MostrarReporte(Id_tienda, Id_usuario, Id_tipo_doc, Fecha_inicial, Fecha_final, Opcion);
                reporte.CreateDocument();
                documentViewer1.DocumentSource = reporte;
            }

        }
    }
}