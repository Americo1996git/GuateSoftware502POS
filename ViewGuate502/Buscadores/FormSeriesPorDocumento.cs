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
using ControllerSoft502;


namespace ViewGuate502.Buscadores
{
    public partial class FormSeriesPorDocumento : DevExpress.XtraEditors.XtraForm
    {
        public FormSeriesPorDocumento()
        {
            InitializeComponent();
        }

        private void FormSeriesPorDocumento_Load(object sender, EventArgs e)
        {
            gridControl1.ForceInitialize();
            gridView1.BestFitColumns();
        }

        private void txtSeries_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = ControllerBusquarSereis.Mostrar(txtSeries.Text,Configuraciones.Configuraciones.idtienda);    
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.BuscarSeries.FormImprimir modalForm = new Reportes.BuscarSeries.FormImprimir();
            modalForm.id_tienda = Configuraciones.Configuraciones.idtienda;
            modalForm.serie = txtSeries.Text;
            modalForm.ShowDialog();
        }

        private void FormSeriesPorDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}