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
namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    public partial class FormModalMorosos : DevExpress.XtraEditors.XtraForm
    {
        public FormModalMorosos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalMorosos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirReporteMorosos modal = new FormImprimirReporteMorosos();
            modal.fecha = Convert.ToDateTime(dateEdit1.EditValue);
            modal.desde = 0;
            modal.hasta = 0;
            modal.monto = 0;
            modal.hastaLaFecha = true;
            modal.id_tienda = Configuraciones.Configuraciones.idtienda;
            modal.opcion = 0;
            modal.ShowDialog();
        }

        private void FormModalMorosos_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
            lookUpEdit1.Properties.DataSource = ControllerPagoCredito.MostrarCuantosMesesReporteMorosos();
            lookUpEdit1.Properties.DisplayMember = "meses";
            lookUpEdit1.Properties.ValueMember = "id_cuantos_meses_morosos";
        }
    }
}