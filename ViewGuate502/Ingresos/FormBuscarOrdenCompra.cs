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

namespace ViewGuate502.Ingresos
{
    public partial class FormBuscarOrdenCompra : DevExpress.XtraEditors.XtraForm
    {
        public FormBuscarOrdenCompra()
        {
            InitializeComponent();
        }

        private void FormBuscarOrdenCompra_Load(object sender, EventArgs e)
        {


            //gridViewBuscar.Columns[1].Visible = false;
            //gridViewBuscar.Columns[2].Visible = false;
            //gridViewBuscar.Columns[3].Visible = false;
            //gridViewBuscar.Columns[4].Visible = false;

            //gridControlBuscar.ForceInitialize();
            //gridViewBuscar.BestFitColumns();


        }

        private void gridViewBuscar_DoubleClick(object sender, EventArgs e)
        {
            FormIngresosMercaderia ingreso = FormIngresosMercaderia.GetInstancia();
            ingreso.mostrarDetalleProductos(Convert.ToInt32(gridViewBuscar.GetRowCellValue(gridViewBuscar.FocusedRowHandle,"Codigo")));
            ingreso.spinEditNumeroOrden.Value = Convert.ToInt32(gridViewBuscar.GetRowCellValue(gridViewBuscar.FocusedRowHandle, "Codigo"));
            this.Close();
        }
    }
}