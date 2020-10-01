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
    public partial class FormModalMostrarDetalleOrdenCompra : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool EsBotonOTecla = false;
        public DataTable dtDetalleSubOrdenInsercion;
        public int idsuborden;
        public string proveedor;


        private static FormModalMostrarDetalleOrdenCompra _Instancia;
        public static FormModalMostrarDetalleOrdenCompra GetInstancia()
        {
            if (_Instancia==null)
            {
                _Instancia = new FormModalMostrarDetalleOrdenCompra();
            }
            return _Instancia;
        }

    

     

        public FormModalMostrarDetalleOrdenCompra()
        {
            InitializeComponent();
        }

        void Guardar()
        {
            string rpta = "";
            bool guardar = true;
            if (string.IsNullOrWhiteSpace(textDestino.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe escribir el destino", "Generando orden de compra");
            }
            //if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            //{
            //    guardar = false;
            //    XtraMessageBox.Show("Debe escribir la observación","Generando orden de compra");
            //}
            if (string.IsNullOrWhiteSpace(textContactoRecibe.Text))
            {
                guardar = false;
                XtraMessageBox.Show("Debe escribir el contacto que recibe", "Generando orden de compra");
            }
            if (gridViewDetalleSubOrden.DataRowCount == 0)
            {
                guardar = false;
                XtraMessageBox.Show("La orden no se puede generar", "Generando orden de compra");
            }
            if (dateEditIngreosBodega.EditValue == null)
            {
                guardar = false;
                XtraMessageBox.Show("Debe especificar la fecha de ingreso", "Generando orden de compra");
            }


            if (guardar)
            {
                int RowCount = 0;
                int CountChecked = 0;
                MOrdenCompra orden = new MOrdenCompra();
                orden.IdTienda = Configuraciones.Configuraciones.idtienda;
                orden.IdUsuario = Configuraciones.Configuraciones.idusuario;
                orden.Serie = "A";
                orden.Destino = textDestino.Text;
                orden.Observaciones = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                orden.QuienRecibe = textContactoRecibe.Text;
                orden.FechaIngresoBodega = Convert.ToDateTime(dateEditIngreosBodega.EditValue);
                orden.Idsuborden = idsuborden;




                RowCount = gridViewDetalleSubOrden.DataRowCount;
                for (int i = 0; i < RowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(i, "verificado")))
                    {
                        CountChecked++;
                    }
                }

                if (CountChecked == RowCount)
                {
                    orden.Id_estado_orden_de_compra = 2;
                }
                if (CountChecked != RowCount)
                {
                    orden.Id_estado_orden_de_compra = 3;
                }
                if (CountChecked == 0)
                {
                    orden.Id_estado_orden_de_compra = 1;
                }


                List<MOrdenCompraDetalle> ordenDetalleInsercion = new List<MOrdenCompraDetalle>();
                for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
                {
                    MOrdenCompraDetalle ordenDet = new MOrdenCompraDetalle();
                    ordenDet.IdTienda = Configuraciones.Configuraciones.idtienda;
                    ordenDet.IdSubOrdenDetalle = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idsubordendetalle"));
                    ordenDet.Idproducto = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto"));
                    ordenDet.Cantidad = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "cantidad_autorizada"));
                    ordenDet.Verificado = Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(i, "verificado"));
                    ordenDetalleInsercion.Add(ordenDet);
                }

                List<MHistorialPreciosCostos> HistorialInsert = new List<MHistorialPreciosCostos>();
                for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewDetalleSubOrden.GetRowCellValue(i, "verificado")))
                    {
                        MHistorialPreciosCostos Historial = new MHistorialPreciosCostos();
                        Historial.IdTienda = Configuraciones.Configuraciones.idtienda;
                        Historial.IdUsuarioCreacion = Configuraciones.Configuraciones.idusuario;
                        Historial.IdOrigenMontoPrecios = 1;
                        Historial.IdSubOrden = idsuborden;
                        Historial.IdProducto = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto"));
                        Historial.Costo = Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(i, "ultimo_costo"));
                        Historial.PrecioVenta = Convert.ToDecimal(gridViewDetalleSubOrden.GetRowCellValue(i, "precioa"));
                        HistorialInsert.Add(Historial);
                    }

                }

                rpta = ControllerGenerarOrdenCompra.GenerarOrdenDeCompra(orden, ordenDetalleInsercion, HistorialInsert);

                if (rpta == "OK")
                {



                    //DOUCUMENTO GENERAL
                    MSalidaEnc salida = new MSalidaEnc();
                    salida.IdTienda = Configuraciones.Configuraciones.idtienda;
                    salida.IdUsuario = Configuraciones.Configuraciones.idusuario;
                    salida.IdDocumentoDeInventrio = 1007;
                    salida.IdSerie = 1;
                    salida.IdDestino = 0;
                    salida.IdBodegaDestino = 0;
                    salida.Observaciones = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                    salida.Descripcion = "PROOVEEDOR DESTINO: " + textProveedor.Text;
                    salida.Origen = "TIENDA ORIGEN: " + Configuraciones.Configuraciones.tienda;
                    salida.Destino = "PROVEEDOR DESTINO:" + textProveedor.Text;
                    salida.FechaDeIngreso = Convert.ToDateTime(dateEditIngreosBodega.EditValue);
                    salida.Serie = "A";
                    salida.SeraIngresado = true;
                    salida.TipoSalida = 3;
                    salida.IdSubTraslado = 0;
                    salida.NumeroEnvio = 0;
                    salida.Ingresado = false;


                    List<MSalidaDetalle> DetalleInserccion = new List<MSalidaDetalle>();
                    for (int i = 0; i < gridViewDetalleSubOrden.DataRowCount; i++)
                    {
                        MSalidaDetalle SalidaDetalle = new MSalidaDetalle();
                        SalidaDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        SalidaDetalle.IdSubTrasladoDetalle = 0;
                        SalidaDetalle.IdProducto = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "idproducto"));
                        SalidaDetalle.Cantidad = Convert.ToInt32(gridViewDetalleSubOrden.GetRowCellValue(i, "cantidad_autorizada"));
                        SalidaDetalle.IdExistenciaDetalle = 0;
                        SalidaDetalle.IdBodega = 0;
                        SalidaDetalle.EsVenta = 1; //es ventoa u otra salida
                        DetalleInserccion.Add(SalidaDetalle);

                    }
                    List<MSerieProducto> IngresoDetalleInsercionSeriesProducto = new List<MSerieProducto>();

                    rpta = ControllerSalidas.Salidas(salida, DetalleInserccion, IngresoDetalleInsercionSeriesProducto);

                    if (rpta == "OK")
                    {
                        FormImprimirOrdenCompra modalImprimir = new FormImprimirOrdenCompra();
                        modalImprimir.IdTienda = Configuraciones.Configuraciones.idtienda;
                        modalImprimir.IdOrden = ControllerGenerarOrdenCompra.IdOrdenDeCompra;
                        modalImprimir.ShowDialog();
                        textProveedor.Text = string.Empty;
                        textDestino.Text = string.Empty;
                        textObservaciones.Text = string.Empty;
                        textContactoRecibe.Text = string.Empty;
                        idsuborden = 0;
                        dtDetalleSubOrdenInsercion.Rows.Clear();

                        EsBotonOTecla = true;

                        this.Close();


                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error al crear el traslado, profavor consulte a su administrador de datos " + rpta, "Error al crear traslado");
                    }



                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al generar la orden, porfavor consulte a su administrador de datos: " + rpta, "Generando orden de compra");
                }

            }
        }
    

        private void FormModalMostrarDetalleOrdenCompra_Load(object sender, EventArgs e)
        {
            dateEditFecha.EditValue = DateTime.Now;
            textProveedor.Text = proveedor;
            gridControlDetalleSuborden.DataSource = dtDetalleSubOrdenInsercion;
            gridControlDetalleSuborden.ForceInitialize();
            gridViewDetalleSubOrden.BestFitColumns();

            dxErrorProvider1.SetError(textDestino,"ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(textContactoRecibe, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(dateEditIngreosBodega, "ESTE CAMPO ES OBLIGATORIO");

        }

       

        private void FormModalMostrarDetalleOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EsBotonOTecla)
            {
                e.Cancel = false;
            }
            else
            {
                if (XtraMessageBox.Show("Desea cancelar la orden de compra", "Generando orden", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
     

            }

        }

        private void FormModalMostrarDetalleOrdenCompra_Activated(object sender, EventArgs e)
        {
            textDestino.Focus();
        }

        private void textDestino_KeyDown(object sender, KeyEventArgs e)
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
                textContactoRecibe.Focus();
            }
        }

        private void textContactoRecibe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateEditIngreosBodega.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Desea cancelar la orden de compra", "Generando orden", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                EsBotonOTecla = true;
                this.Close();
            }
        }

        private void textProveedor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void FormModalMostrarDetalleOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (XtraMessageBox.Show("Desea cancelar la orden de compra", "Generando orden", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    EsBotonOTecla = true;
                    this.Close();
                }
            }
        }

        private void dateEditIngreosBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerar.Focus();
            }
        }

        private void FormModalMostrarDetalleOrdenCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }
    }
 }
