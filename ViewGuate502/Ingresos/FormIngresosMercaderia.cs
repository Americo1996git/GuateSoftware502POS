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
    public partial class FormIngresosMercaderia : DevExpress.XtraEditors.XtraForm
    {
        bool EsBotonOtecla = false;
        public DataTable dtDetalleInsercion;
        public DataTable dtdetalleEeliminacion;
        public DataTable dtDetalle;

        public DataTable dtSeries;
        public DataTable dtSeriesCopia;

        public DataTable dtTemporalTransito;

        string proveedor,serie;
        int idordencompra,idproveedor;
        int idgenerarordencompradetalle;

        int totalproductosrecibidos=0;
        int valorActual = 0;
        int resultado = 0;
        public int correlativo = 0;
        public int id_estado_orden_de_compra;
        public bool con_productos_terminados;

        int correlativoDocumento;

        private static FormIngresosMercaderia _Instancia;
        public FormIngresosMercaderia()
        {
            InitializeComponent();
        }

        void IngresarSeries()
        {
            if (gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "aplica_serie").ToString() == "Si")
            {
                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "entrante")) > 0)
                {
                    FormIngresarSerie modalSerie = new FormIngresarSerie();
                    modalSerie.CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "entrante"));
                    modalSerie.producto = Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "descripcion_producto"));
                    modalSerie.idgenordencompradetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "idproducto"));
                    modalSerie.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Debe especificar la cantidad entrante para agregar las series respectivas", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public static FormIngresosMercaderia GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormIngresosMercaderia();
            }
            return _Instancia;
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

        public void CrearTablaTransito()
        {

            dtTemporalTransito = new DataTable();
            dtTemporalTransito.Columns.Add("id_tienda", typeof(int));
            dtTemporalTransito.Columns.Add("cantidad", typeof(int));
            dtTemporalTransito.Columns.Add("id_bodega", typeof(int));
            dtTemporalTransito.Columns.Add("id_producto", typeof(int));
            dtTemporalTransito.Columns.Add("idgenordencompradetalle", typeof(int));
            
        }
        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        void Guardar()
        {
            bool guardar = true;
            string rpta = "";
            if (spinEditNumeroOrden.Value == 0)
            {
                guardar = false;
                XtraMessageBox.Show("Debe ingresar el numero de orden de compra", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(textFacProveedor.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe ecribir el número de factura recibido", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(txtSerieFactura.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe ecribir la serie de factura recibido", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            //{
            //    guardar = false;
            //    XtraMessageBox.Show("Debe ecribir las observaciones de los productos recibidos", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}



            foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
            {
                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante")) == 0)
                {
                    guardar = false;
                    XtraMessageBox.Show("Uno o mas productos no tienen cantidad entrante, la cantidad entrante debe ser mayor a 0 para poder ingresar a bodega", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
            {
                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante")) > Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "restantes")))
                {
                    guardar = false;
                    XtraMessageBox.Show("Uno o mas productos tienen cantidad mayor a la restante", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            //foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
            //{
            //    if (Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(indice, "aplica_serie")) =="Si")
            //    {
            //        if (dtSeries.Rows.Count == 0)
            //        {
            //            guardar = false;
            //            XtraMessageBox.Show("Uno o mas productos aun no se les ingreso la serie", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            break;
            //        }
            //    }
            //}

            if (lookUpEditBodegaCarga.ItemIndex < 0)
            {
                guardar = false;
                XtraMessageBox.Show("Dege seleccionar una bodega la cual se ingresaran los productos", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (gridViewListaDetalleIngreso.SelectedRowsCount == 0)
            {
                guardar = false;
                XtraMessageBox.Show("Debe seleccionar los prodcutos que desea para poder ingresarlos a una bodega seleccionada", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (gridViewListaDetalleIngreso.RowCount == 0)
            {
                guardar = false;
                XtraMessageBox.Show("No hay productos agregados por favor ingrese el numero de orden de compra para ver los productos", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
            //{
            //    int cont = 0;
            //    if (Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(indice, "aplica_serie")) == "Si")
            //    {
            //        foreach (DataRow row in dtSeries.Rows)
            //        {

            //            if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idproducto")) == Convert.ToInt32(row["idproducto"]))
            //            {
            //                cont++;
            //            }

            //        }

            //        //if (cont > Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante")))
            //        //{
            //        //    guardar = false;
            //        //    XtraMessageBox.Show("Una o mas series no estan actualizados, debe hacer doble click en el boton de la columna serie para actualizar", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //    break;
            //        //}
            //        //if (cont < Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante")))
            //        //{
            //        //    guardar = false;
            //        //    XtraMessageBox.Show("Una o mas series no estan actualizados, debe hacer doble click en el boton de la columna serie para actualizar", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //    break;
            //        //}
            //    }
            //}


            if (guardar)
            {

                int CantidadRecibidos = 0;
                string producto = "";
                int idgenordencompradetalle = 0;
                int contFilas = 0;
                int cantidadAgregar = 0;
                DataTable dtSeriesDatos;
                correlativoDocumento = correlativoDocumento + 1;

                foreach (int i in gridViewListaDetalleIngreso.GetSelectedRows())
                {
                    CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "entrante"));
                    producto = Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(i, "producto"));
                    idgenordencompradetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(i, "idproducto"));

                    GeneradorDeSeries.asignaciones(CantidadRecibidos, contFilas, cantidadAgregar, idgenordencompradetalle);
                    dtSeriesDatos = GeneradorDeSeries.GnerarSeries(dtSeries, dtSeriesCopia);
                    GeneradorDeSeries.OrdenarSeries(dtSeries, dtSeriesCopia, dtSeriesDatos);
                }




                MIngreso ingreso = new MIngreso();
                ingreso.IdTienda = Configuraciones.Configuraciones.idtienda;
                ingreso.IdUsuario = Configuraciones.Configuraciones.idusuario;
                ingreso.IdDocumento = 1;
                ingreso.IdSerie = 1;
                ingreso.IdBodega = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
                ingreso.Observaciones = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                ingreso.DescripcionDeDocumento = "BODEGA DE INGRESO: " + lookUpEditBodegaCarga.Text + ". FACTURA PROVEEDOR: " + textFacProveedor.Text + " " + txtSerieFactura.Text + ".";
                ingreso.Origen = "TIENDA ORIGEN: " + Configuraciones.Configuraciones.tienda;
                ingreso.Destino = "BODEGA DE INGRESO: " + lookUpEditBodegaCarga.Text;
                ingreso.FacturaProveedor = textFacProveedor.Text;
                ingreso.SerieFactura = txtSerieFactura.Text;
                ingreso.Serie = "A";
                ingreso.Correlativo = correlativoDocumento;
                ingreso.IdSalidaEnc = 0;


                List<MIngresoDetalle> IngresoDetalleInsercion = new List<MIngresoDetalle>();
                foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
                {
                    DataRow row = dtTemporalTransito.NewRow();
                    MIngresoDetalle detalle = new MIngresoDetalle();
                    detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                    detalle.IdTiendaOrigen = 0;
                    detalle.IdBodegaOrigen = 0;
                    detalle.IdGenOrdenCompraDetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idgenordencompradetalle"));
                    detalle.IdSalidaDet = 0;
                    detalle.IdProducto = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idproducto"));
                    detalle.Cantidad = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante"));
                    detalle.ConSeries = false;
                    detalle.IdBodega = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
                    detalle.Restante = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "restantes"));
                    detalle.EsOrden = true;
                    IngresoDetalleInsercion.Add(detalle);

                    row["id_tienda"] = Configuraciones.Configuraciones.idtienda;
                    row["cantidad"] = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante"));
                    row["id_bodega"] = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
                    row["id_producto"] = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idproducto"));
                    row["idgenordencompradetalle"] = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idgenordencompradetalle"));
                    dtTemporalTransito.Rows.Add(row);
                }



                List<MSerieProducto> IngresoDetalleInsercionSeriesProducto = new List<MSerieProducto>();

                foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
                {
                    foreach (DataRow item in dtSeries.Rows)
                    {
                        if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idproducto")) == Convert.ToInt32(item["idproducto"]))
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
                    string res = "";
                    dtDetalleInsercion = ControllerIngreso.MostrarDetalleProductosParaIngresar(correlativo, Configuraciones.Configuraciones.idtienda);

                    if (dtDetalleInsercion.Rows.Count > 0)
                    {
                        CrearTablaSeriesProductos();
                        CrearTablaSeriesProductosCopia();
                        gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                        gridControlListaDetalleIngreso.ForceInitialize();
                        gridViewListaDetalleIngreso.BestFitColumns();
                        totalproductosrecibidos = 0;
                        textRecibidos.Text = 0.ToString();

                    }
                    else
                    {
                        if (con_productos_terminados)
                        {
                            if (id_estado_orden_de_compra == 3)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 3);
                            }
                            if (id_estado_orden_de_compra == 2)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 7);
                            }
                        }
                        else
                        {
                            if (id_estado_orden_de_compra == 3)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 3);
                            }
                            if (id_estado_orden_de_compra == 2)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 5);
                            }
                        }


                        idordencompra = 0;
                        correlativo = 0;
                        id_estado_orden_de_compra = 0;
                        textObservaciones.Text = "";
                        textProveedor.Text = "";

                        spinEditNumeroOrden.EditValue = idordencompra;
                        textFacProveedor.Text = "";
                        txtSerieFactura.Text = "";
                        totalproductosrecibidos = 0;
                        textRecibidos.Text = 0.ToString();
                        txtCorrelativo.Text = string.Empty;
                        gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                        dtDetalleInsercion = ControllerIngreso.MostrarDetalleProductosParaIngresar(0, Configuraciones.Configuraciones.idtienda);
                    }

                    DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                        correlativoDocumento
                        ,Configuraciones.Configuraciones.idtienda
                        ,1
                        ,0
                        ,0
                        ,false
                        ,0);



                    correlativoDocumento = correlativoDocumento + 1;


                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al ingresar los productos, por favor consulte a su administrador de datos " + rpta, "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





            }
        }

        void CancelarProductos()
        {
            bool terminar = true;
            string rpta = "";
            if (XtraMessageBox.Show("¿Desea cancelar el ingreso de los productos seleccionados?", "Cancelar productos", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                if (gridViewListaDetalleIngreso.SelectedRowsCount == 0)
                {
                    terminar = false;
                    XtraMessageBox.Show("Debe seleccionar los prodcutos que desea cancelar", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                if (gridViewListaDetalleIngreso.RowCount == 0)
                {
                    terminar = false;
                    XtraMessageBox.Show("No hay productos agregados por favor ingrese el numero de orden de compra para ver los productos", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (terminar)
                {
                    List<MIngresoDetalle> IngresoDetalleInsercion = new List<MIngresoDetalle>();
                    foreach (int indice in gridViewListaDetalleIngreso.GetSelectedRows())
                    {
                        DataRow row = dtTemporalTransito.NewRow();
                        MIngresoDetalle detalle = new MIngresoDetalle();
                        detalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        detalle.IdGenOrdenCompraDetalle = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idgenordencompradetalle"));
                        detalle.Cantidad = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "entrante"));
                        detalle.IdProducto = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "idproducto"));
                        detalle.Restante = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(indice, "restantes"));
                        detalle.IdOrden = idordencompra;
                        IngresoDetalleInsercion.Add(detalle);
                    }

                    rpta = ControllerIngreso.TerminarProducto(IngresoDetalleInsercion);

                    if (rpta == "OK")
                    {
                        string res = "";
                        alertControl1.Show(this, "Los productos seleccinados se cancelaron", "Ingresando productos");
                        dtDetalleInsercion = ControllerIngreso.MostrarDetalleProductosParaIngresar(correlativo, Configuraciones.Configuraciones.idtienda);

                        if (dtDetalleInsercion.Rows.Count > 0)
                        {
                            CrearTablaSeriesProductos();
                            CrearTablaSeriesProductosCopia();
                            gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                            gridControlListaDetalleIngreso.ForceInitialize();
                            gridViewListaDetalleIngreso.BestFitColumns();
                            totalproductosrecibidos = 0;
                            textRecibidos.Text = 0.ToString();

                        }
                        else
                        {
                            if (id_estado_orden_de_compra == 3)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 3);
                            }
                            if (id_estado_orden_de_compra == 2)
                            {
                                ControllerIngreso.CambiarEstadoOrdenAParcial(idordencompra, 7);
                            }

                            idordencompra = 0;
                            correlativo = 0;
                            id_estado_orden_de_compra = 0;
                            textObservaciones.Text = "";
                            textProveedor.Text = "";

                            spinEditNumeroOrden.EditValue = idordencompra;
                            textFacProveedor.Text = "";
                            txtSerieFactura.Text = "";
                            totalproductosrecibidos = 0;
                            textRecibidos.Text = 0.ToString();
                            txtCorrelativo.Text = string.Empty;
                            gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                            dtDetalleInsercion = ControllerIngreso.MostrarDetalleProductosParaIngresar(0, Configuraciones.Configuraciones.idtienda);
                        }



                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error al ingresar los productos, por favor consulte a su administrador de datos " + rpta, "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void FormIngresosMercaderia_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dtCorrelativo = new DataTable();
            dtCorrelativo = ControllerIngreso.ObtenerCorrelativoDeDocumento(1);
            correlativoDocumento = Convert.ToInt32(dtCorrelativo.Rows[0]["correlativo_actual"]);
            dt = ControllerCierre.ValidarMes(DateTime.Now.Month - 1);
            if (!Configuraciones.Configuraciones.InventarioCerrado())
            {
                layoutControlGroupTituloDocmento.Enabled = false;
            }
            else
            {
                layoutControlGroupTituloDocmento.Enabled = true;
                dateEditFecha.EditValue = DateTime.Now;
                mostrarEnComboboxLookUp(lookUpEditBodegaCarga, "Nombre", "idbodega", ControllerIngreso.MostrarBodegaCarga(Configuraciones.Configuraciones.idtienda));
                CrearTablaTransito();
                dxErrorProvider1.SetError(txtSerieFactura, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(textFacProveedor, 
                    "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(lookUpEditBodegaCarga, "ESTE CAMPO ES OBLIGATORIO");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     


        private void gridViewListaDetalleIngreso_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //int solicitado = (int)(gridViewListaDetalleIngreso.GetRowCellValue(e.RowHandle, "solicitado"));
            //int recibido = (int)(gridViewListaDetalleIngreso.GetRowCellValue(e.RowHandle, "recibido"));
            //if (recibido > solicitado)
            //{
            //    //e.ErrorText = "Recibido debe ser menor o igual a solicitado";
            //    XtraMessageBox.Show(this,"Error","Recibido debe ser menor o igual que solicitado");
            //    e.Valid = false;
            //}
            //if (recibido == 0)
            //{
            //    XtraMessageBox.Show(this, "Error", "");
            //    e.Valid = false;
            //}
        }

        private void gridViewListaDetalleIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

                valorActual = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "recibido"));
                int totalproductosrecibidos = 0;
                if (e.Column.Caption == "Entrantes")
                {

                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(e.RowHandle, "entrante")) > Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(e.RowHandle, "restantes")))
                {
                    XtraMessageBox.Show("La cantidad entrante no puede ser mayor a la cantidad restabte", "Ingresando productos");
                    gridViewListaDetalleIngreso.SetRowCellValue(e.RowHandle, "entrante", 0);
                }
                else
                {
                    totalproductosrecibidos = 0;
                    foreach (DataRow row in dtDetalleInsercion.Rows)
                    {
                        totalproductosrecibidos += Convert.ToInt32(row["entrante"]);
                    }
                }
               
                    textRecibidos.Text = totalproductosrecibidos.ToString();

                }




        }

        private void lookUpEditBodegaCarga_KeyDown(object sender, KeyEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            if (e.KeyCode == Keys.Down && !lookUpEdit.IsPopupOpen)
            {
                lookUpEditBodegaCarga.ShowPopup();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                spinEditNumeroOrden.Focus();
            }
        }

        private void textFacProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            //if (true)
            //{

            //}
        }

        private void FormIngresosMercaderia_Activated(object sender, EventArgs e)
        {
            spinEditNumeroOrden.Focus();
        }

        private void dateEditFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditBodegaCarga.Focus();
            }
        }

        private void gridViewListaDetalleIngreso_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)

        {
            //int solicitado = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "entransito"));
            //int recibido = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "recibido"));

            //if (recibido > solicitado)
            //{
            //    //e.ErrorText = "Recibido debe ser menor o igual a solicitado";
            //    XtraMessageBox.Show(this, "Recibido debe ser menor o igual que solicitado en transito", "Error al ingresar");
            //    gridViewListaDetalleIngreso.SetRowCellValue(e.RowHandle, gridViewListaDetalleIngreso.Columns["recibido"], 1);
            //    //valorActual = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "recibido"));


            //}
            //else
            //{
            //    //valorActual = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "recibido"));
            //    //int totalproductosrecibidos = 0;
            //    if (e.Column.Caption == "Recibido")
            //    {
            //        totalproductosrecibidos = 0;
            //        foreach (DataRow row in dtDetalle.Rows)
            //        {
            //            totalproductosrecibidos += Convert.ToInt32(row["recibido"]);
            //        }
            //        textRecibidos.Text = totalproductosrecibidos.ToString();

            //        ////resultado += resultado+ valorActual;





            //        ////gridViewListaDetalleIngreso.SetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, gridViewListaDetalleIngreso.Columns["recibido"], resultado);

            //        //totalproductosrecibidos = (totalproductosrecibidos + valorActual) - resultado;



            //        //textRecibidos.Text = totalproductosrecibidos.ToString();


            //        //gridViewListaDetalleIngreso.Columns["recibido"].Visible = false;
            //        //var a = gridViewListaDetalleIngreso.Columns["recibido"].SummaryItem.SummaryValue;
            //        //textRecibidos.EditValue = a;
            //    }

            //}
        }

        private void lookUpEditBodegaCarga_EditValueChanged(object sender, EventArgs e)
        {
            //if (dtDetalle.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dtDetalleInsercion.Rows.Count; i++)
            //    {
            //        dtDetalleInsercion.Rows[i]["idbodega"] = Convert.ToInt32(lookUpEditBodegaCarga.EditValue);
            //    }
            //}
        
        }

        private void textObservaciones_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarMercaderia_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void ImprimirDocumento(int correlativo, int id_tienda, int id_documento_inventario, int id_origen, int id_destino)
        {
            FormImprimirIngreso imprimir = new FormImprimirIngreso();
            imprimir.codigo = correlativo;
            imprimir.id_tienda = id_tienda;
            imprimir.id_documento_inventario = id_documento_inventario;
            imprimir.id_origen = id_origen;
            imprimir.id_destino = id_destino;
            imprimir.ShowDialog();
        }

        private void FormIngresosMercaderia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EsBotonOtecla)
            {
                e.Cancel = false;
                _Instancia = null;
            }
            else
            {
                if (XtraMessageBox.Show("Desea cancelar la orden de compra", "Generando orden", MessageBoxButtons.YesNo,MessageBoxIcon.Information) != DialogResult.No)
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

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(spinEditNumeroOrden.EditValue) == 0)
            //{
            //    XtraMessageBox.Show("No se puede agregar serie porque el producto no aplica", "Ingresando productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            mostrarDetalleProductos(Convert.ToInt32(spinEditNumeroOrden.Value));
        }

        private void btnIngresarSeries_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Convert.ToString(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "aplica_serie")) == "No")
            {
                XtraMessageBox.Show("No se puede agregar serie porque el producto no aplica", "Ingresando productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "entrante")) == 0)
                {
                    XtraMessageBox.Show("Debe especificar la cantidad entrante del producto para agregar serie", "Ingresando productos");
                    FormIngresarSerie modal = new FormIngresarSerie();
                    modal.CantidadRecibidos = Convert.ToInt32(gridViewListaDetalleIngreso.GetRowCellValue(gridViewListaDetalleIngreso.FocusedRowHandle, "entrante"));
                    modal.ShowDialog();
                }

            }

        }

        private void textFacProveedor_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerieFactura.Focus();
            }
        }

        private void txtSerieFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textObservaciones.Focus();
            }
        }

        private void textObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditBodegaCarga.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea cancelar el ingreso de productos", "Ingresando productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                EsBotonOtecla = true;
                this.Close();
            }
        }

        private void FormIngresosMercaderia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (XtraMessageBox.Show("Desea cancelar el ingreso de productos", "Ingresando productos", MessageBoxButtons.YesNo,MessageBoxIcon.Information) != DialogResult.No)
                {
                    EsBotonOtecla = true;
                    this.Close();
                }
            }
        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            IngresarSeries();
        }

        private void btnFinalizarIngreso_Click(object sender, EventArgs e)
        {
            textProveedor.Text = string.Empty;
            textObservaciones.Text = string.Empty;
            textFacProveedor.Text = string.Empty;
            txtSerieFactura.Text = string.Empty;
            spinEditNumeroOrden.Value = 0;
            dtDetalleInsercion.Rows.Clear();
            XtraMessageBox.Show("Se finalizo el ingreso de la orden de compra operada","Ingrso de productos");
        }

        private void btnTerminarParcialmente_Click(object sender, EventArgs e)
        {
            CancelarProductos();
        }

        private void gridViewListaDetalleIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IngresarSeries();
            }
        }

        private void FormIngresosMercaderia_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }

        private void FormIngresosMercaderia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                CancelarProductos();
            }
        }

        public string mostrarDetalleProductos(int idorden)
        {
            string existe = "";
            DataTable detalle = new DataTable();
            dtDetalleInsercion = ControllerIngreso.MostrarDetalleProductosParaIngresar(idorden, Configuraciones.Configuraciones.idtienda);
            if (dtDetalleInsercion.Rows.Count > 0)
            {
                existe = "1";
                CrearTablaSeriesProductos();
                CrearTablaSeriesProductosCopia();
                gridControlListaDetalleIngreso.DataSource = dtDetalleInsercion;
                gridControlListaDetalleIngreso.ForceInitialize();
                gridViewListaDetalleIngreso.BestFitColumns();
                textProveedor.Text = dtDetalleInsercion.Rows[0]["proveedor"].ToString();
                idproveedor = Convert.ToInt32(dtDetalleInsercion.Rows[0]["idproveedor"]);
                idordencompra = Convert.ToInt32(dtDetalleInsercion.Rows[0]["idgenordencompraencabezado"]);
                txtCorrelativo.Text = Convert.ToString(dtDetalleInsercion.Rows[0]["correlativo"]);
                correlativo = Convert.ToInt32(dtDetalleInsercion.Rows[0]["correlativo"]);
                id_estado_orden_de_compra = Convert.ToInt32(dtDetalleInsercion.Rows[0]["id_estado_orden_de_compra"]);
                con_productos_terminados = Convert.ToBoolean(dtDetalleInsercion.Rows[0]["ya_tiene_productos_terminados"]);
            }
            else
            {
                existe = "0";
                idordencompra = 0;

                XtraMessageBox.Show(this, "No existe la orden de compra, porfavor rectifique si ya se recibio", "Ingresando productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return existe;


        }

        private void spinEditNumeroOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mostrarDetalleProductos(Convert.ToInt32(spinEditNumeroOrden.Value))== "1")
                {
                    textFacProveedor.Focus();
                }
                else
                {
                    spinEditNumeroOrden.Focus();
                }
               

            }
        }
    }
}