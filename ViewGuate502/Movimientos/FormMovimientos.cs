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

namespace ViewGuate502.Movimientos
{
    public partial class FormMovimientos : DevExpress.XtraEditors.XtraForm
    {

        bool EsBotonOTecla;

        DataTable dtSubTraslados;
        DataTable dtDetalleInsercion;

        DataTable dtDetalleSubTraslado;

        DataTable dtSubtrasladoTienda;
        public int idbodega;
        public int idsubtraslado;

        public int id_tipo_de_sub_traslado;
        public int id_tipo_de_documento;
        string origen="";

        private static FormMovimientos _Instancia;
        public FormMovimientos()
        {
            InitializeComponent();
        }

        public static FormMovimientos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormMovimientos();
            }
            return _Instancia;
        }




        //____________________________________________________

        //______________________________________________________________________________________________________________________
        //________________________________________________funcion para mostrar los productos en el lookpuedit______________________________________________________________________

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }
        //______________________________________________________________________________________________________________________
        //______________________________________________________________________________________________________________________


        public void ActualizarDespuesDeConfirmarTraslado()
        {

            if (lookUpEditBodegas.ItemIndex > -1)
            {
                idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "0"));
            }
            else
            {
                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0, "0"));
            }
            dtDetalleInsercion.Rows.Clear();


            dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

            dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
            gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
            gridControlSubTrasladoStandBy.ForceInitialize();
            gridViewSubTrasladoStandBy.BestFitColumns();

            dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

            if (dtSubtrasladoTienda.Rows.Count > 0)
            {
                idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
            }
            else
            {
                idsubtraslado = 0;
            }


            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
            txtBuscarProducto.Text = string.Empty;
            spinEditDisponible.Value = 0;
            spinEditCantidad.Value = 0;
        }

        public void Creartabla()
        {
            dtDetalleInsercion = new DataTable();
            dtDetalleInsercion.Columns.Add("idexistenciadetalle", typeof(int));
            dtDetalleInsercion.Columns.Add("idproducto", typeof(int));
            dtDetalleInsercion.Columns.Add("codigo", typeof(string));
            dtDetalleInsercion.Columns.Add("nombre", typeof(string));
            dtDetalleInsercion.Columns.Add("presentacion", typeof(string));
            dtDetalleInsercion.Columns.Add("cantidadautorizar", typeof(int));
            dtDetalleInsercion.Columns.Add("stock", typeof(int));
            dtDetalleInsercion.Columns.Add("sub_stock", typeof(int));
    
        }

        void Guardar()
        {
            bool grabar = true;
            bool mostrarMensaje = false;
            string rpta = "";
            if (lookUpEditDestino.ItemIndex < 0)
            {
                XtraMessageBox.Show("DEBE SELECCIONAR UNA DESTINÓ AL CUAL SERÁN TRASLADADOS LOS PRODUCTOS", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grabar = false;
            }
            if (gridViewSubTrasladoStandBy.DataRowCount == 0)
            {
                XtraMessageBox.Show("NO HAY PRODUCTOS AGREGADOS AL DESTINO SELECCIONADO", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grabar = false;
            }
            for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
            {
                if (Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "stock")) < Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "cantidad")))
                {
                    gridViewSubTrasladoStandBy.SelectRow(i);

                    mostrarMensaje = true;
                }
            }
            if (mostrarMensaje)
            {
                XtraMessageBox.Show("LOS PRODUCTOS SELECCIONADOS EN LA LISTA SON MAYORES AL STOCK ACTUAL DEL INVENTARIO, DEBE ELIMINARLOS", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                grabar = false;
            }

            if (id_tipo_de_sub_traslado == 1)
            {
                if (string.IsNullOrWhiteSpace(dateEditFechaIngreso.Text))
                {
                    XtraMessageBox.Show("DEBE INGRESAR LA FECHA DE INGRESO DE FORMA CORRECTA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grabar = false;
                }
            }
            if (id_tipo_de_sub_traslado == 2)
            {
                grabar = true;
            }

            //if (mostrar)
            //{
            //    FormDetalleSubTrasladoTienda dialog = new FormDetalleSubTrasladoTienda();
            //    dialog.idsubtraslado = idsubtraslado;
            //    dialog.origen = origen;
            //    dialog.destino = Convert.ToString(lookUpEditDestino.Text);
            //    dialog.dtDetalleInsercion = dtDetalleSubTraslado;
            //    dialog.id_origen = Configuraciones.Configuraciones.idtienda;
            //    dialog.id_destino = Convert.ToInt32(lookUpEditDestino.EditValue);
            //    dialog.tipo_salida = id_tipo_de_sub_traslado;
            //    dialog.id_tipo_de_documento = id_tipo_de_documento;
            //    dialog.ShowDialog();
            //}
            if (grabar)
            {
                if (XtraMessageBox.Show("DESEA REALIZAR LA SALIDA", "COMERCIALES AGLY", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    MSalidaEnc salida = new MSalidaEnc();
                    salida.IdTienda = Configuraciones.Configuraciones.idtienda;
                    salida.IdUsuario = Configuraciones.Configuraciones.idusuario;
                    salida.IdDocumentoDeInventrio = id_tipo_de_documento;
                    salida.IdSerie = 1;
                    salida.IdDestino = id_tipo_de_documento == 4 ? Convert.ToInt32(lookUpEditDestino.EditValue) : 0;
                    salida.IdBodegaDestino = id_tipo_de_documento == 5 ? Convert.ToInt32(lookUpEditDestino.EditValue) : 0;
                    salida.Observaciones = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                    salida.Descripcion = id_tipo_de_documento == 4 ? "TIENDA ORIGEN: " + origen + ". TIENDA DESTINO: " + Convert.ToString(lookUpEditDestino.Text) : "BODEGA ORIGEN: " + origen + ". BODEGA DESTINO: " + Convert.ToString(lookUpEditDestino.Text);
                    salida.Origen = id_tipo_de_documento == 4 ? "TIENDA ORIGEN: " + origen : "BODEGA ORIGEN: " + origen;
                    salida.Destino = id_tipo_de_documento == 4 ? "TIENDA DESTINO: " + origen : "BODEGA DESTINO: " + Convert.ToString(lookUpEditDestino.Text);
                    salida.FechaDeIngreso = id_tipo_de_sub_traslado == 1 ? Convert.ToDateTime(dateEditFechaIngreso.EditValue) : DateTime.Now;
                    salida.Serie = "A";
                    salida.SeraIngresado = true;
                    salida.TipoSalida = id_tipo_de_sub_traslado;
                    salida.IdSubTraslado = idsubtraslado;
                    salida.NumeroEnvio = 0;
                    salida.Ingresado = false;


                    List<MSalidaDetalle> DetalleInserccion = new List<MSalidaDetalle>();
                    for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
                    {
                        MSalidaDetalle SalidaDetalle = new MSalidaDetalle();
                        SalidaDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        SalidaDetalle.IdSubTrasladoDetalle = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "id_sub_traslado_detalle"));
                        SalidaDetalle.IdProducto = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "idproducto"));
                        SalidaDetalle.Cantidad = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "cantidad"));
                        SalidaDetalle.IdExistenciaDetalle = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "id_existencia_detalle"));
                        SalidaDetalle.IdBodega = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "id_bodega"));
                        SalidaDetalle.EsVenta = 0;
                        DetalleInserccion.Add(SalidaDetalle);

                    }
                    List<MSerieProducto> IngresoDetalleInsercionSeriesProducto = new List<MSerieProducto>();
                    rpta = ControllerSalidas.Salidas(salida, DetalleInserccion, IngresoDetalleInsercionSeriesProducto);
                    if (rpta == "OK")
                    {
                        string res = "";
                        DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                            ControllerSalidas.Correlativo// correlativo del documento
                            , Configuraciones.Configuraciones.idtienda // id del documento
                            , id_tipo_de_documento// id tienda donde se reailizo la operacion
                            , Configuraciones.Configuraciones.idtienda // id origen
                            , Convert.ToInt32(lookUpEditDestino.EditValue)
                            ,false
                            ,0);// id destino

                        res = ControllerNotificacion.Agregar(Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_documento, "", "A", ControllerSalidas.Correlativo,false);
                        //if (res=="OK")
                        //{
                        //    XtraMessageBox.Show("sii");
                        //}
                        //else
                        //{
                        //    XtraMessageBox.Show("Ocurrio un error al crear el traslado, profavor consulte a su administrador de datos " + res, "Error al crear traslado");
                        //}

                        ActualizarDespuesDeConfirmarTraslado();



                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error al crear el traslado, profavor consulte a su administrador de datos " + rpta, "Error al crear traslado");
                    }
                }
               
            }

           
        }

        void QuitarProducto()
        {
            if (gridViewSubTrasladoStandBy.DataRowCount > 0)
            {
                bool regresar = true;
                bool mostrarMensaje = false;
                string rpta = "";
                if (gridViewSubTrasladoStandBy.DataRowCount == 0)
                {
                    XtraMessageBox.Show("NO HAY PRODUCTOS PARA REGRESAR", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regresar = false;
                }
                if (lookUpEditDestino.ItemIndex < 0)
                {
                    XtraMessageBox.Show("SELECCIONE DESTINO PARA QUITAR LOS PRODUCTOS", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regresar = false;
                }
                if (gridViewSubTrasladoStandBy.SelectedRowsCount == 0)
                {
                    XtraMessageBox.Show("SELECCIONE LOS PRODUCTOS PARA QUITAR", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regresar = false;
                }



               



                if (regresar)
                {
                    List<MSubTrasladoTiendaDetalle> detalleEliminacionRegreso = new List<MSubTrasladoTiendaDetalle>();

                    foreach (int indice in gridViewSubTrasladoStandBy.GetSelectedRows())
                    {
                        MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
                        detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
                        detalle.Idsubtraslado = idsubtraslado;
                        detalle.IdSubtrasladoDetalle = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(indice, "id_sub_traslado_detalle"));
                        detalle.IdExistenciaDetalle = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(indice, "id_existencia_detalle"));
                        detalle.Cantidadtrasladar = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(indice, "cantidad"));
                        detalle.Stock = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(indice, "stock"));
                        detalleEliminacionRegreso.Add(detalle);
                    }
                    rpta = ControllerSubTrasladoTiendas.QuitarProductosDeTiendaEnStandBy(detalleEliminacionRegreso);
                    if (rpta == "OK")
                    {
                        //alertControl1.Show(this, "Productos regresados ", "Los productos se regresaron correctametne");

                        if (lookUpEditBodegas.ItemIndex > -1)
                        {
                            idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "0"));
                        }
                        else
                        {
                            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0, "0"));
                        }
                        dtDetalleInsercion.Rows.Clear();


                        dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

                        dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
                        gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
                        gridControlSubTrasladoStandBy.ForceInitialize();
                        gridViewSubTrasladoStandBy.BestFitColumns();

                        dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

                        if (dtSubtrasladoTienda.Rows.Count > 0)
                        {
                            idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
                        }
                        else
                        {
                            idsubtraslado = 0;
                        }


                        mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
                        txtBuscarProducto.Text = string.Empty;
                        spinEditDisponible.Value = 0;
                        spinEditCantidad.Value = 0;

                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un erro al quitar los productos, porfavor consulte a su adminsitrador de datos " + rpta, "Error al  quitar");
                    }
                }
            }
        }
        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            if (id_tipo_de_sub_traslado == 1)// si es tienda
            {
                layoutControlItemDestino.Text = "TIENDA";
                origen = Configuraciones.Configuraciones.tienda;
                this.Text = "TRASLADO DE PRODUCTOS A OTRAS TIENDAS";
            }
            if (id_tipo_de_sub_traslado == 2) // si es bodega
            {
                layoutControlItemDestino.Text = "BODEGA";
                lyFechaDeIngreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                origen = "";
                this.Text = "TRASLADO DE PRODUCTOS A OTRAS BODEGAS";
            }

            if (!Configuraciones.Configuraciones.InventarioCerrado())
            {
                layoutControlGroupBodega.Enabled = false;
                layoutControlGroupDestino.Enabled = false;
            }
            else
            {
                Creartabla();
                lookUpEditBodegas.Properties.DataSource = ControllerTrasladoTiedas.MostrarBodegaOrigen(Configuraciones.Configuraciones.idtienda);
                lookUpEditBodegas.Properties.ValueMember = "idbodega";
                lookUpEditBodegas.Properties.DisplayMember = "nombre";

                if (id_tipo_de_sub_traslado == 1) // si es tienda
                {
                    lookUpEditDestino.Properties.DataSource = ControllerTrasladoTiedas.MostrarTiendasDeDestino(Configuraciones.Configuraciones.idtienda);
                    lookUpEditDestino.Properties.ValueMember = "idtienda";
                    lookUpEditDestino.Properties.DisplayMember = "nombre";
                }
                dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);
            }
         

        }

        private void lookUpEditBodegas_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBodegas.ItemIndex > -1)
            {
                if (id_tipo_de_sub_traslado == 2) // si es bodega
                {
                    if (Convert.ToInt32(lookUpEditBodegas.EditValue) == Convert.ToInt32(lookUpEditDestino.EditValue))
                    {
                        if (lookUpEditDestino.ItemIndex > -1)
                        {
                            dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, 0, id_tipo_de_sub_traslado);

                            dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, 0, id_tipo_de_sub_traslado);
                            gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
                            gridControlSubTrasladoStandBy.ForceInitialize();
                            gridViewSubTrasladoStandBy.BestFitColumns();

                        }
                    }
                    lookUpEditDestino.Properties.DataSource = ControllerTrasladoBodegas.MostrarBodegaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditBodegas.EditValue));
                    lookUpEditDestino.Properties.ValueMember = "idbodega";
                    lookUpEditDestino.Properties.DisplayMember = "nombre";
                    origen = lookUpEditBodegas.Text;
                }
                idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega,"00-developer-..."));
            }

        }


        private void gridViewSubTrasladoStandBy_DoubleClick(object sender, EventArgs e)
        {
            //FormDetalleSubTrasladoTienda dialog = new FormDetalleSubTrasladoTienda();
            //dialog.idtiendadestino = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(gridViewSubTrasladoStandBy.FocusedRowHandle, "idtiendadestino"));
            //dialog.idsubtraslado = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(gridViewSubTrasladoStandBy.FocusedRowHandle, "idsubtraslado"));
            //dialog.tienda = Convert.ToString(gridViewSubTrasladoStandBy.GetRowCellValue(gridViewSubTrasladoStandBy.FocusedRowHandle, "tienda"));
            //dialog.observaciones = Convert.ToString(gridViewSubTrasladoStandBy.GetRowCellValue(gridViewSubTrasladoStandBy.FocusedRowHandle, "observaciones"));
            //dialog.ShowDialog();
            //gridControlListaProductosEnBodega.DataSource = ControllerTrasladoTiedas.MostrarProductosEnBodega(idbodega, Configuraciones.Configuraciones.idtienda);
            //MostrarSubOrdenNoConfirmado();
        }

        private void gridViewSubTrasladoStandBy_Click(object sender, EventArgs e)
        {
            //idsubtraslado = Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(gridViewSubTrasladoStandBy.FocusedRowHandle, "idsubtraslado"));


        }

        private void FormMovimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EsBotonOTecla)
            {
                e.Cancel = false;
                _Instancia = null;
            }
            else
            {
                if (XtraMessageBox.Show("DESEA SALIR DEL MODULO", "COMERCIALES AGLY", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    e.Cancel = false;
                    _Instancia = null;
                }
                else
                {
                    e.Cancel = true;

                }


            }
        }

        private void lookUpEditTiendas_EditValueChanged(object sender, EventArgs e)
        {

            if (lookUpEditDestino.ItemIndex > -1)
            {
                dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue),id_tipo_de_sub_traslado);

                dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
                gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
                gridControlSubTrasladoStandBy.ForceInitialize();
                gridViewSubTrasladoStandBy.BestFitColumns();
            }


            if (dtSubtrasladoTienda.Rows.Count > 0)
            {
                idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
            }
            else
            {
                idsubtraslado = 0;
            }
        }

        private void btnDetalleTraslado_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void lookUpEditProductos_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {

        }

        private void lookUpEditBodegas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuscarProducto.Focus();
            }
        }

        private void lookUpEditProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                try
                {
                    spinEditDisponible.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("sub_stock"));
                    spinEditCantidad.Focus();
                }
                catch (Exception)
                {

                    XtraMessageBox.Show(this, "DEBE INGRESAR CORRECTAMENTE EL DATO A BUSCAR", "COMERCIALES AGLY");
                }


            }

        }

        private void spinEditCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool AgrearProducto = true;

                bool YaExisteTienda = false;
                bool existeProducto = false;

                string rpta = "";
                if (lookUpEditProductos.ItemIndex < 0)
                {
                    XtraMessageBox.Show("DEBE INDICAR EL PRODUCTO", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgrearProducto = false;
                }
                if (lookUpEditDestino.ItemIndex < 0)
                {
                    XtraMessageBox.Show("DEBE SELECCIONAR EL DESTINO", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgrearProducto = false;
                }

                if (spinEditCantidad.Value == 0)
                {
                    XtraMessageBox.Show("INGRESE LA CANTIDAD", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgrearProducto = false;
                }
                if (spinEditCantidad.Value > spinEditDisponible.Value)
                {
                    XtraMessageBox.Show("LA CANTIDAD DEBE SER MAYOR O IGUAL AL STOCK", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    spinEditCantidad.Value = 0;
                    AgrearProducto = false;
                }
                if (spinEditDisponible.Value == 0)
                {
                    AgrearProducto = false;
                }

                //for (int i = 0; i < gridViewProductosEnBodega.DataRowCount; i++)
                //{
                //    if (Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "idexistenciadetalle")) == Convert.ToInt64(lookUpEditProductos.EditValue))
                //    {
                //        if (spinEditCantidad.Value +(Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "cantidadautorizar"))) > Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "sub_stock")))
                //        {
                //            XtraMessageBox.Show("EXISTE UN PRODUCTO AGREGADO CON UNA CANTIDAD", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            spinEditCantidad.Value = 0;
                //            AgrearProducto = false;
                //            break;
                //        }
                //    }
                //}


                for (int i = 0; i < dtSubTraslados.Rows.Count; i++)
                {
                    if (id_tipo_de_sub_traslado == 1) // si es tienda = 1
                    {
                        if (Convert.ToInt32(lookUpEditDestino.EditValue) == Convert.ToInt32(dtSubTraslados.Rows[i]["id_tienda_destino"]))
                        {
                            YaExisteTienda = true;
                            break;
                        }
                    }
                    if (id_tipo_de_sub_traslado == 2) // si es bodega
                    {
                        if (Convert.ToInt32(lookUpEditDestino.EditValue) == Convert.ToInt32(dtSubTraslados.Rows[i]["id_bodega_destino"]))
                        {
                            YaExisteTienda = true;
                            break;
                        }
                    }

                }

                if (AgrearProducto)
                {
                    List<MSubTrasladoTiendaDetalle> detalleActualizacion = new List<MSubTrasladoTiendaDetalle>();

                    if (YaExisteTienda)
                    {


                        bool agregar = true;
                        for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
                        {
                            if (Convert.ToInt64(gridViewSubTrasladoStandBy.GetRowCellValue(i,"id_existencia_detalle")) == Convert.ToInt64(lookUpEditProductos.EditValue))
                            {
                                agregar = false;
                                if (XtraMessageBox.Show("EL PRODUCTO YA EXISTE, ¿DESEA AUMENTAR LA CANTIDAD? ", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo) != DialogResult.No)
                                {
                                    MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
                                    detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
                                    detalle.Idsubtraslado = idsubtraslado;
                                    detalle.IdSubtrasladoDetalle = 0;
                                    detalle.IdExistenciaDetalle = Convert.ToInt32(lookUpEditProductos.EditValue);
                                    detalle.Cantidadtrasladar = Convert.ToInt32(spinEditCantidad.Value);
                                    detalleActualizacion.Add(detalle);
                                }
                            }
                        }

                        List<MSubTrasladoTiendaDetalle> detalleInsercion = new List<MSubTrasladoTiendaDetalle>();

                        if (agregar)
                        {
                            MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
                            detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
                            detalle.Idsubtraslado = idsubtraslado;
                            detalle.Idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                            detalle.IdExistenciaDetalle = Convert.ToInt32(lookUpEditProductos.EditValue);
                            detalle.Cantidadtrasladar = Convert.ToInt32(spinEditCantidad.Value);
                            detalle.IdtiendaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
                            detalleInsercion.Add(detalle);

                        }



                        if (detalleInsercion.Count > 0 || detalleActualizacion.Count > 0)
                        {
                            rpta = ControllerSubTrasladoTiendas.AgregarTiendaEnStandBy(idsubtraslado, detalleInsercion, detalleActualizacion);
                            if (rpta == "OK")
                            {


                                if (lookUpEditBodegas.ItemIndex > -1)
                                {
                                    idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                                    mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "0"));
                                }
                                else
                                {
                                    mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0, "0"));
                                }
                                dtDetalleInsercion.Rows.Clear();


                                dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

                                dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
                                gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
                                gridControlSubTrasladoStandBy.ForceInitialize();
                                gridViewSubTrasladoStandBy.BestFitColumns();

                                dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

                                if (dtSubtrasladoTienda.Rows.Count > 0)
                                {
                                    idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
                                }
                                else
                                {
                                    idsubtraslado = 0;
                                }


                                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
                                txtBuscarProducto.Text = string.Empty;
                                spinEditDisponible.Value = 0;
                                spinEditCantidad.Value = 0;
                            }
                            else
                            {
                                XtraMessageBox.Show("Ocurrio un erro al crear el subraslado, porfavor consulte a su adminsitrador de datos " + rpta, "Error al guardar");

                            }
                        }

                    }
                    //____________________________________________________CREAR NUEVO_________________________________________________________________________
                    else
                    {
                        MSubTrasladoTienda traslado = new MSubTrasladoTienda();
                        traslado.Idtienda = Configuraciones.Configuraciones.idtienda;
                        if (id_tipo_de_sub_traslado == 1) // si es tienda = 1
                        {
                            traslado.Idtiendadestino = Convert.ToInt32(lookUpEditDestino.EditValue);
                            traslado.IdBodegaDestino = 0;
                        }
                        if (id_tipo_de_sub_traslado == 2) // si es bodega 
                        {
                            traslado.Idtiendadestino = 0;
                            traslado.IdBodegaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
                        }
                        traslado.IdUsuario = Configuraciones.Configuraciones.idusuario;
                        traslado.IdTipoSubTraslado = id_tipo_de_sub_traslado;

                        List<MSubTrasladoTiendaDetalle> detalleInsercion = new List<MSubTrasladoTiendaDetalle>();
                        MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
                        detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
                        detalle.Idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                        detalle.IdExistenciaDetalle = Convert.ToInt32(lookUpEditProductos.EditValue);
                        detalle.Cantidadtrasladar = Convert.ToInt32(spinEditCantidad.Value);
                        detalle.IdtiendaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
                        detalleInsercion.Add(detalle);

                        rpta = ControllerSubTrasladoTiendas.GuardarSubTraslado(traslado, detalleInsercion);
                        if (rpta == "OK")
                        {
                            //alertControl1.Show(this, "Subtraslado creado correctamente", "Los productos se agregaron correctametne");

                            if (lookUpEditBodegas.ItemIndex > -1)
                            {
                                idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "0"));
                            }
                            else
                            {
                                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0, "0"));
                            }
                            dtDetalleInsercion.Rows.Clear();


                            dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

                            dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
                            gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
                            gridControlSubTrasladoStandBy.ForceInitialize();
                            gridViewSubTrasladoStandBy.BestFitColumns();

                            dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

                            if (dtSubtrasladoTienda.Rows.Count > 0)
                            {
                                idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
                            }
                            else
                            {

                                idsubtraslado = ControllerSubTrasladoTiendas.IdSubtraslado;
                            }


                            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
                            txtBuscarProducto.Text = string.Empty;
                            spinEditDisponible.Value = 0;
                            spinEditCantidad.Value = 0;
                            txtBuscarProducto.Focus();

                        }
                        else
                        {
                            XtraMessageBox.Show("Ocurrio un erro al crear el subraslado, porfavor consulte a su adminsitrador de datos " + rpta, "Error al guardar");

                        }
                    }


                }
                //if (AgrearProducto)
                //{
                //    bool agregar = true;
                //    foreach (DataRow item in dtDetalleInsercion.Rows)
                //    {
                //        if (Convert.ToInt64(item["idexistenciadetalle"]) == Convert.ToInt64(lookUpEditProductos.EditValue))
                //        {
                //            agregar = false;
                //            if (XtraMessageBox.Show("EL PRODUCTO YA EXISTE, ¿DESEA AUMENTAR LA CANTIDAD? ", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo) != DialogResult.No)
                //            {
                //                item["cantidadautorizar"] = Convert.ToInt32(item["cantidadautorizar"]) + Convert.ToInt32(spinEditCantidad.Value);
                //                break;
                //            }
                //        }
                //    }
                //    if (agregar)
                //    {
                //        DataRow dtRow = dtDetalleInsercion.NewRow();
                //        dtRow["idexistenciadetalle"] = Convert.ToInt64(lookUpEditProductos.EditValue);
                //        dtRow["idproducto"] = lookUpEditProductos.GetColumnValue("idproducto");
                //        dtRow["codigo"] = lookUpEditProductos.GetColumnValue("codigo").ToString();
                //        dtRow["nombre"] = lookUpEditProductos.GetColumnValue("nombre").ToString();
                //        dtRow["presentacion"] = lookUpEditProductos.GetColumnValue("presentacion").ToString();
                //        dtRow["cantidadautorizar"] = Convert.ToInt32(spinEditCantidad.Value);
                //        dtRow["sub_stock"] = lookUpEditProductos.GetColumnValue("sub_stock").ToString();
                //        dtRow["stock"] = lookUpEditProductos.GetColumnValue("stock").ToString();
                //        dtDetalleInsercion.Rows.Add(dtRow);

                //        mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
                //        txtBuscarProducto.Text = string.Empty;
                //        spinEditDisponible.Value = 0;
                //        spinEditCantidad.Value = 0;
                //    }

                //    gridControlListaProductosEnBodega.ForceInitialize();
                //    gridViewProductosEnBodega.BestFitColumns();

                //    txtBuscarProducto.Focus();

                //}
            }
           
        }

        private void btnEnviarAtienda_Click(object sender, EventArgs e)
        {
            //bool guardar = true;
            //bool YaExisteTienda = false;
            //bool mostrarMensaje = false;
            //string rpta = "";
            //if (lookUpEditBodegas.ItemIndex < 0)
            //{
            //    XtraMessageBox.Show("DEBE SELECCIONAR UNA BODEGA PARA VER SUS PRODUCTOS EN EXISTENCIA", Configuraciones.Configuraciones.NombreDelSistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    guardar = false;
            //}
            //if (lookUpEditDestino.ItemIndex < 0)
            //{
            //    XtraMessageBox.Show("DEBE SELECCIONAR EL DESTINO", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    guardar = false;
            //}
            ////if (idsubtraslado == 0)
            ////{
            ////    XtraMessageBox.Show("Debe selecionar una tienda de destiono al cual seran trasladados los productos", "Creando subtraslado a tiendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////    guardar = false;
            ////}
            //for (int i = 0; i < gridViewProductosEnBodega.DataRowCount; i++)
            //{

            //    if (Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "cantidadautorizar")) == 0)
            //    {
            //        XtraMessageBox.Show("UNO O MÁS PRODUCTOS SELECCIONADOS NO TIENEN CANTIDAD PARA AUTORIZAR, LA CANTIDAD DEBE SER MAYOR A 0", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        guardar = false;
            //        break;
            //    }
            //}
            //if (gridViewProductosEnBodega.DataRowCount == 0)
            //{
            //    XtraMessageBox.Show("DEBE AGREGAR LOS PRODUCTOS QUE DESEA TRASLADAR", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    guardar = false;
            //}

            //for (int i = 0; i < dtSubTraslados.Rows.Count; i++)
            //{
            //    if (id_tipo_de_sub_traslado == 1) // si es tienda = 1
            //    {
            //        if (Convert.ToInt32(lookUpEditDestino.EditValue) == Convert.ToInt32(dtSubTraslados.Rows[i]["id_tienda_destino"]))
            //        {
            //            YaExisteTienda = true;
            //            break;
            //        }
            //    }
            //    if (id_tipo_de_sub_traslado == 2) // si es bodega
            //    {
            //        if (Convert.ToInt32(lookUpEditDestino.EditValue) == Convert.ToInt32(dtSubTraslados.Rows[i]["id_bodega_destino"]))
            //        {
            //            YaExisteTienda = true;
            //            break;
            //        }
            //    }

            //}


            //if (lookUpEditDestino.ItemIndex > -1)
            //{
            //    for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
            //    {
            //        if (Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "stock")) < Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "cantidad_trasladar")))
            //        {
            //            gridViewSubTrasladoStandBy.SelectRow(i);

            //            mostrarMensaje = true;
            //        }
            //    }
            //    if (mostrarMensaje)
            //    {
            //        XtraMessageBox.Show("LOS PRODUCTOS SELECCIONADOS EN LA LISTA SON MAYOR AL STOCK ACTUAL, DEBE ELIMINARLOS", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        guardar = false;
            //        layoutControlItemBtnEliminar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            //    }
            //}


            //if (guardar)
            //{
            //    List<MSubTrasladoTiendaDetalle> detalleActualizacion = new List<MSubTrasladoTiendaDetalle>();

            //    if (YaExisteTienda)
            //    {
            //        bool existeProducto = false;
            //        for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
            //        {
            //            for (int j = 0; j < gridViewProductosEnBodega.DataRowCount; j++)
            //            {
            //                if (Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(j, "idexistenciadetalle")) == Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "id_existencia_detalle")))
            //                {
            //                    existeProducto = true;

            //                }
            //            }
            //        }

            //        if (existeProducto)
            //        {
                      
            //            if (XtraMessageBox.Show("UNO O VARIOS PRODUCTOS SELECCIONADOS YA ESTÁN AGREGADOS PARA UNA TIENDA, DESEA AUMENTAR LA CANTIDAD?", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            //            {
            //                for (int i = 0; i < gridViewSubTrasladoStandBy.DataRowCount; i++)
            //                {
            //                    for (int j = 0; j < gridViewProductosEnBodega.DataRowCount; j++)
            //                    {
            //                        if (Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(j, "idproducto")) == Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(i, "idproducto")))
            //                        {
            //                            MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
            //                            detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
            //                            detalle.Idsubtraslado = idsubtraslado;
            //                            detalle.IdSubtrasladoDetalle = 0;
            //                            detalle.IdExistenciaDetalle = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(j, "idexistenciadetalle"));
            //                            detalle.Cantidadtrasladar = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(j, "cantidadautorizar"));
            //                            detalleActualizacion.Add(detalle);

            //                        }
            //                    }
            //                }
            //            }
            //        }

            //        List<MSubTrasladoTiendaDetalle> detalleInsercion = new List<MSubTrasladoTiendaDetalle>();

            //        for (int i = 0; i < gridViewProductosEnBodega.DataRowCount; i++)
            //        {
            //            bool agregar = true;
            //            for (int j = 0; j < gridViewSubTrasladoStandBy.DataRowCount; j++)
            //            {
            //                if (Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "idproducto")) != Convert.ToInt32(gridViewSubTrasladoStandBy.GetRowCellValue(j, "idproducto")))
            //                {
            //                    agregar = true;
            //                }
            //                else
            //                {
            //                    agregar = false;
            //                    break;
            //                }
            //            }

            //            if (agregar)
            //            {
            //                MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
            //                detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
            //                detalle.Idsubtraslado = idsubtraslado;
            //                detalle.Idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
            //                detalle.IdExistenciaDetalle = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "idexistenciadetalle"));
            //                detalle.Cantidadtrasladar = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "cantidadautorizar"));
            //                detalle.IdtiendaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
            //                detalleInsercion.Add(detalle);

            //            }
            //        }



            //        if (detalleInsercion.Count > 0 || detalleActualizacion.Count > 0)
            //        {
            //            rpta = ControllerSubTrasladoTiendas.AgregarTiendaEnStandBy(idsubtraslado, detalleInsercion, detalleActualizacion);
            //            if (rpta == "OK")
            //            {


            //                if (lookUpEditBodegas.ItemIndex > -1)
            //                {
            //                    idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
            //                    mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "0"));
            //                }
            //                else
            //                {
            //                    mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0, "0"));
            //                }
            //                dtDetalleInsercion.Rows.Clear();


            //                dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

            //                dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
            //                gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
            //                gridControlSubTrasladoStandBy.ForceInitialize();
            //                gridViewSubTrasladoStandBy.BestFitColumns();

            //                dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

            //                if (dtSubtrasladoTienda.Rows.Count > 0)
            //                {
            //                    idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
            //                }
            //                else
            //                {
            //                    idsubtraslado = 0;
            //                }


            //                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
            //                txtBuscarProducto.Text = string.Empty;
            //                spinEditDisponible.Value = 0;
            //                spinEditCantidad.Value = 0;
            //            }
            //            else
            //            {
            //                XtraMessageBox.Show("Ocurrio un erro al crear el subraslado, porfavor consulte a su adminsitrador de datos " + rpta, "Error al guardar");

            //            }
            //        }
                    
            //    }
            //    //____________________________________________________CREAR NUEVO_________________________________________________________________________
            //    else
            //    {
            //        MSubTrasladoTienda traslado = new MSubTrasladoTienda();
            //        traslado.Idtienda = Configuraciones.Configuraciones.idtienda;
            //        if (id_tipo_de_sub_traslado == 1) // si es tienda = 1
            //        {
            //            traslado.Idtiendadestino = Convert.ToInt32(lookUpEditDestino.EditValue);
            //            traslado.IdBodegaDestino = 0;
            //        }
            //        if (id_tipo_de_sub_traslado == 2) // si es bodega 
            //        {
            //            traslado.Idtiendadestino = 0;
            //            traslado.IdBodegaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
            //        }
            //        traslado.IdUsuario = Configuraciones.Configuraciones.idusuario;
            //        traslado.IdTipoSubTraslado = id_tipo_de_sub_traslado;

            //        List<MSubTrasladoTiendaDetalle> detalleInsercion = new List<MSubTrasladoTiendaDetalle>();
            //        for (int i = 0; i < gridViewProductosEnBodega.DataRowCount; i++)
            //        {
            //            MSubTrasladoTiendaDetalle detalle = new MSubTrasladoTiendaDetalle();
            //            detalle.Idtienda = Configuraciones.Configuraciones.idtienda;
            //            detalle.Idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
            //            detalle.IdExistenciaDetalle = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "idexistenciadetalle"));
            //            detalle.Cantidadtrasladar = Convert.ToInt32(gridViewProductosEnBodega.GetRowCellValue(i, "cantidadautorizar"));
            //            detalle.IdtiendaDestino = Convert.ToInt32(lookUpEditDestino.EditValue);
            //            detalleInsercion.Add(detalle);

            //        }
            //        rpta = ControllerSubTrasladoTiendas.GuardarSubTraslado(traslado, detalleInsercion);
            //        if (rpta == "OK")
            //        {
            //            //alertControl1.Show(this, "Subtraslado creado correctamente", "Los productos se agregaron correctametne");

            //            if (lookUpEditBodegas.ItemIndex > -1)
            //            {
            //                idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
            //                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega,"0"));
            //            }
            //            else
            //            {
            //                mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, 0,"0"));
            //            }
            //            dtDetalleInsercion.Rows.Clear();


            //            dtSubtrasladoTienda = ControllerSubTrasladoTiendas.MostrarSubtrasladoPorTiendaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);

            //            dtDetalleSubTraslado = ControllerSubTrasladoTiendas.MostrarSubTrasladoDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditDestino.EditValue), id_tipo_de_sub_traslado);
            //            gridControlSubTrasladoStandBy.DataSource = dtDetalleSubTraslado;
            //            gridControlSubTrasladoStandBy.ForceInitialize();
            //            gridViewSubTrasladoStandBy.BestFitColumns();

            //            dtSubTraslados = ControllerSubTrasladoTiendas.MostrarSubtrasladosNoGenerados(Configuraciones.Configuraciones.idtienda);

            //            if (dtSubtrasladoTienda.Rows.Count > 0)
            //            {
            //                idsubtraslado = Convert.ToInt32(dtSubtrasladoTienda.Rows[0]["id_sub_traslado"]);
            //            }
            //            else
            //            {

            //                idsubtraslado = ControllerSubTrasladoTiendas.IdSubtraslado;
            //            }


            //            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
            //            txtBuscarProducto.Text = string.Empty;
            //            spinEditDisponible.Value = 0;
            //            spinEditCantidad.Value = 0;

            //        }
            //        else
            //        {
            //            XtraMessageBox.Show("Ocurrio un erro al crear el subraslado, porfavor consulte a su adminsitrador de datos " + rpta, "Error al guardar");

            //        }
            //    }


            //}
        }

      

       


        

 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("DESEA SALIR DEL MODULO", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                EsBotonOTecla = true;
                this.Close();
            }

        }

        private void FormMovimientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (XtraMessageBox.Show("DESEA SALIR DEL MODULO", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    EsBotonOTecla = true;
                    this.Close();
                }
            }

       
        }

        private void lookUpEditProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void lookUpEditProductos_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditProductos.ItemIndex > -1)
            {
                spinEditDisponible.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("sub_stock"));

            }
        }

        private void txtBuscarProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idexistenciadetalle", dt = ControllerTrasladoTiedas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, txtBuscarProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProductos.ItemIndex = 0; 
            }
        }

        

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    spinEditDisponible.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("sub_stock"));
                    spinEditCantidad.Focus();
                }
                catch (Exception)
                {

                    XtraMessageBox.Show(this, "DEBE INGRESAR CORRECTAMENTE EL CAMPO A BUSCAR", Configuraciones.Configuraciones.NombreDelSistema);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscarProducto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                try
                {
                    spinEditDisponible.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("sub_stock"));
                }
                catch (Exception)
                {

                    XtraMessageBox.Show(this, "DEBE INGRESAR CORRECTAMENTE EL DATO A BUSCAR", Configuraciones.Configuraciones.NombreDelSistema);
                }
            }
        }

        private void FormMovimientos_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            QuitarProducto();
        }

        private void gridViewProductosEnBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                QuitarProducto();
            }
        }
    }
}