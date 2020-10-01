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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Data.Filtering;
using MODELOS502;
using ControllerSoft502;

namespace ViewGuate502.Requisicioes
{
    public partial class FormRequisicion : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtDetalleInsercion;


        int count_teclado_foco = 0;
        bool cambiar_foco = false;

        private static FormRequisicion _Instancia;
        public static FormRequisicion GetInstancia()
        {
            if (_Instancia==null)
            {
                _Instancia = new FormRequisicion();
            }
            return _Instancia;
        }

        public void Creartabla()
        {
            dtDetalleInsercion = new DataTable();
            dtDetalleInsercion.Columns.Add("id_captura_pedido_detalle", typeof(int));
            dtDetalleInsercion.Columns.Add("idtienda",typeof(int));
            dtDetalleInsercion.Columns.Add("idcapturapedido", typeof(int));
            dtDetalleInsercion.Columns.Add("idproducto", typeof(int));
            dtDetalleInsercion.Columns.Add("codigo", typeof(string));
            dtDetalleInsercion.Columns.Add("nombre", typeof(string));
            dtDetalleInsercion.Columns.Add("modelo", typeof(string));
            dtDetalleInsercion.Columns.Add("linea", typeof(string));
            dtDetalleInsercion.Columns.Add("sub_linea", typeof(string));
            dtDetalleInsercion.Columns.Add("precioa", typeof(string));
            dtDetalleInsercion.Columns.Add("cantidad_requerida", typeof(int));
            gridControlListaDetalle.DataSource = dtDetalleInsercion;
        }

        public void Guardar()
        {
            string respuesta = "";
            bool CrearRequisicion = true;
            //if (string.IsNullOrWhiteSpace(textObservaciones.Text))
            //{
            //    XtraMessageBox.Show(this, "Debe escribir las observaciones de forma correcta", "Creando requisición");
            //    CrearRequisicion = false;
            //}
            if (dtDetalleInsercion.Rows.Count < 1)
            {
                XtraMessageBox.Show(this, "Debe indicar los productos a requerir", "Creando requisición");
                CrearRequisicion = false;
            }
            for (int i = 0; i < gridViewListaDetalleProductos.DataRowCount; i++)
            {
                if (Convert.ToInt16(gridViewListaDetalleProductos.GetRowCellValue(i, "cantidad_requerida")) == 0)
                {
                    XtraMessageBox.Show(this, "Uno o mas productos deben tener una cantidad mayor a 0", "Creando requisición");
                    CrearRequisicion = false;
                    break;
                }
            }

            if (CrearRequisicion)
            {
                MRequisicion requisicion = new MRequisicion();
                requisicion.Idtienda = Configuraciones.Configuraciones.idtienda;
                requisicion.Idusuario = Configuraciones.Configuraciones.idusuario;
                requisicion.Observacion = string.IsNullOrWhiteSpace(textObservaciones.Text) == true ? "" : textObservaciones.Text;
                requisicion.IdEstadoRequisicion = 1;

                List<MRequisicionDetalle> detalleInsercionCaracteristicas = new List<MRequisicionDetalle>();
                for (int i = 0; i < gridViewListaDetalleProductos.DataRowCount; i++)
                {
                    MRequisicionDetalle requisicionProductos = new MRequisicionDetalle();
                    requisicionProductos.Idcapturapedidodetalle = 0;
                    requisicionProductos.Idtienda = Configuraciones.Configuraciones.idtienda;
                    requisicionProductos.Idproducto = Convert.ToInt32(gridViewListaDetalleProductos.GetRowCellValue(i, "idproducto"));
                    requisicionProductos.CantidadRequerida = Convert.ToInt32(gridViewListaDetalleProductos.GetRowCellValue(i, "cantidad_requerida"));
                    requisicionProductos.Opcion = 1;
                    detalleInsercionCaracteristicas.Add(requisicionProductos);
                }

                respuesta = ControllerCapturaPedido.GuardarCapturaPedidoRequisicion(requisicion, detalleInsercionCaracteristicas);

                if (respuesta == "OK")
                {
                    FormImprimirRequisicio modalImprimir = new FormImprimirRequisicio();

                    modalImprimir.IdTienda = Configuraciones.Configuraciones.idtienda;
                    modalImprimir.IdCapturaPedido = ControllerCapturaPedido.idcapturapedido;
                    modalImprimir.ShowDialog();

                    textObservaciones.Text = string.Empty;
                    spinEditCantidad.Value = 0;
                    dtDetalleInsercion.Clear();

                }
                else
                {
                    XtraMessageBox.Show("Error al crear requisición, consulte a su administrador de datos " + respuesta, "Creando requisición");
                }
            }
        }

        private void textObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuscrProducto.Focus();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool AgrearProducto = true;
            if (lookUpEditProductos.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe indicar el producto a requerir en el campo","Creando requisición");
                AgrearProducto = false;
            }

            if (spinEditCantidad.Value == 0)
            {
                XtraMessageBox.Show("Debe indicar la cantidad a requerir", "Creando requisición");
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
                        if (XtraMessageBox.Show("El producto ya existe, ¿desea aumentar la cantidad? ", "Creando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                        {
                            item["cantidad_requerida"] = Convert.ToInt32(item["cantidad_requerida"]) + Convert.ToInt32(spinEditCantidad.Value);
                            break;
                        }
                    }
                }
                if (agregar)
                {
                    DataRow dtRow = dtDetalleInsercion.NewRow();
                    dtRow["id_captura_pedido_detalle"] = 0;
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



                txtBuscrProducto.Text = string.Empty;
                spinEditCantidad.EditValue = 0;
                txtBuscrProducto.Focus();
            }
           
        }

      

      
        public FormRequisicion()
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
        //______________________________________________________________________________________________________________________
        //______________________________________________________________________________________________________________________

        private void FormRequisicion_Load(object sender, EventArgs e)
        {

            Creartabla();
            dateEditFecha.EditValue = DateTime.Now;
            dxErrorProvider1.SetError(lookUpEditProductos,"ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(spinEditCantidad, "ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtBuscrProducto, "ESTE CAMPO ES OBLIGATORIO");
        }

        private void FormRequisicion_Activated(object sender, EventArgs e)
        {
            textObservaciones.Focus();

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
                XtraMessageBox.Show("No hay productos para quitar", "Creando Requisición");
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
                    XtraMessageBox.Show("No hay productos para quitar", "Creando Requisición");
                }
            }
        }

      

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRequisicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

  
    
     
      

     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea salir? ", "Creando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }

    

        private void lookUpEditCodigoProducto_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
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

        private void FormRequisicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (XtraMessageBox.Show("¿Desea salir? ", "Creando requisición", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void gridControlListaTodasRequisiciones_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEditProductos_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void lookUpEditProductos_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditProductos_TextChanged(object sender, EventArgs e)
        {
            //mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", ControllerCapturaPedido.MostrarProductosPorFiltro(lookUpEditProductos.Text));
        }

        private void txtBuscrProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditCantidad.Focus();
            }
        }

        private void txtBuscrProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProductos, "nombre", "idproducto", dt = ControllerCapturaPedido.MostrarProductos(string.IsNullOrWhiteSpace(txtBuscrProducto.Text) == true ? "&&" : txtBuscrProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProductos.ItemIndex = 0;
            }
        }

        private void FormRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void FormRequisicion_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }
    }
}