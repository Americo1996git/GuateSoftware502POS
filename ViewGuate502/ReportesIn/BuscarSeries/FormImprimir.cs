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

namespace ViewGuate502.Reportes.BuscarSeries
{
    public partial class FormImprimir : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_tienda;
        public string serie;
        public FormImprimir()
        {
            InitializeComponent();
        }

        private void FormImprimir_Load(object sender, EventArgs e)
        {
            ReporteSereis reporte = new ReporteSereis();
            reporte.MostarReprote(id_tienda,serie);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}