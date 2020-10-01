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
    public partial class FormReporteTrasladoConfirmado : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int idtienda, idtraslado;
        public FormReporteTrasladoConfirmado()
        {
            InitializeComponent();
        }

        private void FormReporteTrasladoConfirmado_Load(object sender, EventArgs e)
        {
            //ReproteTrasladoConfirmado traslado = new ReproteTrasladoConfirmado();
            //traslado.mostrarReporte(idtienda, idtraslado);
            //traslado.CreateDocument();

            //documentViewer1.DocumentSource = traslado;
        }
    }
}