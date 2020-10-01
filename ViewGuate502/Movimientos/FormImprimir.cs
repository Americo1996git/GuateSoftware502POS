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

namespace ViewGuate502.Movimientos
{
    public partial class FormImprimir : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int IdTienda, IdTraslado;
        public bool EsBodega, EsTienda;
        public int id_documento, id_tienda_destino;
        public FormImprimir()
        {
            InitializeComponent();
        }

        private void FormImprimir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormImprimir_Load(object sender, EventArgs e)
        {
            if (EsBodega)
            {
                //XtraReportTrasladoBodegas_0 reporte = new XtraReportTrasladoBodegas_0();
                //reporte.Parameters["fecha_emision"].Value = DateTime.Now;
                //reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
                //reporte.MostrarReporte(IdTienda, IdTraslado, id_documento);
                //reporte.CreateDocument();
                //documentViewer1.DocumentSource = reporte;
            }
            if (EsTienda)
            {
                XtraReporteTrasladoTienda reporte = new XtraReporteTrasladoTienda();
                reporte.Parameters["fecha_emision"].Value = DateTime.Now;
                reporte.MostrarReporte(IdTienda, IdTraslado, id_documento,id_tienda_destino);
                reporte.CreateDocument();
                documentViewer1.DocumentSource = reporte;
            }

        }
    }
}