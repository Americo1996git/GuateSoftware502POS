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

namespace ViewGuate502.MaestroProductos
{
    public partial class FormMaestro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMaestro()
        {
            InitializeComponent();
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fechaInicial, fechaFinal;
            int idproducto;
            //fechaInicial = dateTimePickerFechaInicial.Value.ToString("yyyy/MM/dd");
            //fechaFinal = dateTimePickerFechaFinal.Value.ToString("yyyy/MM/dd");
            idproducto = Convert.ToInt32(lookUpEditProducto.EditValue);

            Reportes.FormReporteMaestroProductos maestroModal = new Reportes.FormReporteMaestroProductos();
            maestroModal.id_tienda = Configuraciones.Configuraciones.idtienda;
            maestroModal.id_producto = Convert.ToInt32(lookUpEditProducto.EditValue);
            maestroModal.id_documento = Convert.ToInt32(lookUpEditDocumento.EditValue);
            maestroModal.fecha_inicial = Convert.ToDateTime(dateEditFechaInicial.EditValue);
            maestroModal.fecha_final = Convert.ToDateTime(dateEditFechaFinal.EditValue);
            maestroModal.opcion = Convert.ToInt32(radioGroup1.EditValue);

            maestroModal.ShowDialog();
        }

        private void FormMaestro_Load(object sender, EventArgs e)
        {
            lookUpEditProducto.Properties.DataSource = ControllerProducto.MostrarProductos();
            lookUpEditProducto.Properties.DisplayMember = "nombre";
            lookUpEditProducto.Properties.ValueMember = "idproducto";

            lookUpEditDocumento.Properties.DataSource = ControllerDocumentosInventario.MostrarDocumentos();
            lookUpEditDocumento.Properties.DisplayMember = "Nombre";
            lookUpEditDocumento.Properties.ValueMember = "iddocumento";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMaestro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBuscrProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProducto, "nombre", "idproducto", dt = ControllerCapturaPedido.MostrarProductos(string.IsNullOrWhiteSpace(txtBuscrProducto.Text) == true ? "&&" : txtBuscrProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProducto.ItemIndex = 0;
            }
        }
    }
}