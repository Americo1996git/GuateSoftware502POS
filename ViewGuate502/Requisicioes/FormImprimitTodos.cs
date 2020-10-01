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
    public partial class FormImprimitTodos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int Idtienda;
        public DateTime FechaInicial;
        public DateTime FechaFinal;

        public FormImprimitTodos()
        {
            InitializeComponent();
        }

        private void FormImprimitTodos_Load(object sender, EventArgs e)
        {
            XtraReporteDeRequisicionesPorRangoDeFechas reporte = new XtraReporteDeRequisicionesPorRangoDeFechas();
            reporte.Parameters["fecha_emision"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            reporte.Parameters["fecha_inicial"].Value = FechaInicial.ToString("dd/MM/yyyy");
            reporte.Parameters["fecha_final"].Value = FechaFinal.ToString("dd/MM/yyyy");
            reporte.Parameters["tienda"].Value = Configuraciones.Configuraciones.tienda;
            reporte.mostrarReporte(Idtienda,Convert.ToDateTime(FechaInicial), Convert.ToDateTime(FechaFinal));
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;




        }

        private void FormImprimitTodos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}