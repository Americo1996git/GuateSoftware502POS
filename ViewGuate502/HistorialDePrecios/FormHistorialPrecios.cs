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

namespace ViewGuate502.HistorialDePrecios
{
    public partial class FormHistorialPrecios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormHistorialPrecios()
        {
            InitializeComponent();
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }
        private void FormHistorialPrecios_KeyDown(object sender, KeyEventArgs e)
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

        private void FormHistorialPrecios_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirHistorial modal = new FormImprimirHistorial();
            modal.fecha_inicial = Convert.ToDateTime(dateEdit1.EditValue);
            modal.fecha_final = Convert.ToDateTime(dateEdit2.EditValue);
            modal.id_producto = Convert.ToInt32(lookUpEditProductos.EditValue);
            modal.ShowDialog();
        }

        private void lookUpEditProductos_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {

        }

        private void txtBuscrProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", dt = ControllerCapturaPedido.MostrarProductos(string.IsNullOrWhiteSpace(txtBuscrProducto.Text) == true ? "&&" : txtBuscrProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProductos.ItemIndex = 0;
            }
        }
    }
}