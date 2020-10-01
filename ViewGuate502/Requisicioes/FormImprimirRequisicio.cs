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

namespace ViewGuate502.Requisicioes
{
    public partial class FormImprimirRequisicio : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int idTienda;
        private int idCapturaPedido;

        public int IdTienda
        {
            get
            {
                return idTienda;
            }

            set
            {
                idTienda = value;
            }
        }

        public int IdCapturaPedido
        {
            get
            {
                return idCapturaPedido;
            }

            set
            {
                idCapturaPedido = value;
            }
        }
        public FormImprimirRequisicio()
        {
            InitializeComponent();
        }

        private void FormImprimirRequisicio_Load(object sender, EventArgs e)
        {
            XtraReporteDeRequisicion reporte = new XtraReporteDeRequisicion();
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.mostrarReporte(IdTienda,IdCapturaPedido);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }

        private void FormImprimirRequisicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}