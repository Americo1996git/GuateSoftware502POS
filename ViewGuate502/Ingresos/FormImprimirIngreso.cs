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

namespace ViewGuate502.Ingresos
{
    public partial class FormImprimirIngreso : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int tipo_reporte = 0;
        public DateTime fecha_inicial, fecha_final;
        public int codigo, id_tienda, id_documento_inventario, id_origen, id_destino;

        public FormImprimirIngreso()
        {
            InitializeComponent();
        }

        private void FormImprimirIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormImprimirIngreso_Load(object sender, EventArgs e)
        {
            ReporteDeTodosDocumentosDeInvetario reporte = new ReporteDeTodosDocumentosDeInvetario();
            reporte.MostrarReporte(codigo,id_tienda,id_documento_inventario,id_origen,id_destino ,fecha_inicial, fecha_final);
            reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            reporte.Parameters["fecha_final"].Value = fecha_final;
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;


            //if (tipo_reporte == 1)
            //{
            //    ReporteDeIngresoPorTrasladoEntreTiendas reporte = new ReporteDeIngresoPorTrasladoEntreTiendas();
            //    reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            //    reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            //    reporte.MostrarReporte(id_ingreso,Configuraciones.Configuraciones.idtienda);
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}
            //if (tipo_reporte == 2)
            //{
            //    ReporteDeIngresoPorTrasladoEntreBodegas reporte = new ReporteDeIngresoPorTrasladoEntreBodegas();
            //    reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            //    reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            //    reporte.MostrarReporte(id_ingreso, Configuraciones.Configuraciones.idtienda);
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}

            //if (tipo_reporte == 3)
            //{
            //    ReporteDeTodosDocumentosDeInvetario reporte = new ReporteDeTodosDocumentosDeInvetario();
            //    reporte.MostrarReporte(fecha_inicial,fecha_final);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}
            //if (tipo_reporte == 4)
            //{
            //    Reportes.DocumentosInventario.ReporteDeIngresoPorOrdenDeCompra reporte = new Reportes.DocumentosInventario.ReporteDeIngresoPorOrdenDeCompra();
            //    reporte.MostrarReporte(fecha_inicial, fecha_final,id_tienda);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}
            //if (tipo_reporte == 5)
            //{
            //    Reportes.DocumentosInventario.ReporteDeIngresosPorTrasladosTiendas reporte = new Reportes.DocumentosInventario.ReporteDeIngresosPorTrasladosTiendas();
            //    reporte.MostrarReporte(fecha_inicial, fecha_final,id_tienda_origen,id_tienda_destino);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}
            //if (tipo_reporte == 6)
            //{
            //    Reportes.DocumentosInventario.ReporteDeIngresosPorTrasladosBodegas reporte = new Reportes.DocumentosInventario.ReporteDeIngresosPorTrasladosBodegas();
            //    reporte.MostrarReporte(fecha_inicial, fecha_final, id_tienda_origen, id_tienda_destino);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}

            //if (tipo_reporte == 7)
            //{
            //    Reportes.DocumentosInventario.ReporteDeSalidasTiendas reporte = new Reportes.DocumentosInventario.ReporteDeSalidasTiendas();
            //    reporte.MostrarReporte(id_tienda_origen, id_docuento, fecha_inicial, fecha_final,id_tienda_origen,id_tienda_destino);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}
            //if (tipo_reporte == 8)
            //{
            //    Reportes.DocumentosInventario.ReporteDeSalidasBodegas reporte = new Reportes.DocumentosInventario.ReporteDeSalidasBodegas();
            //    reporte.MostrarReporte(id_tienda_origen, id_docuento, fecha_inicial, fecha_final, id_tienda_origen, id_tienda_destino);
            //    reporte.Parameters["fecha_inicial"].Value = fecha_inicial;
            //    reporte.Parameters["fecha_final"].Value = fecha_final;
            //    reporte.CreateDocument();
            //    documentViewer1.DocumentSource = reporte;
            //}

        }
    }
}