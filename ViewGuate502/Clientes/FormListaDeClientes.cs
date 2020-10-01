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

namespace ViewGuate502.Clientes
{
    public partial class FormListaDeClientes : DevExpress.XtraEditors.XtraForm
    {
        DashBoard MenuPrincipal;
        Ventas.RealizarVenta Venta;
        int id_cliente;
        public FormListaDeClientes(DashBoard principal)
        {
            InitializeComponent();
            MenuPrincipal = principal;
        }
        public FormListaDeClientes(Ventas.RealizarVenta FormVenta)
        {
            InitializeComponent();
            Venta = FormVenta;
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        private void FormListaDeClientes_Load(object sender, EventArgs e)
        {
            gridControlClientes.DataSource = ControllerCliente.MostrarClientes();
            gridControlClientes.ForceInitialize();
            gridViewClientes.BestFitColumns();
            gridViewClientes.Columns["id_cliente"].Visible = false;
            gridViewClientes.Columns["id_estado_civil"].Visible = false;
            gridViewClientes.Columns["id_cliente_subgrupo"].Visible = false;
            gridViewClientes.Columns["id_grupo"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MenuPrincipal != null)
            {
                FormClientes clientes = FormClientes.GetInstacnia();
                clientes.tipo_crecion = 1;
                clientes.id_cliente = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "id_cliente"));
                clientes.lookUpEditGrupo.EditValue = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "id_grupo"));
                mostrarEnComboboxLookUp(clientes.lookUpEditSubGrupo, "descripcion", "id_cliente_subgrupo", ControllerCliente.MostrarSubGrupo(Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "id_grupo"))));
                clientes.lookUpEditSubGrupo.EditValue = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "id_cliente_subgrupo"));
                clientes.txtDpi.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Dpi").ToString();
                clientes.txtNombres.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Nombres").ToString();
                clientes.txtApellidos.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Apellidos").ToString();
                clientes.dateEditFechaNacimiento.EditValue = Convert.ToDateTime(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Fecha nacimiento"));
                clientes.txtDireccion.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Dirección").ToString();
                clientes.txtEmail.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Correo").ToString();
                clientes.txtInstitucionLabora.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Empresa labora").ToString();
                clientes.txtCargoOcupa.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Cargo").ToString();
                clientes.txtNit.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Nit").ToString();
                clientes.radioGroupUsaCuenta.SelectedIndex = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Cuenta bancaria").ToString() == "Si utiliza" ? 1 : 0;
                clientes.radioGroupTieneNegocio.SelectedIndex = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Negocio propio").ToString() == "Si" ? 1 : 0;
                clientes.txtTipoNegocio.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Tipo de negocio").ToString();
                clientes.txtTiempoNegocio.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Tiempo de negocio").ToString();
                clientes.spinEditCantidadHijos.EditValue = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Hijos"));
                clientes.spinEditAportesFamilia.EditValue = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Aportes familia"));
                clientes.radioGroupCasaPropia.SelectedIndex = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Casa propia").ToString() == "Si" ? 1 : 0;
                clientes.txtTiempoResidir.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Tiempo de residir").ToString();
                clientes.radioGroupTrabajaPareja.SelectedIndex = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Trabaja pareja").ToString() == "Si" ? 1 : 0;
                clientes.txtTrabajaPareja.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Trabajo pareja").ToString();
                clientes.txtDescripcion.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Descripción").ToString();
                clientes.txtDireccionFiscal.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Dirección fiscal").ToString();
                clientes.txtRazonSocial.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Razón social").ToString();
                
                //clientes.spin = Convert.ToInt32(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "limite de credito"));
                clientes.MdiParent = MenuPrincipal;
                clientes.Show();

                this.Close();
            }
            if (Venta != null)
            {
                Venta.tbidcliente.Text = Convert.ToString(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "id_cliente"));
                Venta.tbcliente.Text = gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Nombres").ToString()+" "+ gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Apellidos").ToString(); 
                Venta.tbnit.Text = string.IsNullOrWhiteSpace(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Nit").ToString()) == true ? "CF" : gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Nit").ToString();
                Venta.tbdireccion.Text = string.IsNullOrWhiteSpace(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Dirección").ToString()) == true ? "__" : gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Dirección").ToString();
                Venta.tbtelefono.Text = string.IsNullOrWhiteSpace(gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Telefono").ToString()) == true ? "__" : gridViewClientes.GetRowCellValue(gridViewClientes.FocusedRowHandle, "Telefono").ToString();
                this.Close();
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaDeClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}