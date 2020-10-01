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

namespace ViewGuate502.Verificaciones
{
    public partial class FormVerifiacioesOC : DevExpress.XtraEditors.XtraForm
    {
        int idorden, id_estado_orden_de_compra;
        int CountChecked = 0;
        bool EsBotonOTecla;
        public FormVerifiacioesOC()
        {
            InitializeComponent();
        }
        void Save()
        {
            bool recibido = true;
            string rpta = "";
            int count_autorizado = 0;
            int count_filas = 0;
            count_filas = gridViewDetalleOrdenCompra.DataRowCount;

            if (gridViewDetalleOrdenCompra.DataRowCount == 0)
            {
                XtraMessageBox.Show("No hay detalle de productos agregados para verificar orden", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recibido = false;
            }

            for (int i = 0; i < gridViewDetalleOrdenCompra.DataRowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDetalleOrdenCompra.GetRowCellValue(i, "autorizado")))
                {
                    CountChecked++;
                }
            }

            for (int i = 0; i < gridViewDetalleOrdenCompra.DataRowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDetalleOrdenCompra.GetRowCellValue(i, "autorizado")))
                {
                    if (Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(i, "nuevo_precio")) == 0)
                    {
                        XtraMessageBox.Show("El precio de venta debe ser mayor a 0", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        recibido = false;
                        break;
                    }
                }
            }

            if (CountChecked == 0)
            {
                XtraMessageBox.Show("Debe seleccionar uno o mas productos para autorizar su ingreso", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recibido = false;
            }



            if (recibido)
            {
                int RowCount = 0;
                CountChecked = 0;

                MOrdenCompra orden = new MOrdenCompra();
                orden.IdTienda = Configuraciones.Configuraciones.idtienda;
                orden.IdGenorDenCompraEncabezado = idorden;


                RowCount = gridViewDetalleOrdenCompra.DataRowCount;
                for (int i = 0; i < RowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewDetalleOrdenCompra.GetRowCellValue(i, "autorizado")))
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
                    orden.Id_estado_orden_de_compra = id_estado_orden_de_compra;
                }

                List<MOrdenCompraDetalle> detalleInsercionPreciosCostos = new List<MOrdenCompraDetalle>();
                for (int i = 0; i < gridViewDetalleOrdenCompra.DataRowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewDetalleOrdenCompra.GetRowCellValue(i, "autorizado")))
                    {
                        MOrdenCompraDetalle detalleOrden = new MOrdenCompraDetalle();
                        detalleOrden.Idproducto = Convert.ToInt32(gridViewDetalleOrdenCompra.GetRowCellValue(i, "idproducto"));
                        detalleOrden.NuevoCosto = Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(i, "nuevo_costo"));
                        detalleOrden.NuevoPrecio = Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(i, "nuevo_precio"));
                        detalleOrden.Recibidos = Convert.ToInt32(gridViewDetalleOrdenCompra.GetRowCellValue(i, "cantidad"));
                        detalleOrden.IdGenorDenCompraDetalle = Convert.ToInt32(gridViewDetalleOrdenCompra.GetRowCellValue(i, "idgenordencompradetalle"));
                        detalleOrden.IdTienda = Configuraciones.Configuraciones.idtienda;
                        detalleInsercionPreciosCostos.Add(detalleOrden);
                    }

                }

                List<MHistorialPreciosCostos> HistorialInsert = new List<MHistorialPreciosCostos>();
                for (int i = 0; i < gridViewDetalleOrdenCompra.DataRowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewDetalleOrdenCompra.GetRowCellValue(i, "autorizado")))
                    {
                        MHistorialPreciosCostos Historial = new MHistorialPreciosCostos();
                        Historial.IdTienda = Configuraciones.Configuraciones.idtienda;
                        Historial.IdUsuarioCreacion = Configuraciones.Configuraciones.idusuario;
                        Historial.IdOrigenMontoPrecios = 3;
                        Historial.IdSubOrden = Convert.ToInt32(gridViewDetalleOrdenCompra.GetRowCellValue(i, "idsuborden"));
                        Historial.IdProducto = Convert.ToInt32(gridViewDetalleOrdenCompra.GetRowCellValue(i, "idproducto"));
                        Historial.Costo = Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(i, "nuevo_costo"));
                        Historial.PrecioVenta = Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(i, "nuevo_precio"));
                        HistorialInsert.Add(Historial);
                    }

                }



                rpta = ControllerVerificacion.ActulizarDetalleOCPreciosCostos(orden, detalleInsercionPreciosCostos, HistorialInsert);

                if (rpta == "OK")
                {
                    XtraMessageBox.Show("El detalle de la orden se actualizo de forma correcta", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt = new DataTable();
                    dt = ControllerVerificacion.MostrarDetalleOrdenCompra(idorden, Configuraciones.Configuraciones.idtienda);
                    if (dt.Rows.Count > 0)
                    {
                        txtProveedor.Text = dt.Rows[0]["proveedor"].ToString();
                        txtObservaciones.Text = dt.Rows[0]["observaciones"].ToString();
                        txtQuienRecibe.Text = dt.Rows[0]["quien_recibe_orden"].ToString();
                        txtCodigo.Text = dt.Rows[0]["correlativo"].ToString();
                        txtEstado.Text = dt.Rows[0]["estado_orden"].ToString();
                        idorden = Convert.ToInt32(dt.Rows[0]["idgenordencompraencabezado"]);

                        gridControlDetalleOrdenCompra.DataSource = dt;
                        gridControlDetalleOrdenCompra.ForceInitialize();
                        gridViewDetalleOrdenCompra.BestFitColumns();

                        if (txtEstado.Text.Equals("Completo"))
                        {
                            layoutControlItemBtnRecibido.Enabled = false;
                        }
                        else
                        {
                            layoutControlItemBtnRecibido.Enabled = true;
                        }

                    }
                    else
                    {
                        txtProveedor.Text = string.Empty;
                        txtObservaciones.Text = string.Empty;
                        txtQuienRecibe.Text = string.Empty;
                        txtCodigo.Text = string.Empty;
                        txtEstado.Text = string.Empty;
                        idorden = 0;

                        gridControlDetalleOrdenCompra.DataSource = dt;
                        gridControlDetalleOrdenCompra.ForceInitialize();
                        gridViewDetalleOrdenCompra.BestFitColumns();
                    }

                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al actualizar el detalle, por favor consulte a su administrador de datos " + rpta, "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void MostrarOrdenDeCompra()
        {
            DataTable dt = new DataTable();
            dt = ControllerVerificacion.MostrarDetalleOrdenCompra(Convert.ToInt32(spinEditNumeroOrden.EditValue),Configuraciones.Configuraciones.idtienda);
            if (dt.Rows.Count > 0)
            {
                txtProveedor.Text = dt.Rows[0]["proveedor"].ToString();
                txtObservaciones.Text = dt.Rows[0]["observaciones"].ToString();
                txtQuienRecibe.Text = dt.Rows[0]["quien_recibe_orden"].ToString();
                txtCodigo.Text = dt.Rows[0]["correlativo"].ToString();
                txtEstado.Text = dt.Rows[0]["estado_orden"].ToString();
                idorden = Convert.ToInt32(dt.Rows[0]["idgenordencompraencabezado"]);
                id_estado_orden_de_compra = Convert.ToInt32(dt.Rows[0]["id_estado_orden_de_compra"]);

                gridControlDetalleOrdenCompra.DataSource = dt;
                gridControlDetalleOrdenCompra.ForceInitialize();
                gridViewDetalleOrdenCompra.BestFitColumns();

                gridViewDetalleOrdenCompra.FocusedRowHandle = 0;
                gridViewDetalleOrdenCompra.FocusedColumn = gridViewDetalleOrdenCompra.VisibleColumns[8];
                gridViewDetalleOrdenCompra.ShowEditor();
                if (id_estado_orden_de_compra == 2)
                {
                    layoutControlItemBtnRecibido.Enabled = false;
                }
                else
                {
                    layoutControlItemBtnRecibido.Enabled = true;
                }

            }
            else
            {
                XtraMessageBox.Show("No existe la orden de compra            ","Verificando orden de compra",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void FormVerifiacioesOC_Load(object sender, EventArgs e)
        {
            //gridControlBuscar.DataSource = ControllerGenerarOrdenCompra.VerificacionesOrdenDeCompra(Configuraciones.Configuraciones.idtienda);
            //gridControlBuscar.ForceInitialize();
            //gridViewBuscar.BestFitColumns();
        }

        private void spinEditNumeroOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(spinEditNumeroOrden.EditValue.ToString()))
                {
                    XtraMessageBox.Show("Debe escribir de forma correcta el número de orden de compra", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarOrdenDeCompra();
                }
            }
        }

        private void gridControlDetalleOrdenCompra_Click(object sender, EventArgs e)
        {

        }

        private void gridViewDetalleOrdenCompra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "nuevo_precio")
            {

                if (Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(e.RowHandle, "nuevo_precio")) < Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(e.RowHandle, "ultimocosto")))
                {
                    XtraMessageBox.Show("El precio de venta debe ser mayor al costo", "Verificando orden de compra",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //gridViewDetalleOrdenCompra.SetRowCellValue(e.RowHandle, "nuevo_precio", Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(e.RowHandle, "ultimocosto"))+1);
                }
                else
                {
                    gridViewDetalleOrdenCompra.SetRowCellValue(e.RowHandle, "precioa", Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(e.RowHandle, "nuevo_precio")));
                }
            }
            if (e.Column.FieldName=="nuevo_costo")
            {
                gridViewDetalleOrdenCompra.SetRowCellValue(e.RowHandle, "ultimocosto", Convert.ToDecimal(gridViewDetalleOrdenCompra.GetRowCellValue(e.RowHandle, "nuevo_costo")));
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea salir de la verificación de orden", "Verificando orden de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                EsBotonOTecla = true;
                this.Close();
            }
        }

        private void FormVerifiacioesOC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EsBotonOTecla)
            {
                e.Cancel = false;
            }
            else
            {
                if (XtraMessageBox.Show("Desea salir de la verificación de orden", "Verificando orden de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    e.Cancel = false;
          
                }
                else
                {
                    e.Cancel = true;

                }


            }
        }

        private void FormVerifiacioesOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (XtraMessageBox.Show("Desea salir de la verificación de orden", "Verificando orden de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
                {
                    EsBotonOTecla = true;
                    this.Close();
                }
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                Save();
            }
        }

        private void gridViewDetalleOrdenCompra_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(spinEditNumeroOrden.EditValue.ToString()))
            {
                XtraMessageBox.Show("Debe escribir de forma correcta el número de orden de compra", "Verificando orden de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MostrarOrdenDeCompra();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}