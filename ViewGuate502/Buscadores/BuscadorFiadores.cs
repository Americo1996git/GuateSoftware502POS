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
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using ViewGuate502.dbMasterDataSetTableAdapters;
using DevExpress.XtraEditors.Controls;
using ViewGuate502.Ventas;

namespace ViewGuate502.Buscadores
{
    public partial class BuscadorFiadores : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        dbMasterDataSet dbMaster = new dbMasterDataSet();
        Listado_fiadoresTableAdapter listado_Fiadores = new Listado_fiadoresTableAdapter();

        Ventas.VentaForm ventaForm = null;
        int tipo_venta = 0;
        public DataTable dt;
        public DataTable dt1;
        ClienteTableAdapter ClienteTableAdapter = new ClienteTableAdapter();
        Ventas.RealizarVenta realizarVenta = null;
        public BuscadorFiadores(int id_tipo_venta, Ventas.VentaForm ventas, Ventas.RealizarVenta rv)
        {
            InitializeComponent();
            ventaForm = ventas;
            tipo_venta = id_tipo_venta;
            realizarVenta = rv;
            
            dt1 = new DataTable();

            dt1.Columns.Add("Id", typeof(int));
            dt1.Columns.Add("Nombre", typeof(string));
            dt1.Columns.Add("CUI", typeof(string));
            dt1.Columns.Add("NIT", typeof(string));

            gcfiadores.DataSource = dt1;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(tbcuifiador.Text != "")
            {
                string dpi = tbcuifiador.Text;
                listado_Fiadores.Fill(dbSoftwareGTDataSet.Listado_fiadores, dpi);

                var cliente = dbSoftwareGTDataSet.Listado_fiadores.Where(a => a.dpi == dpi).SingleOrDefault();
                if (cliente != null)
                {
                    dt = new DataTable();

                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("CUI", typeof(string));
                    dt.Columns.Add("NIT", typeof(string));
                    dt.Columns.Add("Telefono", typeof(string));
                    gcresultadosbusqueda.DataSource = dt;

                    this.gvresultadosbusqueda.AddNewRow();
                    var rowHandle = this.gvresultadosbusqueda.GetRowHandle(this.gvresultadosbusqueda.DataRowCount);
                    if (gvresultadosbusqueda.IsNewItemRow(rowHandle))
                    {
                        gvresultadosbusqueda.SetRowCellValue(rowHandle, gvresultadosbusqueda.Columns[0], cliente.id_cliente);
                        gvresultadosbusqueda.SetRowCellValue(rowHandle, gvresultadosbusqueda.Columns[1], cliente.nombres);
                        gvresultadosbusqueda.SetRowCellValue(rowHandle, gvresultadosbusqueda.Columns[2], cliente.dpi);
                        gvresultadosbusqueda.SetRowCellValue(rowHandle, gvresultadosbusqueda.Columns[3], cliente.nit);
                        gvresultadosbusqueda.SetRowCellValue(rowHandle, gvresultadosbusqueda.Columns[4], cliente.telefono);
                    }

                    gvresultadosbusqueda.Columns[0].OptionsColumn.AllowEdit = false;
                    gvresultadosbusqueda.Columns[1].OptionsColumn.AllowEdit = false;
                    gvresultadosbusqueda.Columns[2].OptionsColumn.AllowEdit = false;
                    gvresultadosbusqueda.Columns[3].OptionsColumn.AllowEdit = false;

                    gvresultadosbusqueda.Columns[0].OptionsColumn.ReadOnly = true;
                    gvresultadosbusqueda.Columns[1].OptionsColumn.ReadOnly = true;
                    gvresultadosbusqueda.Columns[2].OptionsColumn.ReadOnly = true;
                    gvresultadosbusqueda.Columns[3].OptionsColumn.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("El CUI ingresado no existe en la base de datos o no está configurado como fiador. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            else
            {
                MessageBox.Show("Ingrese un número de CUI para hacer la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(ventaForm != null)
            {
                ventaForm.fiadores = new List<Tuple<int, string, string, string>>();
                for (int i = 0; i < gvfiadores.DataRowCount; i++)
                {
                    ventaForm.fiadores.Add(new Tuple<int, string, string, string>(int.Parse(gvfiadores.GetRowCellValue(i, "Id").ToString()), gvfiadores.GetRowCellValue(i, "Nombre").ToString(), gvfiadores.GetRowCellValue(i, "CUI").ToString(), gvfiadores.GetRowCellValue(i, "NIT").ToString()));
                }
            }
            else if(realizarVenta != null)
            {
                realizarVenta.fiadores = new List<Fiadores>();
                for (int i = 0; i < gvfiadores.DataRowCount; i++)
                {
                    Fiadores fiadores = new Fiadores
                    {
                        id_fiador = int.Parse(gvfiadores.GetRowCellValue(i, "Id").ToString()),
                        nombre_fiador = gvfiadores.GetRowCellValue(i, "Nombre").ToString(),
                        cui = gvfiadores.GetRowCellValue(i, "CUI").ToString(),
                        nit = gvfiadores.GetRowCellValue(i, "NIT").ToString()
                    };
                    realizarVenta.fiadores.Add(fiadores);
                }

            }
            
            MessageBox.Show("¡Fiadores agregados correctamente!");
            this.Close();
        }

        private void gcresultadosbusqueda_Click(object sender, EventArgs e)
        {
            if(gvresultadosbusqueda.GetFocusedRow() != null)
            {
                int id_fiador = int.Parse(gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "Id").ToString());
                int contador = 0;
                for (int i = 0; i < gvfiadores.DataRowCount; i++)
                {
                    if (int.Parse(gvfiadores.GetRowCellValue(i, "Id").ToString()) == id_fiador)
                    {
                        contador = contador + 1;
                    }
                }

                if (contador == 0)
                {
                    this.gvfiadores.AddNewRow();
                    var rowHandle = this.gvfiadores.GetRowHandle(this.gvfiadores.DataRowCount);
                    if (gvfiadores.IsNewItemRow(rowHandle))
                    {
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[0], gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "Id").ToString());
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[1], gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "Nombre").ToString());
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[2], gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "CUI").ToString());
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[3], gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "NIT").ToString());
                        gvfiadores.UpdateCurrentRow();
                    }
                }
            }
        }

        private void BuscadorFiadores_Load(object sender, EventArgs e)
        {
            if(ventaForm != null && ventaForm.fiadores.Count > 0)
            {
                for(int i = 0; i < ventaForm.fiadores.Count; i++)
                {
                    this.gvfiadores.AddNewRow();
                    var rowHandle = this.gvfiadores.GetRowHandle(this.gvfiadores.DataRowCount);
                    if (gvfiadores.IsNewItemRow(rowHandle))
                    {
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[0], ventaForm.fiadores[i].Item1);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[1], ventaForm.fiadores[i].Item2);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[2], ventaForm.fiadores[i].Item3);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[3], ventaForm.fiadores[i].Item4);
                        gvfiadores.UpdateCurrentRow();
                    }
                }
            }
            else if(realizarVenta != null && realizarVenta.fiadores.Count > 0)
            {
                for (int i = 0; i < realizarVenta.fiadores.Count; i++)
                {
                    this.gvfiadores.AddNewRow();
                    var rowHandle = this.gvfiadores.GetRowHandle(this.gvfiadores.DataRowCount);
                    if (gvfiadores.IsNewItemRow(rowHandle))
                    {
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[0], realizarVenta.fiadores[i].id_fiador);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[1], realizarVenta.fiadores[i].nombre_fiador);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[2], realizarVenta.fiadores[i].cui);
                        gvfiadores.SetRowCellValue(rowHandle, gvfiadores.Columns[3], realizarVenta.fiadores[i].nit);
                        gvfiadores.UpdateCurrentRow();
                    }
                }
            }
        }

        private void gvresultadosbusqueda_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id_cliente = int.Parse(gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "Id").ToString());
            string telefono = gvresultadosbusqueda.GetRowCellValue(gvresultadosbusqueda.FocusedRowHandle, "Telefono").ToString();
            (from a in dbMaster.Cliente
             where a.id_cliente == id_cliente
             select a).ToList().ForEach(a => { a.telefono = telefono; });
            ClienteTableAdapter.Update(dbMaster);
            this.ClienteTableAdapter.Fill(this.dbMaster.Cliente);
        }

        private void tbcuifiador_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}