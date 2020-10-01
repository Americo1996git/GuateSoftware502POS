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
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using ControllerSoft502;
using MODELOS502;

namespace ViewGuate502.GenerarOrdenCompra
{
    public partial class FormModalAgregarNuevosProductos : DevExpress.XtraEditors.XtraForm
    {
        bool utilizaMarca = false;
        int    idmarca = 0;
        bool utilizarCaracterisicas = false;

        bool cerrar = false;

        public bool esNuevaOrden = false;
        public bool esEditarOrden = false;

        public DataTable dtDetalle;
        public FormModalAgregarNuevosProductos()
        {
            InitializeComponent();
        }

        public void createTable()
        {
            dtDetalle = new DataTable();
            dtDetalle.Columns.Add("idproducto", typeof(int));
            dtDetalle.Columns.Add("codigoProducto", typeof(string));
            dtDetalle.Columns.Add("nombreProducto", typeof(string));
            dtDetalle.Columns.Add("presentacion", typeof(string));
            dtDetalle.Columns.Add("cantidad", typeof(int));
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        //________________________________________________________________________________
        //________________________________________________________________________________
        //__________________________Funciones para mostrar productos________________________________________
        public void mostrarProductos()
        {
            gridControlListTodos.DataSource = ControllerGenerarOrdenCompra.MostrarProductos();
            gridControlListTodos.ForceInitialize();
            gridViewListaTodos.BestFitColumns();

        }



        private void FormModalAgregarNuevosProductos_Load(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
            mostrarProductos();

          
        }




        string ImageDir = @"E:\Trabajo_Programacion\SoftwareVentas\SoftwareGuate502\GuateSoftware502\Imagenes\";
        Hashtable Images = new Hashtable();

        string GetFileName(string color)
        {
            if (color == null || color == string.Empty)
                return string.Empty;
            return color + ".jpg";
        }

       

       

      

        

       

        private void FormModalAgregarNuevosProductos_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

     

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {

        }

        

        private void lookUpEditLinea_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioGroupSbulinea_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

     

       

        private void FormModalAgregarNuevosProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar == false)
            {

                if (gridViewListaTodos.SelectedRowsCount > 0)
                {
                    if (XtraMessageBox.Show("Hay prodcutos seleccionados para agregar a la suborden, ¿Desea cancelar?", "Agregando productos", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creando producto", MessageBoxButtons.YesNo) != DialogResult.No)
                    {

                        e.Cancel = false;


                    }

                }
            }
            else
            {
                e.Cancel = false;
            }
           


        }

        private void btnTodosProdsAgregarOrden_Click(object sender, EventArgs e)
        {
            FormGenerarOrdenCompra orden = FormGenerarOrdenCompra.GetInstacnia();
            int idproducto = 0;
            bool agregar = true;
            bool actualizar = true;
            cerrar = true;

            if (gridViewListaTodos.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Debe seleccionar los productos para agregar", "Agregando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                agregar = false;
            }

            foreach (int indice in gridViewListaTodos.GetSelectedRows())
            {
                if (Convert.ToInt32(gridViewListaTodos.GetRowCellValue(indice, "cantidad_autorizar")) == 0)
                {
                    XtraMessageBox.Show("Uno o varios productos seleccionados deben tener cantidad mayor a 0", "Agregando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    agregar = false;
                    break;
                }
            }

            foreach (int indice in gridViewListaTodos.GetSelectedRows())
            {
                idproducto = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(indice, "idproducto"));
                for (int i = 0; i < orden.gridViewDetalleSubOrden.DataRowCount; i++)
                {
                    if (Convert.ToInt32(orden.gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto")) == idproducto)
                    {
                        agregar = false;
                        actualizar = false;
                        if (XtraMessageBox.Show("El producto " + Convert.ToString(gridViewListaTodos.GetRowCellValue(indice, "codigo")) + " " + Convert.ToString(gridViewListaTodos.GetRowCellValue(indice, "nombre")) + " ya esta agregado en la suborden del proveedor con una cantidad de " + orden.gridViewDetalleSubOrden.GetRowCellValue(i, "cantidad_autorizada").ToString() + ", desea aumentar la cantidad a requerir al proveedor?", "Agregando productos", MessageBoxButtons.YesNo) != DialogResult.No)
                        {

                            orden.gridViewDetalleSubOrden.SetRowCellValue(i, "cantidad_autorizada", Convert.ToInt32(orden.gridViewDetalleSubOrden.GetRowCellValue(i, "cantidad_autorizada")) + Convert.ToInt32(gridViewListaTodos.GetRowCellValue(indice, "cantidad_autorizar")));

                        }



                    }
                }
            }



            if (agregar)
            {
                List<MSubOrdenDetalle> detalleInsercion = new List<MSubOrdenDetalle>();
                foreach (int indice in gridViewListaTodos.GetSelectedRows())
                {
                    MSubOrdenDetalle subordenDetalle = new MSubOrdenDetalle();
                    subordenDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                    subordenDetalle.IdSuborden = orden.idsuborden;
                    subordenDetalle.IdCapturaPedidoDetalle = 0;
                    subordenDetalle.IdSubOrdenDetalle = 0;
                    subordenDetalle.Idproducto = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(indice, "idproducto"));
                    subordenDetalle.CantidadAutorizada = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(indice, "cantidad_autorizar"));
                    subordenDetalle.PrecioCompra = 0;
                    subordenDetalle.Precioa = 0;
                    subordenDetalle.Opcion = 1;
                    subordenDetalle.IdCapturaPedido = 0;
                    detalleInsercion.Add(subordenDetalle);
                }


                if (actualizar == true)
                {

                    orden.ActualizarDetalleRequisicion(detalleInsercion);
                    this.Close();

                }

            }

        }

        private void btnNuevoAgregarOrden_Click(object sender, EventArgs e)
        {
            FormGenerarOrdenCompra orden = FormGenerarOrdenCompra.GetInstacnia();
            int idproducto = 0;
            bool agregar = true;
            bool actualizar = false;

           




        }

        private void lookUpEditLinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        

        private void btnProductosPorLinea_Click(object sender, EventArgs e)
        {

        }

    
        private void btnNuevaLinea_Click(object sender, EventArgs e)
        {
            //Linea.FormNuevaLinea modalLine = new Linea.FormNuevaLinea();
            //modalLine.ShowDialog();
            //mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerGenerarOrdenCompra.MostrarLineas());
        }

        private void btnNuevaSublinea_Click(object sender, EventArgs e)
        {
            //Sublinea.FormSublinea modalSublinea = new Sublinea.FormSublinea();
            //modalSublinea.ShowDialog();
        }

        private void radioGroupMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabarProducto_Click(object sender, EventArgs e)
        {
            bool guardar = true;

            
          

        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
         
            }
        }

        private void btnCancelarCreacion_Click(object sender, EventArgs e)
        {
     
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar = true;

           
        }

        private void FormModalAgregarNuevosProductos_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}