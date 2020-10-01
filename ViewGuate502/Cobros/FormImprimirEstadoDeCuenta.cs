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

namespace ViewGuate502.Cobros
{
    public partial class FormImprimirEstadoDeCuenta : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_promesas_enca;
        public string cliente,producto;

        public FormImprimirEstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void FormImprimirEstadoDeCuenta_Load(object sender, EventArgs e)
        {
            ReporteEstadoDeCuenta reporte = new ReporteEstadoDeCuenta();
            reporte.Parameters["cliente"].Value = cliente;
            reporte.Parameters["producto"].Value = producto;
            reporte.Parameters["tienda_emision"].Value = Configuraciones.Configuraciones.tienda;
            reporte.MostrarReporte(id_promesas_enca);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}