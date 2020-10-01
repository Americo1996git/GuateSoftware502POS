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

namespace ViewGuate502.Ingresos
{
    public partial class FormIngresoPorTraslado : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dtDetalleInsercion;
        public DataTable dtSeries;
        public DataTable dtSeriesCopia;

        int idtiendaOrigen;
        int id_bodega_destino;
        int id_bodega_origen;
        int totalproductosrecibidos = 0;
        int idtraslado;
        int tipo_de_ingreso;
        public int correlativo;
        public string observaciones, origen;
        public string tipo_de_operacion = "ingresos";
        public int id_tipo_de_documento;
        public int id_tipo_de_Salida;
        public string titulo_de_formulario="", documento;
        

        int id_origen = 0, id_destino = 0, id_salida_enca=0;
        private static FormIngresoPorTraslado _Instancia;

        public FormIngresoPorTraslado(int tipo_ingreso)
        {
            InitializeComponent();
            tipo_de_ingreso = tipo_ingreso;
        }

        public static FormIngresoPorTraslado GetInstancia(int tipo_ingreso)
        {
            if (_Instancia == null)
            {
                _Instancia = new FormIngresoPorTraslado(tipo_ingreso);
            }
            return _Instancia;
        }

        public void IngresarProductos()
        {
            bool guardar = true;
            string rpta = "";

            if (lookUpEditBodegaCarga.ItemIndex < 0)
            {
                XtraMessageBox.Show("SELECCIONE LA BODEGA DE CARGA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }

            if (gridViewListaDetalleIngreso.DataRowCount == 0)
            {
                //XtraMessageBox.Show("No hay productos para ingresar", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }
            if (idtraslado == 0)
            {
                XtraMessageBox.Show("DEBE ESPECIFICAR EL DOCUMENTO", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardar = false;
            }
            if (guardar)
            {
                int CantidadRecibidos = 0;
                string producto = "";
                int idgenordencompradetalle = 0;
                int contFilas = 0;
                int cantidadAgregar = 0;
                DataTable dtSeriesDatos;
                if (id_tipo_de_documento == 2)
                {
                    for (int i = 0; i < gridViewListaDetalleIngreso.DataRowCount; i++)
                    {
                        CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "cantidad"));
                        producto = Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(i, "descripcion_producto"));
                        idgenordencompradetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "idproducto"));

                        GeneradorDeSeries.asignaciones(CantidadRecibidos, contFilas, cantidadAgregar, idgenordencompradetalle);
                        dtSeriesDatos = GeneradorDeSeries.GnerarSeries(dtSeries, dtSeriesCopia);
                        GeneradorDeSeries.OrdenarSeries(dtSeries, dtSeriesCopia, dtSeriesDatos);
                    }
                }



                MIngreso ingreso = new MIngreso();
                ingreso.IdTienda = Configuraciones.Configuraciones.idtienda;
                ingreso.IdUsuario = Configuraciones.Configuraciones.idusuario;
                ingreso.IdDocumento = id_tipo_de_documento;
                ingreso.IdSerie = 1;
                ingreso.IdBodega = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
                ingreso.Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text) == true ? "" : txtObservaciones.Text;
                ingreso.DescripcionDeDocumento = txtOrigen.Text + ". BODEGA DE INGRESO: " + lookUpEditBodegaCarga.Text;
                ingreso.Origen = "TIENDA ORIGEN: "+Configuraciones.Configuraciones.tienda;
                ingreso.Destino = "BODEGA DE INGRESO: " + lookUpEditBodegaCarga.Text; 
                ingreso.FacturaProveedor = "";
                ingreso.SerieFactura = "";
                ingreso.Serie = "A";
                ingreso.Correlativo = correlativo;
                ingreso.IdSalidaEnc = id_salida_enca;


