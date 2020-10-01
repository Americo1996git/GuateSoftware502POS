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
using DevExpress.Data.Filtering;

namespace ViewGuate502.Productos
{
    public partial class FormModalReporteProductos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormModalReporteProductos()
        {
            InitializeComponent();
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {

            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
            lookupeditnombre.Properties.DataSource = datos;
            //lookupeditnombre.EditValue = datos.Rows[0][lookupeditnombre.Properties.ValueMember];
        }
        private void lookUpEditSubLinea_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalReporteProductos_Load(object sender, EventArgs e)
        {
            mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerProducto.MostrarLineasActivas());
            radioGroup1.SelectedIndex = 0;
            layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItemSubLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void lookUpEditLinea_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditLinea.ItemIndex > -1)
            {
                mostrarEnComboboxLookUp(lookUpEditSubLinea, "descripcion", "idsublinea", ControllerProducto.MostrarSubLineasActivas(Convert.ToInt32(lookUpEditLinea.EditValue)));
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            Productos.FormImprimirProducto imprimir = new Productos.FormImprimirProducto();
            if (radioGroup1.SelectedIndex == 0)
            {
                imprimir.id_linea = Convert.ToInt32(lookUpEditLinea.EditValue);
                imprimir.tienda = Configuraciones.Configuraciones.tienda;
                imprimir.fecha = DateTime.Now;
                imprimir.id_sublinea = 0;
                imprimir.id_tienda = Configuraciones.Configuraciones.idtienda;
                imprimir.opcion = 0;
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                imprimir.id_linea = Convert.ToInt32(lookUpEditLinea.EditValue);
                imprimir.tienda = Configuraciones.Configuraciones.tienda;
                imprimir.fecha = DateTime.Now;
                imprimir.id_sublinea = Convert.ToInt32(lookUpEditSubLinea.EditValue);
                imprimir.opcion = 1;
                imprimir.id_tienda = Configuraciones.Configuraciones.idtienda;
            }
            if (radioGroup1.SelectedIndex == 2)
            {
                imprimir.id_linea = Convert.ToInt32(lookUpEditLinea.EditValue);
                imprimir.tienda = Configuraciones.Configuraciones.tienda;
                imprimir.fecha = DateTime.Now;
                imprimir.id_sublinea = Convert.ToInt32(lookUpEditSubLinea.EditValue);
                imprimir.opcion = 2;
                imprimir.id_tienda = Configuraciones.Configuraciones.idtienda;
            }

            imprimir.ShowDialog();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemSubLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemSubLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (radioGroup1.SelectedIndex == 2)
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemSubLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }

        }

        private void FormModalReporteProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}