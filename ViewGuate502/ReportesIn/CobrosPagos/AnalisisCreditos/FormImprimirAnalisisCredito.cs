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

namespace ViewGuate502.ReportesIn.CobrosPagos.AnalisisCreditos
{
    public partial class FormImprimirAnalisisCredito : DevExpress.XtraEditors.XtraForm
    {
        public int id_tienda, id_cliente, opcion;
        public string cliente, tienda;
        DateTime fecha_emsiion;
        public FormImprimirAnalisisCredito()
        {
            InitializeComponent();
        }

        private void FormImprimirAnalisisCredito_Load(object sender, EventArgs e)
        {
            ReporteAnanlisisDeCreditos reporte = new ReporteAnanlisisDeCreditos();
            reporte.Parameters["cliente"].Value = cliente;
            reporte.Parameters["tienda"].Value = tienda;
            reporte.Parameters["fecha_emision"].Value = DateTime.Now;
            reporte.MostrarReporte(id_tienda,id_cliente,opcion);
            reporte.CreateDocument();
            documentViewer1.DocumentSource = reporte;
        }
    }
}