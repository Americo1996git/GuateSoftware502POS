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

namespace ViewGuate502.Ventas.Consultas
{
    public partial class Series : DevExpress.XtraEditors.XtraForm
    {
        public Series()
        {
            InitializeComponent();
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorProductos buscadorProductos = new Buscadores.BuscadorProductos(1, null, this, null, null);
            buscadorProductos.ShowDialog();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (teidproducto.Text != "" && defechainicio.EditValue != null && defechafin.EditValue != null)
            {
                VistaReporteSeries vistaReporteSeries = new VistaReporteSeries(int.Parse(teidproducto.Text), 1, DateTime.Parse(defechainicio.EditValue.ToString()), DateTime.Parse(defechafin.EditValue.ToString()));
                vistaReporteSeries.Show();
            }
        }
    }
}