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

namespace ViewGuate502.Reimpresiones
{
    public partial class FormOrdenesCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormOrdenesCompra()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarOrdenCompra.FormImprimirOrdenCompra modalImprimir = new GenerarOrdenCompra.FormImprimirOrdenCompra();
            modalImprimir.IdTienda = Configuraciones.Configuraciones.idtienda;
            modalImprimir.IdOrden = Convert.ToInt32(gridViewBuscar.GetRowCellValue(gridViewBuscar.FocusedRowHandle,"Codigo"));
            modalImprimir.ShowDialog();
        }

        private void FormOrdenesCompra_Load(object sender, EventArgs e)
        {
            gridControlBuscar.DataSource = ControllerGenerarOrdenCompra.ReimprimrOrdenDeCompra(Configuraciones.Configuraciones.idtienda);
            gridControlBuscar.ForceInitialize();
            gridViewBuscar.BestFitColumns();

            gridViewBuscar.Columns[0].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrdenesCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}