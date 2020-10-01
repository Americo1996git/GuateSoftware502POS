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

namespace ViewGuate502.Proveedor
{
    public partial class FormProveedor : DevExpress.XtraEditors.XtraForm
    {
        bool esNuevo = false;
        bool esEditar = false;
        public int id_proveedor = 0;
        public FormProveedor()
        {
            InitializeComponent();
        }

        //______________________________________________________________________________________________
        //_________________________________funcion para mostrar todos los proveedores_____________________________________________________________
        void mostrarTodosProveedores()
        {
            gridControlListaTodosProveedores.DataSource = ControllerProveedor.mostrarTodosProveedores();
            gridControlListaTodosProveedores.ForceInitialize();
            gridViewListaTodosProveedores.BestFitColumns();
        }
        //______________________________________________________________________________________________
        //______________________________________________________________________________________________


        //______________________________________________________________________________________________
        //________________________________fncion para guardar proveedor______________________________________________________________

        void guardar()
        {
            string rpta = "";
            bool guarda = true;

            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                XtraMessageBox.Show("Debe escribir el nombre de forma correcta","Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(textNit.Text))
            {
                XtraMessageBox.Show("Debe escribir el nit de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                XtraMessageBox.Show("Debe escribir el telefono de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                XtraMessageBox.Show("Debe escribir la dirección de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtVendedor.Text))
            {
                XtraMessageBox.Show("Debe escribir el vendedor de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoVendedor.Text))
            {
                XtraMessageBox.Show("Debe escribir el telefono del vendedor de forma correcta", "Creando proveedor");
                guarda = false;
            }

            if (guarda)
            {
                rpta = ControllerProveedor.guardarProveedor(Configuraciones.Configuraciones.idtienda, textNombre.Text, textNit.Text, textDireccion.Text, string.IsNullOrWhiteSpace(textCorreo.Text)==true ?"":textCorreo.Text, txtTelefono.Text,txtVendedor.Text,txtTelefonoVendedor.Text);
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "Proveedor", "Proveedor guardado correctamente");
                    limpiarEntradas();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear el proveedor, por favor consulte a su administrador de datos", "Error al crear proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        void Actualizar()
        {
            string rpta = "";
            bool guarda = true;


            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                XtraMessageBox.Show("Debe escribir el nombre de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(textNit.Text))
            {
                XtraMessageBox.Show("Debe escribir el nit de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                XtraMessageBox.Show("Debe escribir el telefono de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                XtraMessageBox.Show("Debe escribir la dirección de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtVendedor.Text))
            {
                XtraMessageBox.Show("Debe escribir el vendedor de forma correcta", "Creando proveedor");
                guarda = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoVendedor.Text))
            {
                XtraMessageBox.Show("Debe escribir el telefono del vendedor de forma correcta", "Creando proveedor");
                guarda = false;
            }


            if (guarda)
            {
                rpta = ControllerProveedor.ActualizarProveedor(id_proveedor,Configuraciones.Configuraciones.idtienda, textNombre.Text, textNit.Text, textDireccion.Text, textCorreo.Text, txtTelefono.Text, txtVendedor.Text, txtTelefonoVendedor.Text);
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "Proveedor", "Proveedor actualizado correctamente");
                    limpiarEntradas();
                    mostrarTodosProveedores();
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    esEditar = false;
                    esNuevo = false;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear el proveedor, por favor consulte a su administrador de datos "+rpta, "Error al crear proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //______________________________________________________________________________________________
        //______________________________________________________________________________________________

        void limpiarEntradas()
        {
            textNombre.Text = "";
            textNit.Text = "";
            textDireccion.Text = "";
            txtTelefono.Text = "";
            textCorreo.Text = "";
        }
    

        private void FormProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (!esNuevo && !esEditar)
                {
                    this.Close();
                }

                if (esNuevo)
                {
                    mostrarTodosProveedores();
                    limpiarEntradas();
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    esNuevo = false;
                    esEditar = false;
                }
                if (esEditar)
                {
                    limpiarEntradas();
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    esNuevo = false;
                    esEditar = false;
                }

            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
            mostrarTodosProveedores();
            dxErrorProvider1.SetError(textNombre,"ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(textNit, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtTelefono, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(textDireccion, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtVendedor, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtTelefonoVendedor, "ESTE CAMPO ES OBLIGATORIO");
        }

 

     
 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            textNombre.Focus();
            btnGuardar.Text = "Guardar";
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                guardar();
                
            }
            if (esEditar)
            {
                Actualizar();

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridViewListaTodosProveedores.DataRowCount > 0)
            {
                esEditar = true;
                id_proveedor = Convert.ToInt32(gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "idproveedor"));
                textNombre.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "nombre").ToString();
                textNit.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "nit").ToString();
                textDireccion.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "direccion").ToString();
                textCorreo.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "correo").ToString();
                txtTelefono.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "telefono").ToString();
                txtVendedor.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "vendedor").ToString();
                txtTelefonoVendedor.Text = gridViewListaTodosProveedores.GetRowCellValue(gridViewListaTodosProveedores.FocusedRowHandle, "telefono_vendedor").ToString();
                btnGuardar.Text = "Actualizar";
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                mostrarTodosProveedores();
                limpiarEntradas();
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                esNuevo = false;
                esEditar = false;
            }
            if (esEditar)
            {
                limpiarEntradas();
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                esNuevo = false;
                esEditar = false;
            }
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textNit.Focus();
            }
        }

        private void textNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textCorreo.Focus();
            }
        }

        private void textCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textDireccion.Focus();
            }
        }

        private void textDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtVendedor.Focus();
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefonoVendedor.Focus();
            }
        }

        private void txtTelefonoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }
    }
}