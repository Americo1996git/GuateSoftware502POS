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
using MODELOS502;
using ControllerSoft502;

namespace ViewGuate502.Requisicioes
{
    public partial class FormEditarRequisicion : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtDetalleInsercion = null;
        DataTable dtDetalleEliminacion = null;

        int idcapturaPedido=0;

        int count_teclado_foco = 0;
        bool cambiar_foco = false;


        private static FormEditarRequisicion _Instancia;
        public static FormEditarRequisicion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormEditarRequisicion();
            }
            return _Instancia;
        }
        public FormEditarRequisicion()
        {
            InitializeComponent();
        }

     
        //______________________________________________________________________________________________________________________
        //________________________________________________funcion para mostrar los productos en el lookpuedit______________________________________________________________________

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        public void MostrarRequisicion()
        {

            dtDetalleEliminacion = ControllerCapturaPedido.MostrarRequisicionDetalle(Configuraciones.Configuraciones.idtienda,Convert.ToInt32(spinEditNumeroRequisicion.Value));
            dtDetalleInsercion = ControllerCapturaPedido.MostrarRequisicionDetalle(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(spinEditNumeroRequisicion.Value));


            if (dtDetalleInsercion.Rows.Count == 0 && dtDetalleEliminacion.Rows.Count == 0)
            {
                XtraMessageBox.Show("No existe la requisición con el numero ingresado, por favor intente nuevamente","Editando requisición");
                gridControlListaDetalle.DataSource = dtDetalleInsercion;
                textObservaciones.Text = string.Empty;
                idcapturaPedido = 0;
                txtCodigo.Text = string.Empty;
                gridControlListaDetalle.ForceInitialize();
                gridViewListaDetalleProductos.BestFitColumns();
            }
            else
            {
                //dtDetalleInsercion = ControllerCapturaPedido.MostrarRequisicionDetalle(Configuraciones.Configuraciones.idtienda, 0);
                //dtDetalleInsercion = dtDetalleEliminacion;
                gridControlListaDetalle.DataSource = dtDetalleInsercion;
                gridControlListaDetalle.ForceInitialize();
                gridViewListaDetalleProductos.BestFitColumns();

                textObservaciones.Text = (dtDetalleInsercion.Rows[0]["Observaciones"]).ToString();
                idcapturaPedido = Convert.ToInt32(dtDetalleInsercion.Rows[0]["idcapturapedido"]);
                txtCodigo.Text = idcapturaPedido.ToString();
                gridControlListaDetalle.ForceInitialize();
                gridViewListaDetalleProductos.BestFitColumns();
            }
        }

        private void Guardar()
        {
            string respuesta = "";
            bool CrearRequisicion = true;
            //if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            //{
            //    XtraMessageBox.Show(this, "Debe escribir las observaciones", "Editando requisición");
            //    CrearRequisicion = false;
            //}
            if (dtDetalleInsercion.Rows.Count < 1)
            {
                XtraMessageBox.Show(this, "Debe indicar los productos a requerir", "Editando requisición");
                CrearRequisicion = false;
            }
            for (int i = 0; i < gridViewListaDetalleProductos.DataRowCount; i++)
            {
                if (Convert.ToInt16(gridViewListaDetalleProductos.GetRowCellValue(i, "cantidad_requerida")) == 0)
                {
                    XtraMessageBox.Show(this, "Uno o mas productos deben tener una cantidad mayor a 0", "Editando requisición");
                    CrearRequisicion = false;
                    break;
                }
            }

            if (idcapturaPedido == 0)
            {
                XtraMessageBox.Show(this, "No hay requisición para editar", "Editando requisición");
                CrearRequisicion = false;
            }

            if (CrearRequisicion)
            {
                MRequisicion requisicion = new MRequisicion();
                requisicion.Idcapturapedido = idcapturaPedido;
                requisicion.Idtienda = Configuraciones.Configuraciones.idtienda;
                requisicion.Observacion = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                requisicion.IdEstadoRequisicion = 1;

                List<MRequisicionDetalle> detalleEliminacionRequisicio = new List<MRequisicionDetalle>();
                foreach (DataRow item in dtDetalleEliminacion.Rows)
                {
                    MRequisicionDetalle requisicionProductos = new MRequisicionDetalle();
                    requisicionProductos.Idcapturapedidodetalle = Convert.ToInt32(item["idcapturapedidodetalle"]);
                    requisicionProductos.Idtienda = Configuraciones.Configuraciones.idtienda;
                    requisicionProductos.Idproducto = Convert.ToInt32(item["idproducto"]);
                    requisicionProductos.CantidadRequerida = Convert.ToInt32(item["cantidad_requerida"]);
                    requisicionProductos.Opcion = 0;
                    detalleEliminacionRequisicio.Add(requisicionProductos);
                }

                List<MRequisicionDetalle> detalleInsercionRequisicio = new List<MRequisicionDetalle>();
                for (int i = 0; i < gridViewListaDetalleProductos.DataRowCount; i++)
                {
                    MRequisicionDetalle requisicionProductos = new MRequisicionDetalle();
                    requisicionProductos.Idcapturapedidodetalle = 0;
                    requisicionProductos.Idtienda = Configuraciones.Configuraciones.idtienda;
                    requisicionProductos.Idproducto = Convert.ToInt32(gridViewListaDetalleProductos.GetRowCellValue(i, "idproducto"));
                    requisicionProductos.CantidadRequerida = Convert.ToInt32(gridViewListaDetalleProductos.GetRowCellValue(i, "cantidad_requerida"));
                    requisicionProductos.Opcion = 1;
                    detalleInsercionRequisicio.Add(requisicionProductos);
                }

                respuesta = ControllerCapturaPedido.ActualizarCapturaPedidoRequisicion(requisicion, detalleEliminacionRequisicio, detalleInsercionRequisicio);

                if (respuesta == "OK")
                {



                    FormImprimirRequisicio modalImprimir = new FormImprimirRequisicio();
                    modalImprimir.IdTienda = Configuraciones.Configuraciones.idtienda;
                    modalImprimir.IdCapturaPedido = idcapturaPedido;
                    modalImprimir.ShowDialog();

                    textObservaciones.Text = string.Empty;
                    spinEditCantidad.Value = 0;
                    dtDetalleInsercion.Clear();
                    dtDetalleEliminacion.Clear();
                    idcapturaPedido = 0;
                    spinEditNumeroRequisicion.Value = 0;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Error al crear requisición, consulte a su administrador de datos " + respuesta, "Editando requisición");
                }
            }
        }

        private void textObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditProductos.Focus();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool AgrearProducto = true;
            if (lookUpEditProductos.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe indicar el producto a requerir en el campo", "Editando requisición");
                AgrearProducto = false;
            }

            if (spinEditCantidad.Value == 0)
            {
                XtraMessageBox.Show("Debe indicar la cantidad a requerir", "Editando requisición");
                AgrearProducto = false;
            }
            if (idcapturaPedido == 0)
            {
                XtraMessageBox.Show("Debe especificar la requisición para editar", "Editando requisición");
                AgrearProducto = false;
            }

            if (AgrearProducto)
            {
                bool agregar = true;
                foreach (DataRow item in dtDetalleInsercion.Rows)
                {
                    if (Convert.ToInt64(item["idproducto"]) == Convert.ToInt64(lookUpEditProductos.EditValue))
                    {
                        agregar = false;
                        if (XtraMessageBox.Show("El producto ya existe, ¿desea aumentar la cantidad? ", "Editando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                        {
                            item["cantidad_requerida"] = Convert.ToInt32(item["cantidad_requerida"]) + Convert.ToInt32(spinEditCantidad.Value);
                            break;
                        }
                    }
                }
                if (agregar)
                {
                    DataRow dtRow = dtDetalleInsercion.NewRow();
                    dtRow["idcapturapedidodetalle"] = 0;
                    dtRow["idtienda"] = Configuraciones.Configuraciones.idtienda;
                    dtRow["idcapturapedido"] = 0;
                    dtRow["idproducto"] = Convert.ToInt64(lookUpEditProductos.EditValue);
                    dtRow["codigo"] = lookUpEditProductos.GetColumnValue("codigo").ToString();
                    dtRow["nombre"] = lookUpEditProductos.GetColumnValue("nombre").ToString();
                    dtRow["modelo"] = lookUpEditProductos.GetColumnValue("modelo").ToString();
                    dtRow["linea"] = lookUpEditProductos.GetColumnValue("linea").ToString();
                    dtRow["sub_linea"] = lookUpEditProductos.GetColumnValue("sub_linea").ToString();
                    dtRow["precioa"] = lookUpEditProductos.GetColumnValue("precioa").ToString();
                    dtRow["cantidad_requerida"] = Convert.ToInt32(spinEditCantidad.Value);
                    dtDetalleInsercion.Rows.Add(dtRow);
                    gridControlListaDetalle.ForceInitialize();
                    gridViewListaDetalleProductos.BestFitColumns();
                }



                txtBuscarProducto.Text = string.Empty;
                spinEditCantidad.EditValue = 0;
                txtBuscarProducto.Focus();
            }
        }

        private void FormEditarRequisicion_Activated(object sender, EventArgs e)
        {
            spinEditNumeroRequisicion.Focus();
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dtDetalleInsercion.Rows.Count > 0)
            {
                int rowIndex = gridViewListaDetalleProductos.FocusedRowHandle;
                DataRow row = this.dtDetalleInsercion.Rows[rowIndex];
                this.dtDetalleInsercion.Rows.Remove(row);
            }
            else
            {
                XtraMessageBox.Show("No hay productos para quitar","Editando Requisición");
            }

        }

        private void FormEditarRequisicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void lookUpEditProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (count_teclado_foco == 1)
                {
                    count_teclado_foco = 0;
                    cambiar_foco = true;
                }

                if (!cambiar_foco)
                {
                    count_teclado_foco++;
                }
                if (cambiar_foco)
                {
                    cambiar_foco = false;
                    spinEditCantidad.Focus();
                }

            }
        }

        private void spinEditCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregarProducto.Focus();
            }
        }

        private void spinEditNumeroRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MostrarRequisicion();
            }
        }

        private void btnBuscarRequisicion_Click(object sender, EventArgs e)
        {
            MostrarRequisicion();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idcapturaPedido == 0)
            {
                this.Close();
            }
            else
            {
                if (XtraMessageBox.Show("¿Desea salir? ", "Editando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (idcapturaPedido ==0)
            {
                XtraMessageBox.Show("No hay requisición para anular","Anular requisición");
            }
            else
            {
                if (XtraMessageBox.Show("¿Desea anular la requisición? ", "Anular requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    ControllerCapturaPedido.AnularRequsicion(Configuraciones.Configuraciones.idtienda, idcapturaPedido);
                    textObservaciones.Text = string.Empty;
                    spinEditCantidad.Value = 0;
                    dtDetalleInsercion.Clear();
                    dtDetalleEliminacion.Clear();
                    idcapturaPedido = 0;
                    spinEditNumeroRequisicion.Value = 0;
                }
    
            }

        }



        //______________________________________________________________________________________________________________________
        //______________________________________________________________________________________________________________________

        private void lookUpEditProductos_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {

        }

        private void FormEditarRequisicion_Load(object sender, EventArgs e)
        {
            dateEditFecha.EditValue = DateTime.Now;
            dtDetalleInsercion = ControllerCapturaPedido.MostrarRequisicionDetalle(Configuraciones.Configuraciones.idtienda, 0);
            dxErrorProvider1.SetError(lookUpEditProductos, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(spinEditCantidad, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtBuscarProducto, "ESTE CAMPO ES OBLIGATORIO");
        }

        private void FormEditarRequisicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (idcapturaPedido == 0)
                {
                    this.Close();
                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea salir? ", "Editando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        this.Close();
                    }
                }

            }
        }

        private void gridViewListaDetalleProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtDetalleInsercion.Rows.Count > 0)
                {
                    int rowIndex = gridViewListaDetalleProductos.FocusedRowHandle;
                    DataRow row = this.dtDetalleInsercion.Rows[rowIndex];
                    this.dtDetalleInsercion.Rows.Remove(row);
                }
                else
                {
                    XtraMessageBox.Show("No hay productos para quitar", "Editando Requisición");
                }
            }
        }

        private void txtBuscarProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", dt = ControllerCapturaPedido.MostrarProductos(string.IsNullOrWhiteSpace(txtBuscarProducto.Text) == true ? "&&" : txtBuscarProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProductos.ItemIndex = 0;
            }
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditCantidad.Focus();
            }
        }

        private void FormEditarRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void FormEditarRequisicion_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }
    }
}