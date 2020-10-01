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
    public partial class FormDetalleSubTrasladoTienda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int idsubtraslado;
        public string origen,destino, observaciones;

        public DataTable dtDetalleInsercion;
        public int id_destino;
        public int id_origen;
        public int tipo_salida;
        public int id_tipo_de_documento;
        public bool es_tienda;
    


        public FormDetalleSubTrasladoTienda()
        {
            InitializeComponent();
        }

        void Guardar()
        {
            bool guardar = true;
            string rpta = "";
            if (tipo_salida == 1)
            {
                if (string.IsNullOrWhiteSpace(dateEditFechaIngreso.Text))
                {
                    XtraMessageBox.Show("DEBE INGRESAR LA FECHA DE INGRESO DE FORMA CORRECTA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardar = false;
                }
            }
            if (tipo_salida == 2)
            {
                guardar = true;
            }


            if (guardar)
            {
             
                MSalidaEnc salida = new MSalidaEnc();
                salida.IdTienda = Configuraciones.Configuraciones.idtienda;
                salida.IdUsuario = Configuraciones.Configuraciones.idusuario;
                salida.IdDocumentoDeInventrio = id_tipo_de_documento;
                salida.IdSerie = 1;
                salida.IdDestino = id_tipo_de_documento == 4 ? id_destino : 0;
                salida.IdBodegaDestino = id_tipo_de_documento == 5 ? id_destino : 0;
                salida.Observaciones = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text; 
                salida.Descripcion = id_tipo_de_documento == 4 ? "TIENDA ORIGEN: " + txtOrigen.Text + ". TIENDA DESTINO: " + txtDestino.Text : "BODEGA ORIGEN: " + txtOrigen.Text + ". BODEGA DESTINO: " + txtDestino.Text;
                salida.Origen = id_tipo_de_documento == 4 ? "TIENDA ORIGEN: " + txtOrigen.Text : "BODEGA ORIGEN: " + txtOrigen.Text;
                salida.Destino = id_tipo_de_documento == 4 ? "TIENDA DESTINO: " + txtDestino.Text : "BODEGA DESTINO: " + txtDestino.Text;
                salida.FechaDeIngreso = tipo_salida == 1 ? Convert.ToDateTime(dateEditFechaIngreso.EditValue) : DateTime.Now;
                salida.Serie = "A";
                salida.SeraIngresado = true;
                salida.TipoSalida = tipo_salida;
                salida.IdSubTraslado = idsubtraslado;
                salida.NumeroEnvio = 0;


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
                    FormMovimientos traladoTiendas = FormMovimientos.GetInstancia();

                    //DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                    //    ControllerSalidas.Correlativo// correlativo del documento
                    //    , Configuraciones.Configuraciones.idtienda // id del documento
                    //    , id_tipo_de_documento// id tienda donde se reailizo la operacion
                    //    , id_origen // id origen
                    //    , id_destino);// id destino



                    traladoTiendas.ActualizarDespuesDeConfirmarTraslado();
                    this.Close();

                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al crear el traslado, profavor consulte a su administrador de datos " + rpta, "Error al crear traslado");
                }
            }
        }
      

       
   
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void FormDetalleSubTrasladoTienda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormDetalleSubTrasladoTienda_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }

        private void FormDetalleSubTrasladoTienda_Load(object sender, EventArgs e)
        {
            txtOrigen.Text = origen;
            txtDestino.Text = destino;
            textObservaciones.Focus();

            if (tipo_salida == 1) // si es 1 es tienda
            {
                dxErrorProvider1.SetError(dateEditFechaIngreso, "ESTE CAMPO ES OBLIGATORIO");
            }
            if (tipo_salida == 2) // si es 2 es bodega
            {
                layoutControlItemFechaDeIngresoADestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }


            gridControlSubTrasladoStandBy.DataSource = dtDetalleInsercion;
            gridControlSubTrasladoStandBy.ForceInitialize();
            gridViewSubTrasladoStandBy.BestFitColumns();

        }
    }
}