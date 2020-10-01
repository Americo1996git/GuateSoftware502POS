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

namespace ViewGuate502.Buscadores
{
    public partial class BuscadorProductos : DevExpress.XtraEditors.XtraForm
    {
        Ventas.VentaForm ventaForm = null;
        int tipo_venta = 0;
        Ventas.Consultas.Series series = null;
        Ventas.Consultas.Proformas proformas = null;
        Ventas.RealizarVenta nuevaVenta = null;

        public DataTable dtBodegas;
        public BuscadorProductos(int id_tipo_venta, Ventas.VentaForm venta, Ventas.Consultas.Series srs, Ventas.Consultas.Proformas prf, Ventas.RealizarVenta nv)
        {
            InitializeComponent();
            ventaForm = venta;
            id_tipo_venta = tipo_venta;
            series = srs;
            proformas = prf;
            nuevaVenta = nv;
            gvlistadoproductos.BestFitColumns();
        }

        private void BuscadorProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.ListadoProductosVenta' Puede moverla o quitarla según sea necesario.
            //this.listadoProductosVentaTableAdapter.Fill(this.dbSoftwareGTDataSet.ListadoProductosVenta);
            dtBodegas = ControllerTrasladoTiedas.MostrarBodegaOrigen(Configuraciones.Configuraciones.idtienda);

            if (dtBodegas.Rows.Count > 0)
            {
                lookUpEditBodegas.Properties.DataSource = dtBodegas;
                lookUpEditBodegas.Properties.ValueMember = "idbodega";
                lookUpEditBodegas.Properties.DisplayMember = "nombre";

                lookUpEditBodegas.ItemIndex = 0;
            }
        }

        private void gvlistadoproductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CreatNewRow();
            /*ventaForm.gclistadoproductos. = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
            ventaForm.tbnombrecliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "razon_social").ToString();
            ventaForm.tbnit.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
            ventaForm.tbdireccion.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion_completa").ToString();*/
        }

        private void CreatNewRow()
        {
            if (ventaForm != null)
            {
                ventaForm.gvlistadoproductos.AddNewRow();

                int rowHandle = ventaForm.gvlistadoproductos.GetRowHandle(ventaForm.gvlistadoproductos.DataRowCount);
                if (ventaForm.gvlistadoproductos.IsNewItemRow(rowHandle))
                {
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[0], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idexistenciadetalle").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[1], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idbodega").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[2], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[3], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "stock").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[4], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "nombre").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[5], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "bodega").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[6], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "producto").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[7], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "codigo_producto").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[8], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioa").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[9], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "preciob").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[10], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioc").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[11], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "descuento_producto").ToString());
                    ventaForm.gvlistadoproductos.SetRowCellValue(rowHandle, ventaForm.gvlistadoproductos.Columns[12], 0);
                    ventaForm.gvlistadoproductos.UpdateCurrentRow();
                }
            }
            else if (proformas != null)
            {
                proformas.gvlistadoproductos.AddNewRow();

                int rowHandle = proformas.gvlistadoproductos.GetRowHandle(proformas.gvlistadoproductos.DataRowCount);
                if (proformas.gvlistadoproductos.IsNewItemRow(rowHandle))
                {
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[0], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idexistenciadetalle").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[1], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idbodega").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[2], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[3], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "stock").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[4], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "nombre").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[5], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "bodega").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[6], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "producto").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[7], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "codigo_producto").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[8], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioa").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[9], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "preciob").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[10], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioc").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[11], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "descuento_producto").ToString());
                    proformas.gvlistadoproductos.SetRowCellValue(rowHandle, proformas.gvlistadoproductos.Columns[12], 0);
                    proformas.gvlistadoproductos.UpdateCurrentRow();
                }
            }
            else if(nuevaVenta != null)
            {
                nuevaVenta.gvlistadoproductos.AddNewRow();

                int rowHandle = nuevaVenta.gvlistadoproductos.GetRowHandle(nuevaVenta.gvlistadoproductos.DataRowCount);
                if (nuevaVenta.gvlistadoproductos.IsNewItemRow(rowHandle))
                {
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[0], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idexistenciadetalle").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[1], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idbodega").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[2], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[3], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "stock").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[4], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "nombre").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[5], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "bodega").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[6], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "producto").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[7], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "codigo_producto").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[8], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioa").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[9], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "preciob").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[10], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioc").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[11], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "descuento_producto").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[12], gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "precioa").ToString());
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[13], 1);
                    nuevaVenta.gvlistadoproductos.SetRowCellValue(rowHandle, nuevaVenta.gvlistadoproductos.Columns[14], 0);
                    nuevaVenta.gvlistadoproductos.UpdateCurrentRow();
                    nuevaVenta.gvlistadoproductos.BestFitColumns();

                    //AUTOR DEL CODIGO BOBY1996
                    bool agregar = true;

                    foreach (DataRow item in nuevaVenta.dtProductos.Rows)
                    {
                       
                        if (Convert.ToInt32(item["IdProducto"]) == Convert.ToInt32(gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto")))
                        {
                            agregar = false;
                            item["Cantidad"] = Convert.ToInt32(item["Cantidad"]) + 1;
                        }
                    }
                    if (agregar)
                    {
                        DataRow dtRow = nuevaVenta.dtProductos.NewRow();
                        dtRow["IdProducto"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto"));
                        dtRow["Cantidad"] = 1;
                        dtRow["IdBodega"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idbodega"));
                        nuevaVenta.dtProductos.Rows.Add(dtRow);
                    }
                    //_____________________________________________________________________________________________________
                }
            }
            else
            {
                series.teidproducto.Text = gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "idproducto").ToString();
                series.tbnombreproducto.Text = gvlistadoproductos.GetRowCellValue(gvlistadoproductos.FocusedRowHandle, "producto").ToString();
                this.Close();
            }
            
        }

        private void BuscadorProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ventaForm != null)
            {
                if (ventaForm.gvlistadoproductos.RowCount > 0)
                {
                    MessageBox.Show("Ingrese el precio unitario de cada producto. Recuerde que este no puede ser menor al Precio C con descuento.");
                    ventaForm.gvlistadoproductos.Focus();
                    ventaForm.btncalcularcuotas.Focus();
                }
            }
            else
            {

            }
        }

        private void lookUpEditBodegas_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBodegas.ItemIndex > -1)
            {
                gclistadoproductos.DataSource = ControllerVentas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditBodegas.EditValue), "");
                gclistadoproductos.ForceInitialize();
                gvlistadoproductos.BestFitColumns();
            }
        }

        private void BuscadorProductos_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}