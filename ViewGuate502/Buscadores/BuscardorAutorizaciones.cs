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

namespace ViewGuate502.Buscadores
{
    public partial class BuscardorAutorizaciones : DevExpress.XtraEditors.XtraForm
    {
        Ventas.VentaForm ventaForm = null;
        RealizarVenta realizarVenta = null;
        int tipo_venta = 0;
        public DataTable dt;
        public BuscardorAutorizaciones(int id_tipo_venta, Ventas.VentaForm ventas, RealizarVenta rv)
        {
            InitializeComponent();
            ventaForm = ventas;
            tipo_venta = id_tipo_venta;
            realizarVenta = rv;
        }

        private void BuscardorAutorizaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_aprobacion_credito' Puede moverla o quitarla según sea necesario.
            this.tbl_tipos_aprobacion_creditoTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_aprobacion_credito);
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Autorizacion", typeof(string));
            
            gclistadoautorizaciones.DataSource = dt;
            gvlistadoautorizaciones.Columns[0].Visible = false;

            if (ventaForm != null && ventaForm.autorizaciones.Count > 0)
            {
                for (int i = 0; i < ventaForm.autorizaciones.Count; i++)
                {
                    this.gvlistadoautorizaciones.AddNewRow();
                    var rowHandle = this.gvlistadoautorizaciones.GetRowHandle(this.gvlistadoautorizaciones.DataRowCount);
                    if (gvlistadoautorizaciones.IsNewItemRow(rowHandle))
                    {
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle, gvlistadoautorizaciones.Columns[0], ventaForm.autorizaciones[i].Item1);
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle, gvlistadoautorizaciones.Columns[1], ventaForm.autorizaciones[i].Item2);
                        gvlistadoautorizaciones.UpdateCurrentRow();
                    }
                }
                mecomentarios.Text = ventaForm.comentarios_autorizaciones;
            }
            else if(realizarVenta != null && realizarVenta.autorizaciones.Count > 0)
            {
                for (int i = 0; i < realizarVenta.autorizaciones.Count; i++)
                {
                    this.gvlistadoautorizaciones.AddNewRow();
                    var rowHandle = this.gvlistadoautorizaciones.GetRowHandle(this.gvlistadoautorizaciones.DataRowCount);
                    if (gvlistadoautorizaciones.IsNewItemRow(rowHandle))
                    {
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle, gvlistadoautorizaciones.Columns[0], realizarVenta.autorizaciones[i].id_autorizacion);
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle, gvlistadoautorizaciones.Columns[1], realizarVenta.autorizaciones[i].nombre_autorizacion);
                        gvlistadoautorizaciones.UpdateCurrentRow();
                    }
                }

                mecomentarios.Text = realizarVenta.comentarios_aut;
            }
        }

        private void gvresultadosautorizaciones_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(gvresultadosautorizaciones.GetFocusedRow() != null)
            {
                int id_autorizacion = int.Parse(gvresultadosautorizaciones.GetRowCellValue(gvresultadosautorizaciones.FocusedRowHandle, "id_tipo_aprobacion").ToString());
                int contador = 0;
                for (int i = 0; i < gvlistadoautorizaciones.DataRowCount; i++)
                {
                    if (int.Parse(gvlistadoautorizaciones.GetRowCellValue(i, "Id").ToString()) == id_autorizacion)
                    {
                        contador = contador + 1;
                    }
                }

                if (contador == 0)
                {
                    gvlistadoautorizaciones.AddNewRow();

                    int rowHandle1 = gvlistadoautorizaciones.GetRowHandle(gvlistadoautorizaciones.DataRowCount);
                    if (gvlistadoautorizaciones.IsNewItemRow(rowHandle1))
                    {
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle1, gvlistadoautorizaciones.Columns[0], gvresultadosautorizaciones.GetRowCellValue(gvresultadosautorizaciones.FocusedRowHandle, "id_tipo_aprobacion").ToString());
                        gvlistadoautorizaciones.SetRowCellValue(rowHandle1, gvlistadoautorizaciones.Columns[1], gvresultadosautorizaciones.GetRowCellValue(gvresultadosautorizaciones.FocusedRowHandle, "tipo_aprobacion").ToString());
                        gvlistadoautorizaciones.UpdateCurrentRow();
                    }
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (gvlistadoautorizaciones.DataRowCount > 0)
            {
                if(ventaForm != null)
                {
                    ventaForm.autorizaciones = new List<Tuple<int, string>>();
                    for (int i = 0; i < gvlistadoautorizaciones.DataRowCount; i++)
                    {
                        ventaForm.autorizaciones.Add(new Tuple<int, string>(int.Parse(gvlistadoautorizaciones.GetRowCellValue(i, "Id").ToString()), gvlistadoautorizaciones.GetRowCellValue(i, "Autorizacion").ToString()));
                    }
                    ventaForm.comentarios_autorizaciones = mecomentarios.Text;
                }
                else if(realizarVenta != null)
                {
                    realizarVenta.autorizaciones = new List<Autorizaciones>();
                    for (int i = 0; i < gvlistadoautorizaciones.DataRowCount; i++)
                    {
                        Autorizaciones autorizaciones = new Autorizaciones
                        {
                            id_autorizacion = int.Parse(gvlistadoautorizaciones.GetRowCellValue(i, "Id").ToString()),
                            nombre_autorizacion = gvlistadoautorizaciones.GetRowCellValue(i, "Autorizacion").ToString()
                        };

                        realizarVenta.autorizaciones.Add(autorizaciones);
                    }
                    realizarVenta.comentarios_aut = mecomentarios.Text;
                }

                MessageBox.Show("¡Autorizaciones guardadas exitosamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("¡No se guardó ninguna autorización!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}