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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraGrid.Views.Tile;

namespace ViewGuate502.ProductosEnBodega
{
    public partial class FormProductosEnBodega : DevExpress.XtraEditors.XtraForm
    {
        int idbodega, totalproductos;

        public DataTable dtProducts_en_Stock;

        public FormProductosEnBodega()
        {
            InitializeComponent();
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

        public void MostrarProductosEnBodegaGeneral(int opcion, int id, int idtienda)
        {
            dtProducts_en_Stock = ControllerProductosEnBodega.MostrarProductosExistencia(opcion, id, idtienda);
            gridControlListaProductosEnBodega.DataSource = dtProducts_en_Stock;
            //gridControlTiendas.DataSource = dtProducts_en_Stock;

        }

       

        public void MostrarProductosTransitoLocal(int opcion, int id, int idtienda)
        {
            gridControlTransitoLocal.DataSource = ControllerProductosEnBodega.MostrarProductosExistencia(opcion, id, idtienda);
        }
        public void MostrarProductosEnBodegaTiendas(int opcion, int id, int idtienda)
        {
            //dtProducts_en_Stock = ControllerProductosEnBodega.MostrarProductosExistencia(1, 0);
            //gridControlListaProductosEnBodega.DataSource = dtProducts_en_Stock;
            gridControlTiendas.DataSource = ControllerProductosEnBodega.MostrarProductosExistencia(opcion,  id,  idtienda);
            gridControlTiendas.ForceInitialize();
            gridViewTiendas.BestFitColumns();


        }
        public void MostrarProductosEnBodegaPorTienda(int opcion, int id, int idtienda)
        {
            //dtProducts_en_Stock = ControllerProductosEnBodega.MostrarProductosExistencia(opcion, idbodega);
            //gridControlListaProductosEnBodega.DataSource = dtProducts_en_Stock;
   
            gridControlBodegasTiendas.DataSource = ControllerProductosEnBodega.MostrarProductosExistencia(opcion, id, idtienda);
            gridControlBodegasTiendas.ForceInitialize();
            gridView1.BestFitColumns();

        }
        public void MostrarTodosProductosTodasBodegas()
        {
            //gridControlTodasBodegas.DataSource = ControllerProductosEnBodega.MostrarTodosLosProductosTodasBodegas();
        }

        public void MostrarProductosPorLinea()
        {
            //gridControlStockLineas.DataSource = ControllerProductosEnBodega.MostrarTodosLosProductosLinea();
        }
        //_________________________________________________________________________________________________________
        void VerProducto()
        {
            try
            {

                if (gridViewListaProductosEnBodega.DataRowCount > 0)
                {
                    int idproducto;
                    decimal sub_linea_descuento = 0, linea_descuento = 0, descuento_producto = 0, descuento_final = 0;
                    string nombre, presentacion, linea, sublinea, marca, meses_garantia, precioa, preciob, precioc, codigo, imagen;
                    idproducto = Convert.ToInt32(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "idproducto"));
                    nombre = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Descripción Producto"));
                    presentacion = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Presentacion"));
                    meses_garantia = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Garantia"));
                    descuento_producto = Convert.ToDecimal(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Descuento"));
                    sub_linea_descuento = Convert.ToDecimal(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "sub_linea_descuento"));
                    linea_descuento = Convert.ToDecimal(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "linea_descuento"));
                    if (descuento_producto == 0 && sub_linea_descuento == 0 && linea_descuento == 0)
                    {
                        descuento_final = descuento_producto;
                    }
                    if (descuento_producto != 0)
                    {
                        descuento_final = descuento_producto;
                    }
                    if (descuento_producto == 0 && sub_linea_descuento != 0)
                    {
                        descuento_final = sub_linea_descuento;
                    }
                    if (descuento_producto == 0 && sub_linea_descuento == 0 && linea_descuento != 0)
                    {
                        descuento_final = linea_descuento;
                    }

                    precioa = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Precio A"));
                    preciob = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Precio B"));
                    precioc = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Precio C"));
                    codigo = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Codigo"));
                    imagen = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "imagen"));
                    //nombre = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "idproducto"));
                    //nombre = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "idproducto"));
                    //nombre = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "idproducto"));
                    FormDetalleProducto modal = new FormDetalleProducto();
                    modal.idproducto = idproducto;
                    modal.nombre = nombre;
                    modal.codigo = codigo;
                    modal.txtModelo.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "modelo"));
                    modal.txtMarca.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Marca"));
                    modal.txtLinea.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Linea"));
                    modal.txtSublinea.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Sub linea"));
                    modal.txtStock.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "Stock"));
                    modal.txtDescuentoSublinea.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "sub_linea_descuento"));
                    modal.txtDescuentoLinea.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "linea_descuento"));
                    modal.presentacion = presentacion;
                    modal.meses_garantia = meses_garantia;
                    modal.descuento = descuento_final;
                    modal.precioa = precioa;
                    modal.preciob = preciob;
                    modal.precioc = precioc;
                    modal.rutaimagen = imagen;
                    modal.txtDesucentoOriginal.Text = Convert.ToString(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "descuento_producto"));
                    modal.gridControlListDetalle.DataSource = ControllerProducto.MostrarCaracteristicas(Convert.ToInt32(gridViewListaProductosEnBodega.GetRowCellValue(gridViewListaProductosEnBodega.FocusedRowHandle, "idproducto")));
                    modal.gridControlListDetalle.ForceInitialize();
                    modal.gridView1.BestFitColumns();


                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Debe hacer doble click sobre el producto" + ex, "");
            }
        }


        private void FormProductosEnBodega_Load(object sender, EventArgs e)
        {
           



            int index = 10;
            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
            dateEditFechaActual.DateTime = DateTime.Now;
         
            MostrarProductosEnBodegaGeneral(1, 0,Configuraciones.Configuraciones.idtienda);

            gridViewListaProductosEnBodega.Columns[0].Visible = false;
            gridViewListaProductosEnBodega.Columns[1].Visible = false;
            gridViewListaProductosEnBodega.Columns["modelo"].Visible = false;
            gridViewListaProductosEnBodega.Columns["Presentacion"].Visible = false;
            gridViewListaProductosEnBodega.Columns["Costo"].Visible = false;
            gridViewListaProductosEnBodega.Columns["sub_linea_descuento"].Visible = false;
            gridViewListaProductosEnBodega.Columns["linea_descuento"].Visible = false;
            gridViewListaProductosEnBodega.Columns["descuento_producto"].Visible = false;


            gridControlListaProductosEnBodega.ForceInitialize();
            gridViewListaProductosEnBodega.BestFitColumns();
      

            gridControlTiendas.ForceInitialize();
            gridViewTiendas.BestFitColumns();

            gridControlBodegasTiendas.ForceInitialize();
            gridView1.BestFitColumns();

 

            gridControlTransitoLocal.ForceInitialize();
            gridViewTransitoLocal.BestFitColumns();
            gridViewListaProductosEnBodega.Columns["Codigo"].Width = 70;
        }



        string ImageDir = @"E:\Trabajo_Programacion\SoftwareVentas\SoftwareGuate502\GuateSoftware502\Imagenes\";
        Hashtable Images = new Hashtable();

        string GetFileName(string color)
        {
            if (color == null || color == string.Empty)
                return string.Empty;
            return color + ".png";
        }

      

        private void tileView2_DoubleClick(object sender, EventArgs e)
        {
            //xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
            //string bodega = tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "nombre").ToString();
            //idbodega = (int)(tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "idbodega"));
            //textBodega.Text = bodega;
            //MostrarProductosEnBodega(idbodega);
        }


       

      

       

        private void tileView2_Click(object sender, EventArgs e)
        {

            //string bodega = tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "nombre").ToString();
            //idbodega = (int)(tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "idbodega"));
            //totalproductos = (int)(tileView2.GetRowCellValue(tileView2.FocusedRowHandle, "cantidadproductos"));
            //textBodega.Text = bodega;
            //textMes.Text = dateEdit1.Text;
            //textStockProductos.Text = totalproductos.ToString();
            //MostrarProductosEnBodega(idbodega);
            //xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }


        private void btnProductosPorBodega_Click(object sender, EventArgs e)
        {
         
        }

       


        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

      
        

        private void gridViewListaProductosEnBodega_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
        

            for (int i = 0; i < dtProducts_en_Stock.Columns.Count; i++)
            {
                //dtProducts_en_Stock.Columns.Add(dtBodega.Rows[i]["nombre"].ToString());
                //GridColumn col = gridViewListaProductosEnBodega.Columns.AddVisible(dtProducts_en_Stock.Columns[index].ColumnName);
                

                if (e.Column.FieldName == dtProducts_en_Stock.Columns[i].ColumnName)
                {
                    if (Convert.ToString(e.Value) =="" )
                    {
                        e.DisplayText = "0";
                    }
                }
            
            }


        }

        private void btnVerPorTienda_Click(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 2;
            MostrarProductosEnBodegaTiendas(2,0,Configuraciones.Configuraciones.idtienda);
            //MostrarProductosEnBodega(2, 0);
            mostrarEnComboboxLookUp(lookUpEditTiendas,"nombre","idtienda",ControllerProductosEnBodega.MostrarTiendas());

            gridViewTiendas.Columns["Costo"].Visible = false;
        }

        private void btnRegresarTiendas_Click(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 2;
            gridControlBodegasTiendas.DataSource = null;
            gridView1.Columns.Clear();
        }

        private void btnRegresarGeneral_Click(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
            
        }

        private void btnBodegaPorTienda_Click(object sender, EventArgs e)
        {
            if (lookUpEditTiendas.ItemIndex > -1)
            {
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 3;
                textTienda.Text = lookUpEditTiendas.Text;
                MostrarProductosEnBodegaPorTienda(3, Convert.ToInt32(lookUpEditTiendas.EditValue), Convert.ToInt32(lookUpEditTiendas.EditValue));
                gridView1.Columns["Costo"].Visible = false;
                gridView1.Columns["Presentación"].Visible = false;
            }

            //MostrarProductosEnBodega(3, Convert.ToInt32(lookUpEditTiendas.EditValue));
        }

        private void lookUpEditTiendas_EditValueChanged(object sender, EventArgs e)
        {

        }

        

       
        private void btnRegresarTiendas2_Click(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 2;
            //gridControlProductosEnTransito.DataSource = null;
            //gridViewProductosEnTransito.Columns.Clear();
        }

        private void btnProductosTransito_Click(object sender, EventArgs e)
        {

        }

        private void gridViewListaProductosEnBodega_DoubleClick(object sender, EventArgs e)
        {
            VerProducto();
           
            
        }

      

        private void btnRegresarTransitoLocal_Click(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }

        private void gridViewListaProductosEnBodega_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridView detailView = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detailView.BestFitColumns();
        }

        private void gridControlListaProductosEnBodega_Load(object sender, EventArgs e)
        {
           
        }

        private void FormProductosEnBodega_Activated(object sender, EventArgs e)
        {
   
        }

        private void btnTransito_Click(object sender, EventArgs e)
        {
            gridControlTransitoLocal.DataSource = ControllerProductosEnBodega.MostrarProductosEnTransito();
            gridControlTransitoLocal.ForceInitialize();
            gridViewTransitoLocal.BestFitColumns();
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
        }

        private void gridViewListaProductosEnBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerProducto();
            }
        }

        private void gridControlListaProductosEnBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                GridControl grid = sender as GridControl;
                GridView view = gridControlListaProductosEnBodega.FocusedView as GridView;
                Clipboard.SetText(view.GetFocusedDisplayText());
                e.Handled = true;
            }
        }

        private void gridControlTiendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                GridControl grid = sender as GridControl;
                GridView view = gridControlTiendas.FocusedView as GridView;
                Clipboard.SetText(view.GetFocusedDisplayText());
                e.Handled = true;
            }
        }

        private void gridControlBodegasTiendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                GridControl grid = sender as GridControl;
                GridView view = gridControlBodegasTiendas.FocusedView as GridView;
                Clipboard.SetText(view.GetFocusedDisplayText());
                e.Handled = true;
            }
        }

        private void FormProductosEnBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                MostrarProductosEnBodegaGeneral(1, 0, Configuraciones.Configuraciones.idtienda);
            }
        }

    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MostrarProductosEnBodegaGeneral(1, 0, Configuraciones.Configuraciones.idtienda);
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            VerProducto();
        }

        private void lookUpEditBodegaCarga_EditValueChanged(object sender, EventArgs e)
        {

            xtraTabControlMenuOpciones.SelectedTabPageIndex = 2;
            //MostrarProductosEnBodega(Convert.ToInt32(lookUpEditBodegaCarga.EditValue));
        }

     

    
    }
}