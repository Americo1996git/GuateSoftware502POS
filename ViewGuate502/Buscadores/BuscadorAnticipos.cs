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
using ViewGuate502.Ventas;
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;

namespace ViewGuate502.Buscadores
{
    public partial class BuscadorAnticipos : DevExpress.XtraEditors.XtraForm
    {
        Ventas.VentaForm ventaForm = null;
        int tipo_venta = 0;
        public DataTable dt;
        Ventas.RealizarVenta realizarVenta = null;
        List<Anticipo> anticipos_local = new List<Anticipo>();
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_recibos_anticiposTableAdapter tbl_recibos_anticipos = new tbl_recibos_anticiposTableAdapter();
        public BuscadorAnticipos(int id_tipo_venta, Ventas.VentaForm ventas, Ventas.RealizarVenta rv)
        {
            InitializeComponent();
            ventaForm = ventas;
            tipo_venta = id_tipo_venta;
            realizarVenta = rv;
        }

        private void gvresultadosanticipos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id_anticipo = int.Parse(gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "id_recibos_anticipo").ToString());
            int contador = 0;
            for (int i = 0; i < gvlistadoanticipos.DataRowCount; i++)
            {
                if (int.Parse(gvlistadoanticipos.GetRowCellValue(i, "Id").ToString()) == id_anticipo)
                {
                    contador = contador + 1;
                }
            }

            if (contador == 0)
            {
                gvlistadoanticipos.AddNewRow();

                int rowHandle1 = gvlistadoanticipos.GetRowHandle(gvlistadoanticipos.DataRowCount);
                if (gvlistadoanticipos.IsNewItemRow(rowHandle1))
                {
                    gvlistadoanticipos.SetRowCellValue(rowHandle1, gvlistadoanticipos.Columns[0], gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "id_recibos_anticipo").ToString());
                    gvlistadoanticipos.SetRowCellValue(rowHandle1, gvlistadoanticipos.Columns[1], gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "nombre_cliente").ToString());
                    gvlistadoanticipos.SetRowCellValue(rowHandle1, gvlistadoanticipos.Columns[2], gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "monto_recibo").ToString());
                    gvlistadoanticipos.SetRowCellValue(rowHandle1, gvlistadoanticipos.Columns[3], gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "detalle_recibo").ToString());
                    gvlistadoanticipos.SetRowCellValue(rowHandle1, gvlistadoanticipos.Columns[4], gvresultadosanticipos.GetRowCellValue(gvresultadosanticipos.FocusedRowHandle, "fecha_creacion").ToString());
                    gvlistadoanticipos.UpdateCurrentRow();
                }
            }
        }

        private void BuscadorAnticipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_recibos_anticipos' Puede moverla o quitarla según sea necesario.
            this.tbl_recibos_anticiposTableAdapter.FillBy(this.dbSoftwareGTDataSet.tbl_recibos_anticipos);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_recibos_anticipos' Puede moverla o quitarla según sea necesario.
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Monto", typeof(decimal));
            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("FechaCreacion", typeof(DateTime));

            gclistadoanticipos.DataSource = dt;

            if(ventaForm != null)
            {
                if (ventaForm.anticipos.Count > 0)
                {
                    for (int i = 0; i < ventaForm.anticipos.Count; i++)
                    {
                        if (ventaForm.anticipos[i].Item1 != 0)
                        {
                            this.gvlistadoanticipos.AddNewRow();
                            var rowHandle = this.gvlistadoanticipos.GetRowHandle(this.gvlistadoanticipos.DataRowCount);
                            if (gvlistadoanticipos.IsNewItemRow(rowHandle))
                            {
                                gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[0], ventaForm.anticipos[i].Item1);
                                gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[2], ventaForm.anticipos[i].Item2);
                                gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[3], ventaForm.anticipos[i].Item3);
                                gvlistadoanticipos.UpdateCurrentRow();
                            }
                        }
                    }
                }
            }

            if (realizarVenta.anticipos != null)
            {
                foreach(var a in realizarVenta.anticipos)
                {
                    if(a.id_anticipo != 0)
                    {
                        this.gvlistadoanticipos.AddNewRow();
                        var rowHandle = this.gvlistadoanticipos.GetRowHandle(this.gvlistadoanticipos.DataRowCount);
                        if (gvlistadoanticipos.IsNewItemRow(rowHandle))
                        {
                            gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[0], a.id_anticipo);
                            gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[1], a.monto_anticipo);
                            gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[2], a.id_tipo_pago);
                            gvlistadoanticipos.SetRowCellValue(rowHandle, gvlistadoanticipos.Columns[3], a.descripcion);
                            gvlistadoanticipos.UpdateCurrentRow();
                        }
                    }
                }
            }
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(gvlistadoanticipos.DataRowCount > 0)
            {
                if (realizarVenta.anticipos.Count > 0)
                {
                    foreach (var a in realizarVenta.anticipos)
                    {
                        if (a.id_anticipo == 0)
                        {
                            Anticipo anti = new Anticipo
                            {
                                id_anticipo = a.id_anticipo,
                                monto_anticipo = a.monto_anticipo,
                                id_tipo_pago = a.id_tipo_pago,
                                descripcion = a.descripcion
                            };
                            anticipos_local.Add(anti);
                        }
                    }
                }

                for (int i = 0; i < gvlistadoanticipos.DataRowCount; i++)
                {
                    if(ventaForm != null)
                    {
                        //ventaForm.anticipos.Add(new Tuple<int, decimal, int, string>(int.Parse(gvlistadoanticipos.GetRowCellValue(i, "Id").ToString()), decimal.Parse(gvlistadoanticipos.GetRowCellValue(i, "Monto").ToString()), 0, gvlistadoanticipos.GetRowCellValue(i, "Detalle").ToString()));
                    }

                    if (realizarVenta != null)
                    {
                        Anticipo ant = new Anticipo
                        {
                            id_anticipo = int.Parse(gvlistadoanticipos.GetRowCellValue(i, "Id").ToString()),
                            monto_anticipo = decimal.Parse(gvlistadoanticipos.GetRowCellValue(i, "Monto").ToString()),
                            id_tipo_pago = 0,
                            descripcion = gvlistadoanticipos.GetRowCellValue(i, "Detalle").ToString()
                        };

                        anticipos_local.Add(ant);
                    }

                    realizarVenta.anticipos = anticipos_local;
                    realizarVenta.btnagregaranticipo.Enabled = false;
                    realizarVenta.btncrearanticipo.Enabled = false;

                }
                MessageBox.Show("¡Anticipos guardados exitosamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("¡No se guardó ningún anticipo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_recibos_anticiposTableAdapter.FillBy(this.dbSoftwareGTDataSet.tbl_recibos_anticipos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}