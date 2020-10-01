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

namespace ViewGuate502.ReportesIn.CobrosPagos.IngresosDiarios
{
    public partial class FormModalAbrirReporte : DevExpress.XtraEditors.XtraForm
    {
        public string reporte_tipo = "";
        public FormModalAbrirReporte(string tipo_reporte)
        {
            InitializeComponent();
            reporte_tipo = tipo_reporte;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirReporte reporte = new FormImprimirReporte(Configuraciones.Configuraciones.idtienda
                , Convert.ToInt32(lookUpEditReceptores.EditValue)
                , reporte_tipo.Equals("INGRESOS") == true ? Convert.ToInt32(lookUpEditTiposPagos.EditValue) : 5
                , Configuraciones.Configuraciones.tienda
                , Convert.ToDateTime(dateEditInicial.EditValue)
                , Convert.ToDateTime(dateEditFinal.EditValue)
                , radioGroup1.SelectedIndex == 0 ? "DOCUMENTO: " : "RECEPTOR"
                , reporte_tipo.Equals("INGRESOS") == true ? radioGroup1.SelectedIndex : 0
                , reporte_tipo);
            reporte.ShowDialog();
            
        }

        private void FormModalAbrirReporte_Load(object sender, EventArgs e)
        {
            if (reporte_tipo.Equals("INGRESOS"))
            {
                this.Text = "PAGOS EFECTUADOS POR CLIENTES";
            }
            if (reporte_tipo.Equals("NOTAS_CREDITO"))
            {
                this.Text = "NOTS DE CREDITO POR FECHAS";
                lyRadioGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyTipoPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            lookUpEditTiposPagos.Properties.DataSource = ControllerMostrar.TiposDePagos();
            lookUpEditTiposPagos.Properties.DisplayMember = "tipo_pago";
            lookUpEditTiposPagos.Properties.ValueMember = "id_tipo_pago";

            lookUpEditReceptores.Properties.DataSource = ControllerMostrar.Usuarios();
            lookUpEditReceptores.Properties.DisplayMember = "nombre_usuario";
            lookUpEditReceptores.Properties.ValueMember = "id_usuario";

            lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyTipoPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lyTipoPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalAbrirReporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                lyTipoPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lyTipoPago.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lyReceptor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }

        }
    }
}