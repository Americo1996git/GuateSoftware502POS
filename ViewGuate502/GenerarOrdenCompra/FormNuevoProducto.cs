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
using MODELOS502;
namespace ViewGuate502.GenerarOrdenCompra
{
    public partial class FormNuevoProducto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        //________________________________________________________________________________
        //________________________________________________________________________________
        //__________________________Funciones para mostrar linea, sublinea y marcaa en un control combobox lookupedit________________________________________
        //---1 recibe el control lookupedit, nombre d el campo a mostrar, y el id a evaluar
        //cunado el usaruio seleccione en el combobox, y un datable que trae los datos de la DB 
        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {

            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
            lookupeditnombre.Properties.DataSource = datos;
            //lookupeditnombre.EditValue = datos.Rows[0][lookupeditnombre.Properties.ValueMember];
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerProducto.MostrarLineasActivas());
            mostrarEnComboboxLookUp(lookUpEditMarca, "Nombre", "idmarca", ControllerProducto.MostrarMarcasActivas());
            lookUpEditLinea.Focus();
            radioGroupMarca.SelectedIndex = 0;
            lookUpEditMarca.Enabled = false;
            dxErrorProvider1.SetError(lookUpEditLinea, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(lookUpEditSubLinea, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtNombre, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtPresentacion, "ESTE CAMPO ES OBLIGATORIO");


            gridControlProductosAgredaosRecietnes.DataSource = ControllerGenerarOrdenCompra.MostrarProdcutosRecienCreados();
            gridControlProductosAgredaosRecietnes.ForceInitialize();
            gridViewListaProductosRecientes.BestFitColumns();
        }

        private void lookUpEditLinea_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditLinea.ItemIndex > -1)
            {
                mostrarEnComboboxLookUp(lookUpEditSubLinea, "descripcion", "idsublinea", ControllerProducto.MostrarSubLineasActivas(Convert.ToInt32(lookUpEditLinea.EditValue)));


            }
        }

        private void radioGroupMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupMarca.SelectedIndex == 0)
            {
                lookUpEditMarca.Enabled = false;
                dxErrorProvider1.SetError(lookUpEditMarca, "");
            }
            if (radioGroupMarca.SelectedIndex == 1)
            {
                lookUpEditMarca.Enabled = true;
                dxErrorProvider1.SetError(lookUpEditMarca, "ESTE CAMPO ES OBLIGATORIO");

            }
        }

        private void btnGrabarProducto_Click(object sender, EventArgs e)
        {
            bool guardar = true;
            if (lookUpEditLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar una linea","Creando producto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                guardar = false;
            }
            if (lookUpEditSubLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar una sublinea", "Creando producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }
            if (radioGroupMarca.SelectedIndex == 1)
            {
                if (lookUpEditMarca.ItemIndex < 0)
                {
                    XtraMessageBox.Show("Debe seleccionar una marca", "Creando producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe escribir el nombre del producto de forma correcta", "Creando producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(txtPresentacion.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe escribir la presentación de forma correcta", "Creando producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (guardar)
            {
                string rpta = "";
                MProducto producto = new MProducto();
                producto.Idtienda = Configuraciones.Configuraciones.idtienda;
                producto.Idlinea = Convert.ToInt32(lookUpEditLinea.EditValue);
                producto.Idsublinea = Convert.ToInt32(lookUpEditSubLinea.EditValue);
                producto.Idmarca = radioGroupMarca.SelectedIndex == 0 ? 0 : Convert.ToInt32(lookUpEditMarca.EditValue);
                producto.Nombre = txtNombre.Text;

                //producto.RutaImagen = NombreImagenDeProducto == "" ? "ninguno" : "./assets/ImagenesProductos/" + NombreImagenDeProducto;
                //producto.RutaImagen = NombreImagenDeProducto == "" ? "ninguno" : NombreImagenDeProducto;



                producto.Presentacion = txtPresentacion.Text;

                producto.UtilizaSublinea = Convert.ToInt32(lookUpEditSubLinea.EditValue) > 0 ? "1" : "0";
                producto.UtilizaMarca = Convert.ToInt32(lookUpEditMarca.EditValue) > 0 ? "1" : "0";
                producto.NombreLinea = lookUpEditLinea.Text;
                producto.AplicaSerie = "0";

                rpta = ControllerGenerarOrdenCompra.GuardarProducto(producto);

                if (rpta == "OK")
                {
                    //alertControl1.Show(this, "Creación de producto", "El producto se creo correctamente");
                    txtNombre.Text = string.Empty;
                    txtPresentacion.Text = string.Empty;

                    gridControlProductosAgredaosRecietnes.DataSource = ControllerGenerarOrdenCompra.MostrarProdcutosRecienCreados();
                    gridControlProductosAgredaosRecietnes.ForceInitialize();
                    gridViewListaProductosRecientes.BestFitColumns();

                    lookUpEditLinea.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear producto, porfavor consulte a su administrador de datos. " + rpta, "Error al crear producto");
                }

            }
        }

        private void lookUpEditLinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditSubLinea.Focus();
            }
        }

        private void lookUpEditSubLinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupMarca.Focus();
            }
        }

        private void radioGroupMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioGroupMarca.SelectedIndex == 0)
                {
                    txtPresentacion.Focus();
                }
                if (radioGroupMarca.SelectedIndex == 1)
                {
                    lookUpEditMarca.Focus();
                }
            }
        }

        private void lookUpEditMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPresentacion.Focus();
            }
        }

        private void btnNuevoAgregarOrden_Click(object sender, EventArgs e)
        {
            FormGenerarOrdenCompra orden = FormGenerarOrdenCompra.GetInstacnia();
            int idproducto = 0;
            bool agregar = true;
            bool actualizar = true;
            string rpta = "";

            if (gridViewListaProductosRecientes.DataRowCount == 0)
            {
                XtraMessageBox.Show("Debe crear uno o mas productos para agregar", "Agregando productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {


                //____
                List<MSubOrdenDetalle> detalleInsercion = new List<MSubOrdenDetalle>();
                for (int i = 0; i < gridViewListaProductosRecientes.DataRowCount; i++)
                {
                    MSubOrdenDetalle subordenDetalle = new MSubOrdenDetalle();
                    subordenDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                    subordenDetalle.IdSuborden = orden.idsuborden;
                    subordenDetalle.IdCapturaPedidoDetalle = 0;
                    subordenDetalle.IdSubOrdenDetalle = 0;
                    subordenDetalle.Idproducto = Convert.ToInt32(gridViewListaProductosRecientes.GetRowCellValue(i, "idproducto"));
                    subordenDetalle.CantidadAutorizada = Convert.ToInt32(gridViewListaProductosRecientes.GetRowCellValue(i, "cantidad_autorizar"));
                    subordenDetalle.PrecioCompra = 0;
                    subordenDetalle.Precioa = 0;
                    subordenDetalle.IdCapturaPedido = 0;
                    subordenDetalle.Opcion = 1;
                    detalleInsercion.Add(subordenDetalle);




                }

                if (actualizar == true)
                {

                    orden.ActualizarDetalleRequisicion(detalleInsercion);


                    for (int i = 0; i < gridViewListaProductosRecientes.DataRowCount; i++)
                    {
                        ControllerGenerarOrdenCompra.ProductosDejanDeSerRecientes(Convert.ToInt32(gridViewListaProductosRecientes.GetRowCellValue(i, "idproducto")));
                    }
                    this.Close();

                }
            }

        }

        private void txtPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGrabarProducto.Focus();
            }
        }

        private void FormNuevoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}