                List<MIngresoDetalle> IngresoDetalleInsercion = new List<MIngresoDetalle>();
                for (int i = 0; i < gridViewListaDetalleIngreso.DataRowCount; i++)
                {
                    MIngresoDetalle detalle = new MIngresoDetalle();
                    detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                    detalle.IdTiendaOrigen = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "id_tienda"));
                    detalle.IdBodegaOrigen = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "id_bodega"));
                    detalle.IdGenOrdenCompraDetalle = 0;
                    detalle.IdSalidaDet = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "id_salida_detalle"));
                    detalle.IdProducto = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "idproducto"));
                    detalle.Cantidad = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "cantidad"));
                    detalle.ConSeries = false;
                    detalle.IdBodega = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
                    detalle.Restante = 0;
                    detalle.EsOrden = false;
                    IngresoDetalleInsercion.Add(detalle);
                }



                List<MSerieProducto> IngresoDetalleInsercionSeriesProducto = new List<MSerieProducto>();

                for (int i = 0; i < gridViewListaDetalleIngreso.DataRowCount; i++)
                {
                    foreach (DataRow item in dtSeries.Rows)
                    {
                        if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "idproducto")) == Convert.ToInt32(item["idproducto"]))
                        {
                            MSerieProducto serie = new MSerieProducto();
                            serie.Idtienda = Configuraciones.Configuraciones.idtienda;
                            serie.IdordenDeCompraDetalle = Convert.ToInt32(item["idproducto"]);
                            serie.Numero = Convert.ToInt32(item["numero"]);
                            serie.Serie = Convert.ToString(item["serie"]);
                            IngresoDetalleInsercionSeriesProducto.Add(serie);
                        }
                    }
                }


                rpta = ControllerIngreso.IngresarProductos(ingreso, IngresoDetalleInsercion, IngresoDetalleInsercionSeriesProducto);

                if (rpta == "OK")
                {

                    //alertControl1.Show(this, "Ingreso realizado correctamnte", "Los productos se ingresaron correctamente");


                    dtDetalleInsercion =
                 ControllerDocumentosInventario.MostrarDocumentoOperado(
                     Convert.ToInt32(spinEditNumeroDocumento.EditValue)
                     , Convert.ToInt32(lookUpEditTiendas.EditValue)
                     , id_tipo_de_Salida
                     , id_origen
                     , id_destino
                     ,false
                     ,1);

                    if (dtDetalleInsercion.Rows.Count > 0)
                    {
                        gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                        gridControlListaDetalleIngreso.ForceInitialize();
                        gridViewListaDetalleIngreso.BestFitColumns();

                        foreach (DataRow row in dtDetalleInsercion.Rows)
                        {
                            totalproductosrecibidos += Convert.ToInt32(row["cantidad"]);
                        }
                        textRecibidos.Text = totalproductosrecibidos.ToString();
                    }
                    else
                    {
                        gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                        txtObservaciones.Text = string.Empty;
                        txtOrigen.Text = string.Empty;
                        spinEditNumeroDocumento.EditValue = 0;
                        idtraslado = 0;
                        //correlativo = 0;
                        txtCorrelativo.Text = string.Empty;
                        totalproductosrecibidos = 0;
                    }
                    if (id_tipo_de_documento == 2)
                    {
                        ControllerNotificacion.Actualizar(Configuraciones.Configuraciones.idtienda,correlativo);

                        DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                                         correlativo// correlativo del documento
                                         , Configuraciones.Configuraciones.idtienda // id del documento
                                         , id_tipo_de_documento// id tienda donde se reailizo la operacion
                                         , Convert.ToInt32(lookUpEditTiendas.EditValue) // id origen
                                         , Configuraciones.Configuraciones.idtienda
                                         ,true
                                         ,0);
                    }
                    if (id_tipo_de_documento == 3)
                    {
                        DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                                         correlativo// correlativo del documento
                                         , Configuraciones.Configuraciones.idtienda // id del documento
                                         , id_tipo_de_documento// id tienda donde se reailizo la operacion
                                         , Configuraciones.Configuraciones.idtienda // id origen
                                         , 0
                                         ,true
                                         ,0);
                    }
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al ingresar los productos, por favor consulte a su administrador de datos " + rpta, "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void AgregarSeries()
        {
            if (gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "aplica_serie").ToString() == "Si")
            {


                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "cantidad")) > 0)
                {
                    FormIngresarSerie modalSerie = new FormIngresarSerie();
                    modalSerie.CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "cantidad"));
                    modalSerie.producto = Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "producto"));
                    modalSerie.idgenordencompradetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "idproducto"));
                    modalSerie.tipo_ingreso = tipo_de_ingreso;
                    modalSerie.id_ingreso_detalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "id_movimiento_det"));
                    modalSerie.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Debe especificar la cantidad entrante para agregar las series respectivas", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public void CrearTablaSeriesProductos()
        {

            dtSeries = new DataTable();
            dtSeries.Columns.Add("idproducto", typeof(int));
            dtSeries.Columns.Add("numero", typeof(int));
            dtSeries.Columns.Add("serie", typeof(string));
        }

        public void CrearTablaSeriesProductosCopia()
        {

            dtSeriesCopia = new DataTable();
            dtSeriesCopia.Columns.Add("idproducto", typeof(int));
            dtSeriesCopia.Columns.Add("numero", typeof(int));
            dtSeriesCopia.Columns.Add("serie", typeof(string));
        }
        //________________________________________________________________________________
        //________________________________________________________________________________
        //__________________________Funciones para mostrar linea, sublinea y marcaa en un control combobox lookupedit________________________________________
        //---1 recibe el control lookupedit, nombre d el campo a mostrar, y el id a evaluar
        //cunado el usaruio seleccione en el combobox, y un datable que trae los datos de la DB 
        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        void Guardar()
        {
            if (tipo_de_operacion == "ingresos")
            {
                IngresarProductos();
            }

        }


        private void FormIngresoPorTraslado_Load(object sender, EventArgs e)
        {
            spinEditNumeroDocumento.Focus();
            this.Text = titulo_de_formulario;                                                                     
            gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;

            if (!Configuraciones.Configuraciones.InventarioCerrado())
            {
                layoutControlGroup1.Enabled = false;
                layoutControlGroup3.Enabled = false;


            }
            else
            {
                if (tipo_de_operacion == "correcciones")//si es correciones es solo para acutalizar las series de los productos
                {
                    this.Text = "ACTUALIZACIÓN DE SERIES";
                    lyNumDoc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lyTiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    txtOrigen.Text = origen;
                    txtCorrelativo.Text = correlativo.ToString();
                    lyObservaciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    txtDocumento.Text = documento;
                    splitterItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                if (tipo_de_operacion == "ingresos")//si es ingresos es para realizar un ingreso ya sea por salidas a tiendas o bodegs.
                {
                    this.Text = "INGRESO POR TRASLADOS";
                    lyDocumento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    mostrarEnComboboxLookUp(lookUpEditBodegaCarga, "Nombre", "idbodega", ControllerIngresoTrasladoTienda.MostrarBodegaCarga(Configuraciones.Configuraciones.idtienda));
                    dxErrorProvider1.SetError(lookUpEditBodegaCarga, "ESTE CAMPO ES OBLIGATORIO");
                    lookUpEditTiendas.Properties.DataSource = ControllerTrasladoTiedas.MostrarTiendasDeDestino(Configuraciones.Configuraciones.idtienda);
                    lookUpEditTiendas.Properties.ValueMember = "idtienda";
                    lookUpEditTiendas.Properties.DisplayMember = "nombre";

                    if (tipo_de_ingreso == 2)
                    {
                        lyDestino.Text = "Bodega destino";
                        lyOrigen.Text = "Bodega Origen";
                        lyDestino.Enabled = false;
                        lyTiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        gridViewListaDetalleIngreso.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                        dxErrorProvider1.SetError(lookUpEditBodegaCarga, "");
                    }
                }

            }

        }

        private void btnIngresarMercaderia_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void gridViewListaDetalleIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridViewListaDetalleIngreso_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void spinEditNumeroDocumento_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FormIngresoPorTraslado_KeyDown(object sender, KeyEventArgs e)
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

        private void spinEditNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void gridViewListaDetalleIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarSeries();
            }
        }

        private void FormIngresoPorTraslado_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }

        private void btnAgregarSeries_Click(object sender, EventArgs e)
        {
            if (gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "aplica_serie").ToString() == "Si")
            {


                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "cantidad")) > 0)
                {
                    FormIngresarSerie modalSerie = new FormIngresarSerie();
                    modalSerie.CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "cantidad"));
                    modalSerie.producto = Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "producto"));
                    modalSerie.idgenordencompradetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "idproducto"));
                    modalSerie.tipo_ingreso = tipo_de_ingreso;
                    modalSerie.id_ingreso_detalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "id_movimiento_det"));
                    modalSerie.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Debe especificar la cantidad entrante para agregar las series respectivas", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void FormIngresoPorTraslado_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          
        }

        private void spinEditNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int id_tienda = 0;

                if (id_tipo_de_Salida == 4)
                {
                    id_origen = Convert.ToInt32(lookUpEditTiendas.EditValue);
                    id_destino = Configuraciones.Configuraciones.idtienda;
                    id_tienda = Convert.ToInt32(lookUpEditTiendas.EditValue);
                }
                if (id_tipo_de_Salida == 5)
                {
                    id_origen = Configuraciones.Configuraciones.idtienda;
                    id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
                    id_tienda = Configuraciones.Configuraciones.idtienda;
                }

                dtDetalleInsercion = 
                    ControllerDocumentosInventario.MostrarDocumentoOperado(
                        Convert.ToInt32(spinEditNumeroDocumento.EditValue)
                        ,id_tienda
                        ,id_tipo_de_Salida
                        ,id_origen
                        ,id_destino
                        ,false //false significa que muestre los documentos de envio que no estan ingresado de lo contrario no los muestra 
                        ,1);

                if (dtDetalleInsercion.Rows.Count == 0)
                {
                    XtraMessageBox.Show("NO EXISTE EL DOCUMENTO", "COMERCIALES AGLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CrearTablaSeriesProductos();
                    CrearTablaSeriesProductosCopia();
                    gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                    gridControlListaDetalleIngreso.ForceInitialize();
                    gridViewListaDetalleIngreso.BestFitColumns();

                    //textTiendaOrigen.Text = dtDetalleInsercion.Rows[0]["tienda_origen"].ToString();
                    idtraslado = Convert.ToInt32(dtDetalleInsercion.Rows[0]["id_movimiento_enc"]);
                    idtiendaOrigen = Convert.ToInt32(dtDetalleInsercion.Rows[0]["id_tienda_origen"]);
                    txtCorrelativo.Text = Convert.ToString(dtDetalleInsercion.Rows[0]["correlativo"]);
                    correlativo = Convert.ToInt32(dtDetalleInsercion.Rows[0]["correlativo"]);
                    txtOrigen.Text = Convert.ToString(dtDetalleInsercion.Rows[0]["origen_documento"]);
                    id_salida_enca = Convert.ToInt32(dtDetalleInsercion.Rows[0]["id_salida_enc"]);

                    foreach (DataRow row in dtDetalleInsercion.Rows)
                    {
                        totalproductosrecibidos += Convert.ToInt32(row["cantidad"]);
                    }
                    textRecibidos.Text = totalproductosrecibidos.ToString();
                    if (id_tipo_de_documento == 3)
                    {
                        id_bodega_destino = Convert.ToInt32(dtDetalleInsercion.Rows[0]["id_destino"]);
                        lookUpEditBodegaCarga.EditValue = id_bodega_destino;
                    }
                }



         
            }
          

        }
    }
}