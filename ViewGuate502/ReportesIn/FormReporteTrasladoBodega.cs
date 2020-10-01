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

namespace ViewGuate502.Reportes
{
    public partial class FormReporteTrasladoBodega : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int idtienda;
        public int idtrasladobodega;
        public FormReporteTrasladoBodega()
        {
            InitializeComponent();
        }

        private void FormReporteTrasladoBodega_Load(object sender, EventArgs e)
        {
            //ReporteTrasladoBodega traslado = new ReporteTrasladoBodega();
            //traslado.mostrarReporte(idtienda, idtrasladobodega);
            //traslado.CreateDocument();

            //documentViewer1.DocumentSource = traslado;
        }
    }
}