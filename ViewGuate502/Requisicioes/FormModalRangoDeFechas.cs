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
    public partial class FormModalRangoDeFechas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int tipo_impresion = 0;
        public FormModalRangoDeFechas()
        {
            InitializeComponent();
        }

        private void btnImprimrTodos_Click(object sender, EventArgs e)
        {
            if (tipo_impresion == 0)
            {
                FormImprimitTodos modalReporte = new FormImprimitTodos();
                modalReporte.Idtienda = Configuraciones.Configuraciones.idtienda;
                modalReporte.FechaInicial = Convert.ToDateTime(dateEditFechaIncial.EditValue);
                modalReporte.FechaFinal = Convert.ToDateTime(dateEditFechaFinal.EditValue);
                modalReporte.ShowDialog();
            }
            else
            {
                FormImprimirRequisicio modalImprimir = new FormImprimirRequisicio();
                modalImprimir.IdTienda = Configuraciones.Configuraciones.idtienda;
                modalImprimir.IdCapturaPedido = Convert.ToInt32(spinEditCodigo.EditValue);
                modalImprimir.ShowDialog();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalRangoDeFechas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FormModalRangoDeFechas_Load(object sender, EventArgs e)
        {
            if (tipo_impresion == 0)
            {
                layoutControlGroupTitulo.Text = "Imprimir requisiciones";
                layoutControlItemCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
            if (tipo_impresion == 1)
            {
                layoutControlGroupTitulo.Text = "Imprimir requisición";
                layoutControlItemFechaInicial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemFechaFinal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}