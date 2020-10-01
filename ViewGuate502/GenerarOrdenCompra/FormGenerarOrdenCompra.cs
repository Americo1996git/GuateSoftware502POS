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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using MODELOS502;
using DevExpress.Utils.Diagnostics;

namespace ViewGuate502.GenerarOrdenCompra
{
    public partial class FormGenerarOrdenCompra : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dtDetalleSubOrdenInsercion;
        public DataTable dtDetalleSubOrdenEliminacion;
        public DataTable dtSubOrdenes;
        public DataTable dtDetalleParaGenerarOrdenDeCompra;

        public DataTable dtDetalleSubOrdenPorProveedor;

        public int idcapturapedido=0;
        decimal totalPrecioOrdenDetalleCompra;
        public int idproveedor;
        public int idsuborden;
        //________________________suma y promedio____________________________________
        decimal sumaResultado = 0;
        decimal valorActual = 0;
        //__________________________________________________________________________
        private static FormGenerarOrdenCompra _Instancia;

        //_______________________________________________________________________________
        //_______________________________________________________________________________
        //__________________Esta funcon sirve para saber si ya hay una isntancia_________
        public static FormGenerarOrdenCompra GetInstacnia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormGenerarOrdenCompra();
            }
            return _Instancia;
        }
        public FormGenerarOrdenCompra()
        {
            InitializeComponent();
        }


        void Guardar()
        {
            bool generar = true;
            decimal total = 0;
            if (gridViewDetalleSubOrden.DataRowCount == 0)
            {
                XtraMessageBox.Show("No hay productos agregados para generar orden de compra", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generar = false;
            }
            if (lookUpEditProveedorSuborden.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar el proveedor al cual enviara la orden de compra", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generar = false;
            }
            if (string.IsNullOrWhiteSpace(lookUpEditProveedorSuborden.Text))
            {
                XtraMessageBox.Show("Debe seleccionar el proveedor al cual enviara la orden de compra", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generar = false;
            }

            for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
            {
                if (Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(i, "cantidad_autorizada")) == 0)
                {
                    XtraMessageBox.Show("Uno o varios productos de la lista tienen cantidad 0, debe autorizar una cantidad mayor", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    generar = false;
                    break;
                }
            }

            for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(i, "verificado")))
                {
                    if (Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(i, "ultimo_costo")) == 0)
                    {
                        XtraMessageBox.Show("Debe asignar un precio de costo para el producto verificado", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        generar = false;
                        break;
                    }
                }
            }


            for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(i, "verificado")))
                {
                    if (Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(i, "precioa")) == 0)
                    {
                        XtraMessageBox.Show("Debe asignar un preio de venta para el producto verificado", "Generando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        generar = false;
                        break;
                    }
                }
            }

            if (generar)
            {
                FormModalMostrarDetalleOrdenCompra modalOC = new FormModalMostrarDetalleOrdenCompra();
                modalOC.dtDetalleSubOrdenInsercion = dtDetalleSubOrdenInsercion;
                modalOC.proveedor = lookUpEditProveedorSuborden.Text;
                modalOC.idsuborden = idsuborden;
                modalOC.ShowDialog();

                dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                gridControlDetalleSuborden.ForceInitialize();
                gridViewDetalleSubOrden.BestFitColumns();

                if (dtDetalleSubOrdenInsercion.Rows.Count != 0)
                {
                    idsuborden = Convert.ToInt32(dtDetalleSubOrdenInsercion.Rows[0]["idsuborden"]);
                }

                dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
            }

        }





        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }



        void mostrarRequisicionesPendietes()
        {
            gridControlListaTodasRequisiciones.DataSource = ControllerGenerarOrdenCompra.MostrarRequisicionesPendietnes(Configuraciones.Configuraciones.idtienda);
            gridControlListaTodasRequisiciones.ForceInitialize();
            gridViewListaDetallePedidoAutorizados.BestFitColumns();

        }





        //________________________________________________________________________________
        //________________________________________________________________________________

        private void FormGenerarOrdenCompra_Load(object sender, EventArgs e)
        {
            //mostrarRequisicionesAutorizados();
            mostrarRequisicionesPendietes();
            mostrarEnComboboxLookUp(lookUpEditProveedorSuborden, "nombre", "idproveedor", ControllerGenerarOrdenCompra.MostrarProveedores());
            dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
        }


        public void ActualizarDetalleRequisicion(List<MSubOrdenDetalle> detalleInsercion)
        {
            string rpta = "";
            bool ExisteProveedor = false;
            for (int i = 0; i < dtSubOrdenes.Rows.Count; i++)
            {
                if (Convert.ToInt32(lookUpEditProveedorSuborden.EditValue) == Convert.ToInt32(dtSubOrdenes.Rows[i]["idproveedor"]))
                {
                    ExisteProveedor = true;
                    idsuborden = Convert.ToInt32(dtSubOrdenes.Rows[i]["idsuborden"]);
                    break;
                }
            }

            if (ExisteProveedor)
            {
                bool existeProducto = false;
                for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
                {
                    foreach (int indice in gridViewSuborden.GetSelectedRows())
                    {
                        if (Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto")) == Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto")))
                        {
                            existeProducto = true;
                            XtraMessageBox.Show("Uno o varios productos seleccionados ya estan agregados para un proveedor", "Creando suborden");
                            break;
                        }
                    }
                }

                if (existeProducto == false)
                {

                  

                    rpta = ControllerGenerarOrdenCompra.AgregarProductosSubOrdenExistente(0,0,detalleInsercion);

                    if (rpta == "OK")
                    {
                        //XtraMessageBox.Show("Los productos se agregaro a la subroden correctamente", "Creando suborden");


         

                        GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                        GridControlSuborden.ForceInitialize();
                        gridViewSuborden.BestFitColumns();


                        dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                        gridControlDetalleSuborden.ForceInitialize();
                        gridViewDetalleSubOrden.BestFitColumns();

                        dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error al agregar los productos, porfavor consulte a su administrador de datos: " + rpta, "Error al crear suborden");
                    }
                }



                //____________________________________________________________________________________________________________________________________________________________________
            }
            else
            {
                MSubOrden suborden = new MSubOrden();
                suborden.IdTienda = Configuraciones.Configuraciones.idtienda;
                suborden.IdProveedor = Convert.ToInt32(lookUpEditProveedorSuborden.EditValue);
                suborden.IdUsuariio = Configuraciones.Configuraciones.idusuario;
                suborden.IdCapturaPedido = 0;

           


                rpta = ControllerGenerarOrdenCompra.CrearSubOrden(suborden, detalleInsercion);

                if (rpta == "OK")
                {
                    //XtraMessageBox.Show("La suborden se creo correctamente", "Creando suborden");

                    idsuborden = ControllerGenerarOrdenCompra.IdSubOrden;

                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    GridControlSuborden.ForceInitialize();
                    gridViewSuborden.BestFitColumns();


                    dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                    gridControlDetalleSuborden.ForceInitialize();
                    gridViewDetalleSubOrden.BestFitColumns();

                    dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                }
            }
        }

     



      

       

        private void btnGenerar_Click(object sender, EventArgs e)
        {



        }

        public void habilitarBotonoes(bool value)
        {


        }



        private void gridViewListaDetalleProductos_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            int editorIndex = (view.GetDataSourceRowIndex(e.RowHandle) + e.Column.VisibleIndex) % 3;
            //e.RepositoryItem = inplaceEditors[editorIndex]
        }

        private void btnGenerarImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirOrdenCompra imprimir = new FormImprimirOrdenCompra();
            imprimir.ShowDialog();
        }

        

       

     

        private void btnAgregarNuevosProductos_Click(object sender, EventArgs e)
        {
            if (lookUpEditProveedorSuborden.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar el proveedor al cual solicitara los productos", "Creando suborden",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                FormModalAgregarNuevosProductos agregarnuevos = new FormModalAgregarNuevosProductos();
                agregarnuevos.esNuevaOrden = true;
                agregarnuevos.ShowDialog();
            }

        }

        private void FormGenerarOrdenCompra_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        private void FormGenerarOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
        int rowHandle = 0;



        private void gridViewOrdenesGeneradas_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    FormModalMostrarDetalleOrdenCompra modal = FormModalMostrarDetalleOrdenCompra.GetInstancia();
            //    int id,idproveedor,idcapturapedido;
            //    int numeroOrden;
            //    string NumPedido,Proveedor, JustificacionPedido, ObservacionGeneral,ContactoRecibe,Destino,serie,FechaIngresoBodega, impreso;
            //    decimal total;

            //    id = Convert.ToInt32(gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "idgenordencompraencabezado"));
            //    idproveedor = Convert.ToInt32(gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "idproveedor"));
            //    idcapturapedido = Convert.ToInt32(gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "idcapturapedido"));
            //    numeroOrden = Convert.ToInt32(gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "idgenordencompraencabezado"));
            //    NumPedido = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "num_pedido").ToString();
            //    Proveedor = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "nombreproveedor").ToString();
            //    JustificacionPedido = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "justificacionpedido").ToString();
            //    ObservacionGeneral = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "observaciongeneral").ToString();
            //    ContactoRecibe = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "quienrecibeorden").ToString();
            //    Destino = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "destino").ToString();
            //    serie = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "serie").ToString();
            //    FechaIngresoBodega = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "fechaingresobodega").ToString();
            //    total = Convert.ToInt32(gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "total"));
            //    impreso = gridViewOrdenesGeneradas.GetRowCellValue(gridViewOrdenesGeneradas.FocusedRowHandle, "impreso").ToString();
            //    modal.idencabezadoOrdenCompra = id;
            //    modal.idproveedor = idproveedor;
            //    modal.idcapturapedido = idcapturapedido;
            //    modal.numeroOrden = numeroOrden;
            //    modal.NumPedido = NumPedido;
            //    modal.Proveedor = Proveedor;
            //    modal.JustificacionPedido = JustificacionPedido;
            //    modal.ObservacionGeneral = ObservacionGeneral;
            //    modal.ContactoRecibe = ContactoRecibe;
            //    modal.Destino = Destino;
            //    modal.serie = serie;
            //    modal.sumaResultado = total;
            //    modal.FechaIngresoBodega = FechaIngresoBodega;
            //    modal.impreso = impreso;
            //    modal.ShowDialog();
            //    RefrescarDatos();
            //}
            //catch (Exception ex)
            //{

            //    XtraMessageBox.Show("Seleccione un item");
            //}

        }



        private void gridViewListaOrdensGenPorProveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //FormModalMostrarDetalleOrdenCompra modal = new FormModalMostrarDetalleOrdenCompra();
                //int id;
                //string proveedor;
                //id = Convert.ToInt32(gridViewListaOrdensGenPorProveedor.GetRowCellValue(gridViewListaOrdensGenPorProveedor.FocusedRowHandle, "idgenordencompraencabezado"));
                //proveedor = gridViewListaOrdensGenPorProveedor.GetRowCellValue(gridViewListaOrdensGenPorProveedor.FocusedRowHandle, "nombreproveedor").ToString();
                //modal.idencabezadoOrdenCompra = id;
                //modal.proveedro = proveedor;
                //modal.ShowDialog();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Seleccione un item");
            }
        }




         

    

        private void btnRegresar0_Click(object sender, EventArgs e)
        {

        }


        void SelectRows(int position1, int position2)
        {
            int start = Math.Min(position1, position2);
            int end = Math.Max(position1, position2);
            for (int i = start; i < end; i++)
            {
                int index = gridViewSuborden.GetDataSourceRowIndex(i);
                if (!selectedRows.Contains(index))
                    selectedRows.Add(index);
            }
        }
        void SelectRow(int position)
        {
            int index = gridViewSuborden.GetDataSourceRowIndex(position);
            if (!selectedRows.Contains(index))
                selectedRows.Add(index);

        }
        void ClaerSelection()
        {
            selectedRows = new List<int>();
        }

       

        private void GridControlSuborden_Click(object sender, EventArgs e)
        {

        }

   

   

        private void btmCamcelarSubOrden_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea cancelar la creación de suborden", "Creando suborden", MessageBoxButtons.YesNo,MessageBoxIcon.Information) != DialogResult.No)
            {
                this.Close();
            }
    
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

      

        private void btnCompletar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int idcapturapedidodetalle = Convert.ToInt32(gridViewSuborden.GetRowCellValue(gridViewSuborden.FocusedRowHandle, "idcapturapedidodetalle"));
            ////XtraMessageBox.Show(gridViewSuborden.GetRowCellValue(gridViewSuborden.FocusedRowHandle, "idcapturapedidodetalle").ToString());
            //ControllerGenerarOrdenCompra.CompletarProductoRequisicion(Configuraciones.Configuraciones.idtienda,idcapturapedido,idcapturapedidodetalle);
            //dtDetalleOrde.Clear();
            //dtDetalleOrde1.Clear();
            //mostrarTablaDetalleOrdenCompra(idcapturapedido);

        }
        List<int> selectedRows = new List<int>();
        private void gridViewSuborden_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (selectedRows.Contains(gridViewSuborden.GetDataSourceRowIndex(e.RowHandle)))
            //    e.Appearance.BackColor = gridViewSuborden.PaintAppearance.FocusedRow.BackColor;
        }

      
        private void btnQuitar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }



        private void lookUpEditProveedorSuborden_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditProveedorSuborden.ItemIndex > -1)
            {
                //dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.GetColumnValue("idsuborden")), Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenPorProveedor = ControllerGenerarOrdenCompra.MostrarSubOrdenesPorProveedor(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));

                gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                gridControlDetalleSuborden.ForceInitialize();
                gridViewDetalleSubOrden.BestFitColumns();
   

                if (dtDetalleSubOrdenPorProveedor.Rows.Count > 0)
                {
                    idsuborden = Convert.ToInt32(dtDetalleSubOrdenPorProveedor.Rows[0]["idsuborden"]);
                    gridViewDetalleSubOrden.FocusedRowHandle = 0;
                    gridViewDetalleSubOrden.FocusedColumn = gridViewDetalleSubOrden.VisibleColumns[7];
                    gridViewDetalleSubOrden.ShowEditor();
                }
                else
                {
                    idsuborden = 0;
                }
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    


    

        GridHitInfo downHitInfo;
 

    

       

      

      

  

       

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea quitar el producto de la lista?", "Agregando productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                ControllerGenerarOrdenCompra.EliminarProductoDeSubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "idproducto")), Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "idsubordendetalle")), Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "id_captura_pedido")));

                GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                GridControlSuborden.ForceInitialize();
                gridViewSuborden.BestFitColumns();


                dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                gridControlDetalleSuborden.ForceInitialize();
                gridViewDetalleSubOrden.BestFitColumns();

                dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);

                if (Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "id_captura_pedido")) > 0)
                {

                }
            }

          
        }

        

        private void repositoryItemSpinEdit1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarRequisicion_Click(object sender, EventArgs e)
        {
            bool terminar = true;
            if (gridViewListaDetallePedidoAutorizados.DataRowCount == 0)
            {
                XtraMessageBox.Show("Debe seleccionar una requisición para terminarla", "Creando suborden",MessageBoxButtons.OK,MessageBoxIcon.Information);
                terminar = false;
            }
            if (idcapturapedido == 0)
            {
                XtraMessageBox.Show("Debe seleccionar una requisición para terminarla", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                terminar = false;
            }
            if (gridViewSuborden.DataRowCount == 0)
            {
                XtraMessageBox.Show("No hay productos en la requisición o no esta seleccionada la requisición", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                terminar = false;
            }
            if (terminar)
            {
                if (XtraMessageBox.Show("Desea terminar la requisición", "Creando suborden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    ControllerGenerarOrdenCompra.TerminiarRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    mostrarRequisicionesPendietes();
                    txtNumeroRequisicion.Text = string.Empty;
                    txtJustificacionRequisicion.Text = string.Empty;
                    idcapturapedido = 0;
                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(0, 0);
                }
            }

          
        }

        private void lookUpEditProveedorSuborden_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormGenerarOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (XtraMessageBox.Show("Desea cancelar la creación de suborden", "Creando suborden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    this.Close();
                }
            }
      

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (lookUpEditProveedorSuborden.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar el proveedor al cual solicitara los productos", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GenerarOrdenCompra.FormNuevoProducto modal = new FormNuevoProducto();
                modal.ShowDialog();
            }

        }

        private void gridViewListaDetallePedidoAutorizados_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gridViewListaDetallePedidoAutorizados_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void gridViewListaDetallePedidoAutorizados_Click(object sender, EventArgs e)
        {

        }

        private void gridControlListaTodasRequisiciones_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void gridControlListaTodasRequisiciones_DragOver(object sender, DragEventArgs e)
        {

        }

        private void gridViewSuborden_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridViewSuborden_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gridViewSuborden_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void gridViewDetalleSubOrden_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridControlDetalleSuborden_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void gridControlDetalleSuborden_DragOver(object sender, DragEventArgs e)
        {

        }

        private void gridViewListaDetallePedidoAutorizados_Click_1(object sender, EventArgs e)
        {
            if (gridViewListaDetallePedidoAutorizados.RowCount > 0)
            {
                txtJustificacionRequisicion.Text = gridViewListaDetallePedidoAutorizados.GetRowCellValue(gridViewListaDetallePedidoAutorizados.FocusedRowHandle, "Observaciones").ToString();
                txtNumeroRequisicion.Text = gridViewListaDetallePedidoAutorizados.GetRowCellValue(gridViewListaDetallePedidoAutorizados.FocusedRowHandle, "No. Requisición").ToString();
                idcapturapedido = Convert.ToInt32(gridViewListaDetallePedidoAutorizados.GetRowCellValue(gridViewListaDetallePedidoAutorizados.FocusedRowHandle, "No. Requisición"));
                GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                GridControlSuborden.ForceInitialize();
                gridViewSuborden.BestFitColumns();
            }
        }

        private void gridControlDetalleSuborden_DragDrop_1(object sender, DragEventArgs e)
        {
            bool Agregar = true;
            string rpta = "";
            if (gridViewSuborden.SelectedRowsCount == 0)
            {
                Agregar = false;
                XtraMessageBox.Show("Debe seleccionar los productos para poder agregar", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (lookUpEditProveedorSuborden.ItemIndex < 0)
            {
                Agregar = false;
                XtraMessageBox.Show("Debe seleccionar el proveedor al cual solicitara los productos", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
            {
                foreach (int indice in gridViewSuborden.GetSelectedRows())
                {
                    if (Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto")) == Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto")))
                    {
                        Agregar = false;
                        XtraMessageBox.Show("Uno o varios productos seleccionados ya estan agregados para el proveedor " + lookUpEditProveedorSuborden.Text, "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }

            if (Agregar)
            {
                bool ExisteProveedor = false;
                for (int i = 0; i < dtSubOrdenes.Rows.Count; i++)
                {
                    if (Convert.ToInt32(lookUpEditProveedorSuborden.EditValue) == Convert.ToInt32(dtSubOrdenes.Rows[i]["idproveedor"]))
                    {
                        ExisteProveedor = true;
                        idsuborden = Convert.ToInt32(dtSubOrdenes.Rows[i]["idsuborden"]);
                        break;
                    }
                }

                if (ExisteProveedor)
                {
                    bool existeProducto = false;
                    for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
                    {
                        foreach (int indice in gridViewSuborden.GetSelectedRows())
                        {
                            if (Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto")) == Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto")))
                            {
                                existeProducto = true;
                                XtraMessageBox.Show("Uno o varios productos seleccionados ya estan agregados para un proveedor", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }

                    if (existeProducto == false)
                    {

                        List<MSubOrdenDetalle> detalleEliminacion = new List<MSubOrdenDetalle>();
                        foreach (DataRow row in dtDetalleSubOrdenEliminacion.Rows)
                        {
                            MSubOrdenDetalle subordenDetalleElminacion = new MSubOrdenDetalle();
                            subordenDetalleElminacion.IdTienda = Configuraciones.Configuraciones.idtienda;
                            subordenDetalleElminacion.IdSuborden = Convert.ToInt32(row["idsuborden"]);
                            subordenDetalleElminacion.IdCapturaPedidoDetalle = 0;
                            subordenDetalleElminacion.IdSubOrdenDetalle = Convert.ToInt32(row["idsubordendetalle"]);
                            subordenDetalleElminacion.CantidadAutorizada = Convert.ToInt32(row["cantidad_autorizada"]);
                            subordenDetalleElminacion.PrecioCompra = Convert.ToInt32(row["precio_costo"]);
                            subordenDetalleElminacion.Precioa = Convert.ToDecimal(row["precioa"]);
                            subordenDetalleElminacion.Idproducto = Convert.ToInt32(row["idproducto"]);
                            subordenDetalleElminacion.Opcion = 0;
                            subordenDetalleElminacion.IdCapturaPedido = idcapturapedido;
                            detalleEliminacion.Add(subordenDetalleElminacion);
                        }



                        foreach (int indice in gridViewSuborden.GetSelectedRows())
                        {


                            DataRow dtRow = dtDetalleSubOrdenInsercion.NewRow();
                            dtRow["idproducto"] = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto"));
                            dtRow["codigo_producto"] = Convert.ToString(gridViewSuborden.GetRowCellValue(indice, "codigo_producto"));
                            dtRow["descripcion"] = Convert.ToString(gridViewSuborden.GetRowCellValue(indice, "descripcion_producto"));
                            dtRow["presentacion"] = Convert.ToString(gridViewSuborden.GetRowCellValue(indice, "presentacion"));
                            dtRow["cantidad_autorizada"] = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "cantidad_requerida"));
                            dtRow["precio_costo"] = 0;
                            dtRow["subtotal"] = 0;
                            dtRow["ultimo_costo"] = Convert.ToDecimal(gridViewSuborden.GetRowCellValue(indice, "ultimocosto"));
                            dtRow["precioa"] = Convert.ToDecimal(gridViewSuborden.GetRowCellValue(indice, "precioa"));
                            dtRow["nuevo_precio"] = 0;

                            dtDetalleSubOrdenInsercion.Rows.Add(dtRow);



                        }



                        List<MSubOrdenDetalle> detalleInsercion = new List<MSubOrdenDetalle>();
                        foreach (int indice in gridViewSuborden.GetSelectedRows())
                        {
                            MSubOrdenDetalle subordenDetalle = new MSubOrdenDetalle();
                            subordenDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                            subordenDetalle.IdSuborden = idsuborden;
                            subordenDetalle.IdCapturaPedidoDetalle = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idcapturapedidodetalle"));
                            subordenDetalle.CantidadAutorizada = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "cantidad_requerida"));
                            subordenDetalle.PrecioCompra = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "precio_costo"));
                            subordenDetalle.Precioa = Convert.ToDecimal(gridViewSuborden.GetRowCellValue(indice, "nuevo_precio"));
                            subordenDetalle.Idproducto = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto"));
                            subordenDetalle.IdCapturaPedido = idcapturapedido;
                            subordenDetalle.Opcion = 1;
                            detalleInsercion.Add(subordenDetalle);
                        }

                        rpta = ControllerGenerarOrdenCompra.AgregarProductosSubOrdenExistente(idcapturapedido,Configuraciones.Configuraciones.idtienda, detalleInsercion);


                        if (rpta == "OK")
                        {
                            //XtraMessageBox.Show("Los productos se agregaro a la subroden correctamente", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            idsuborden = 0;


                            GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                            GridControlSuborden.ForceInitialize();
                            gridViewSuborden.BestFitColumns();


                            dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                            dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                            gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                            gridControlDetalleSuborden.ForceInitialize();
                            gridViewDetalleSubOrden.BestFitColumns();

                            if (gridViewSuborden.DataRowCount == 0)
                            {
                                ControllerGenerarOrdenCompra.CompletarRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                                mostrarRequisicionesPendietes();
                                txtNumeroRequisicion.Text = string.Empty;
                                txtJustificacionRequisicion.Text = string.Empty;
                                idcapturapedido = 0;
                            }

                            dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);

                            if (dtDetalleSubOrdenInsercion.Rows.Count != 0)
                            {
                                idsuborden = Convert.ToInt32(dtDetalleSubOrdenInsercion.Rows[0]["idsuborden"]);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Ocurrio un error al agregar los productos, porfavor consulte a su administrador de datos: " + rpta, "Error al crear suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }



                    //____________________________________________________________________________________________________________________________________________________________________
                }
                else
                {
                    MSubOrden suborden = new MSubOrden();
                    suborden.IdTienda = Configuraciones.Configuraciones.idtienda;
                    suborden.IdProveedor = Convert.ToInt32(lookUpEditProveedorSuborden.EditValue);
                    suborden.IdUsuariio = Configuraciones.Configuraciones.idusuario;
                    suborden.IdCapturaPedido = idcapturapedido;

                    List<MSubOrdenDetalle> detalleInsercion = new List<MSubOrdenDetalle>();
                    foreach (int indice in gridViewSuborden.GetSelectedRows())
                    {
                        MSubOrdenDetalle subordenDetalle = new MSubOrdenDetalle();
                        subordenDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        subordenDetalle.IdCapturaPedidoDetalle = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idcapturapedidodetalle"));
                        subordenDetalle.CantidadAutorizada = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "cantidad_requerida"));
                        subordenDetalle.PrecioCompra = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "precio_costo"));
                        subordenDetalle.Precioa = Convert.ToDecimal(gridViewSuborden.GetRowCellValue(indice, "nuevo_precio"));
                        subordenDetalle.Idproducto = Convert.ToInt32(gridViewSuborden.GetRowCellValue(indice, "idproducto"));
                        subordenDetalle.IdCapturaPedido = idcapturapedido;
                        subordenDetalle.Opcion = 1;
                        detalleInsercion.Add(subordenDetalle);
                    }

                    rpta = ControllerGenerarOrdenCompra.CrearSubOrden(suborden, detalleInsercion);

                    if (rpta == "OK")
                    {
                        //XtraMessageBox.Show("La suborden se creo correctamente", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                        GridControlSuborden.ForceInitialize();
                        gridViewSuborden.BestFitColumns();


                        dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                        gridControlDetalleSuborden.ForceInitialize();
                        gridViewDetalleSubOrden.BestFitColumns();

                        dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);

                        idsuborden = ControllerGenerarOrdenCompra.IdSubOrden;

                        if (gridViewSuborden.DataRowCount == 0)
                        {
                            ControllerGenerarOrdenCompra.CompletarRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                            mostrarRequisicionesPendietes();
                            txtNumeroRequisicion.Text = string.Empty;
                            txtJustificacionRequisicion.Text = string.Empty;
                            idcapturapedido = 0;
                        }
                    }
                }
            }


            //if (gridViewSuborden.DataRowCount == 0)
            //{
            //    XtraMessageBox.Show("Los productos de la requisición se completaron", "Creando suborden");
            //}
            //else
            //{
            //    XtraMessageBox.Show("Aun hay productos pendientes de agregar a la suborden", "Creando suborden");
            //}
        }

        private void gridControlDetalleSuborden_DragOver_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Data.DataRow", false))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gridViewSuborden_MouseDown_1(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitLnfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
            {
                XtraMessageBox.Show("fuck", "moviendo");
            }
            if (e.Button == MouseButtons.Left && hitLnfo.RowHandle >= 0)
            {
                downHitInfo = hitLnfo;
            }
        }

        private void gridViewSuborden_MouseMove_1(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gridViewDetalleSubOrden_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Precio de compra")
                {
                    GridView view = (GridView)sender;

                    ControllerGenerarOrdenCompra.ActualizarPreciosYCostos(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idproducto")), 0, Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "precio_costo")), 1, false, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idsubordendetalle")));
                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    GridControlSuborden.ForceInitialize();
                    gridViewSuborden.BestFitColumns();


                    int cantida = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "cantidad_autorizada"));
                    decimal precioCosto = Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "precio_costo"));
                    gridViewDetalleSubOrden.SetRowCellValue(e.RowHandle, "subtotal", cantida * precioCosto);
                    gridViewDetalleSubOrden.SetRowCellValue(e.RowHandle, "ultimo_costo", precioCosto);

                    dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    //if (view.UpdateCurrentRow())
                    //{

                    //}
                    //gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                    //gridControlDetalleSuborden.ForceInitialize();
                    //gridViewDetalleSubOrden.BestFitColumns();
                    //gridViewDetalleSubOrden.PostEditor();
                   

                    dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                }

                if (e.Column.Caption == "Cantidad autorizar")
                {
                    int cantida = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "cantidad_autorizada"));
                    decimal precioCosto = Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "precio_costo"));
                    gridViewDetalleSubOrden.SetRowCellValue(e.RowHandle, "subtotal", cantida * precioCosto);

                    ControllerGenerarOrdenCompra.ActualizarCantidadSubOrdenDetalle(Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idsubordendetalle"))
                    , Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idproducto"))
                    , Configuraciones.Configuraciones.idtienda
                    , Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "cantidad_autorizada")));

                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    GridControlSuborden.ForceInitialize();
                    gridViewSuborden.BestFitColumns();


                    dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    //gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                    //gridControlDetalleSuborden.ForceInitialize();
                    //gridViewDetalleSubOrden.BestFitColumns();

                    dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                    //if (Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "gridViewDetalleSubOrden")))
                    //{

                    //}

                }

                if (e.Column.Caption == "Nuevo precio")
                {


                    if (Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "nuevo_precio")) < Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "ultimo_costo")))
                    {
                        XtraMessageBox.Show("El precio de venta debe ser mayor al ultimo costo", "Creando suborden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridViewDetalleSubOrden.SetRowCellValue(e.RowHandle,"nuevo_precio", Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "ultimo_costo")) + 1);
                    }
                    else
                    {
                        ControllerGenerarOrdenCompra.ActualizarPreciosYCostos(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idproducto")), Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "nuevo_precio")), 0, 0, false, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idsubordendetalle")));

                        GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                        GridControlSuborden.ForceInitialize();
                        gridViewSuborden.BestFitColumns();


                        dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                        //gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                        //gridControlDetalleSuborden.ForceInitialize();
                        //gridViewDetalleSubOrden.BestFitColumns();

                        dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                    }

                }
                if (e.Column.Caption == "Verificación")
                {
                    ControllerGenerarOrdenCompra.ActualizarPreciosYCostos(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idproducto")), Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "nuevo_precio")), 0, 2, Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "verificado")), Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(e.RowHandle, "idsubordendetalle")));

                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    GridControlSuborden.ForceInitialize();
                    gridViewSuborden.BestFitColumns();


                    dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                    //gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                    //gridControlDetalleSuborden.ForceInitialize();
                    //gridViewDetalleSubOrden.BestFitColumns();

                    dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);
                }
            }
            catch (Exception)
            {
                gridViewDetalleSubOrden.SetRowCellValue(e.RowHandle, "cantidad_autorizada", 1);
            }
        }

        private void repositoryItemButtonEdit1_Click_1(object sender, EventArgs e)
        {
           //ASDFASDF

        }

        private void gridViewDetalleSubOrden_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDetalleSubOrden.DataRowCount > 0)
            {
                FormModalHistorialPrecios modal = new FormModalHistorialPrecios();
                modal.id_producto = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "idproducto"));
                modal.id_proveedor = Convert.ToInt32(lookUpEditProveedorSuborden.EditValue);
                modal.proveedor = lookUpEditProveedorSuborden.Text;
                modal.producto = Convert.ToString(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "descripcion"));
                modal.ShowDialog();
            }
        }

        private void gridControlDetalleSuborden_ProcessGridKey(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab)
            //{
            //    //gridViewDetalleSubOrden.FocusedRowHandle = gridViewDetalleSubOrden.FocusedRowHandle;
            //    gridViewDetalleSubOrden.FocusedColumn = gridViewDetalleSubOrden.VisibleColumns[12];
            //    gridViewDetalleSubOrden.ShowEditor();
            //}
            //________________________________________
            //if (e.KeyCode == Keys.Tab)
            //{
            //    GridControl grid = sender as GridControl;
            //    GridView view = grid.FocusedView as GridView;
            //    if ((e.Modifiers == Keys.None && view.IsLastRow && view.FocusedColumn.VisibleIndex == view.VisibleColumns.Count - 1)
            //        || (e.Modifiers == Keys.Shift && view.IsFirstRow && view.FocusedColumn.VisibleIndex == 0))
            //    {
            //        if (view.IsEditing)
            //            view.CloseEditor();
            //        grid.SelectNextControl(grid, e.Modifiers == Keys.None, false, false, true);
            //        e.Handled = true;
            //    }

            //}

            //if ((e.KeyCode == System.Windows.Forms.Keys.Enter) || (e.KeyCode == System.Windows.Forms.Keys.Tab))
            //{
            //    gridViewDetalleSubOrden.FocusedColumn = gridViewDetalleSubOrden.GetVisibleColumn(12);
            //    //if (gridViewDetalleSubOrden.FocusedRowHandle != gridViewDetalleSubOrden.RowCount - 1)
            //    //    gridViewDetalleSubOrden.FocusedRowHandle += 1;
            //    gridViewDetalleSubOrden.ShowEditor();
            //    e.Handled = true;

            //}
            //if (e.Shift && (e.KeyCode == System.Windows.Forms.Keys.Enter) && (gv.FocusedColumn == gv.GetVisibleColumn(0)))
            //{
            //    gv.FocusedColumn = gv.GetVisibleColumn(gv.VisibleColumns.Count - 1);
            //    if (gv.FocusedRowHandle != 0)
            //        gv.FocusedRowHandle -= 1;
            //    gv.ShowEditor();
            //    e.Handled = true;
            //}

        }

        private void gridControlDetalleSuborden_EditorKeyDown(object sender, KeyEventArgs e)
        {

        }


        void QuitarProductosDeOrden()
        {
            if (XtraMessageBox.Show("Desea quitar el producto de la lista?", "Agregando productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                ControllerGenerarOrdenCompra.EliminarProductoDeSubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "idproducto")), Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "idsubordendetalle")), Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "id_captura_pedido")));

                mostrarRequisicionesPendietes();
                GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                GridControlSuborden.ForceInitialize();
                gridViewSuborden.BestFitColumns();


                dtDetalleSubOrdenInsercion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                dtDetalleSubOrdenEliminacion = ControllerGenerarOrdenCompra.SPMostrar_SubOrdenDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditProveedorSuborden.EditValue));
                gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
                gridControlDetalleSuborden.ForceInitialize();
                gridViewDetalleSubOrden.BestFitColumns();
                dtSubOrdenes = ControllerGenerarOrdenCompra.MostrarSubOrdenesConSuProveedor(Configuraciones.Configuraciones.idtienda);

                if (Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(gridViewDetalleSubOrden.FocusedRowHandle, "id_captura_pedido")) > 0)
                {
                    GridControlSuborden.DataSource = ControllerGenerarOrdenCompra.MostrarDetalleDeRequisicion(Configuraciones.Configuraciones.idtienda, idcapturapedido);
                    GridControlSuborden.ForceInitialize();
                    gridViewSuborden.BestFitColumns();
                }

                //int rowIndex = gridViewDetalleSubOrden.FocusedRowHandle;
                //DataRow row = this.dtDetalleCaracteristicasInsercion.Rows[rowIndex];
                //this.dtDetalleCaracteristicasInsercion.Rows.Remove(row);
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            QuitarProductosDeOrden();
        }

        private void gridViewDetalleSubOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                QuitarProductosDeOrden();
            }
        }

        private void FormGenerarOrdenCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }
    }
}