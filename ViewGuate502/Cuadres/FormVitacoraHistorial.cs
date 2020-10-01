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

namespace ViewGuate502.Cuadres
{
    public partial class FormVitacoraHistorial : DevExpress.XtraEditors.XtraForm
    {
        public FormVitacoraHistorial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVitacoraHistorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormVitacoraHistorial_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ControllerMostrar.HistorialCuadreDia(Configuraciones.Configuraciones.idtienda);
            gridControl1.ForceInitialize();
            gridView1.BestFitColumns();
        }
    }
}