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

namespace ViewGuate502.Buscadores
{
    public partial class BuscadorClientesCUI : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        dbMasterDataSet dbMaster = new dbMasterDataSet();
        Listado_clientesTableAdapter tbl_clientes = new Listado_clientesTableAdapter();
        public DataTable dt;
        Ventas.VentaForm ventaForm = new Ventas.VentaForm(2);
        int tipo_venta = 0;
        ValidarBloqueoClienteTableAdapter validarBloqueoCliente = new ValidarBloqueoClienteTableAdapter();
        ClienteTableAdapter ClienteTableAdapter = new ClienteTableAdapter();
        public BuscadorClientesCUI(int id_tipo_venta, Ventas.VentaForm ventas)
        {
            InitializeComponent();
            ventaForm = ventas;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (tbcuicliente.Text != "")
            {
                string cui = tbcuicliente.Text;

                var cliente = (from a in dbSoftwareGTDataSet.Listado_clientes
                               where a.dpi == cui
                               select a).FirstOrDefault();

                if(cliente != null)
                {
                    this.gvresultadoclientes.AddNewRow();
                    var rowHandle = this.gvresultadoclientes.GetRowHandle(this.gvresultadoclientes.DataRowCount);
                    if (gvresultadoclientes.IsNewItemRow(rowHandle))
                    {
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[0], cliente.id_cliente);
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[1], cliente.nombre_cliente);
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[2], cliente.dpi);
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[3], cliente.nit);
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[4], cliente.direccion);
                        gvresultadoclientes.SetRowCellValue(rowHandle, gvresultadoclientes.Columns[5], cliente.telefono);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para esta búsqueda.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el CUI del cliente para hacer la búsqueda.");
            }
        }

        private void BuscadorClientesCUI_Load(object sender, EventArgs e)
        {
            IniciarTablas();
            dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("CUI", typeof(string));
            dt.Columns.Add("NIT", typeof(string));
            dt.Columns.Add("Direccion", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));

            gcresultadoclientes.DataSource = dt;

            gvresultadoclientes.Columns[0].OptionsColumn.AllowEdit = false;
            gvresultadoclientes.Columns[1].OptionsColumn.AllowEdit = false;
            gvresultadoclientes.Columns[2].OptionsColumn.AllowEdit = false;
            gvresultadoclientes.Columns[3].OptionsColumn.AllowEdit = false;
            gvresultadoclientes.Columns[4].OptionsColumn.AllowEdit = false;

            gvresultadoclientes.Columns[0].OptionsColumn.ReadOnly = true;
            gvresultadoclientes.Columns[1].OptionsColumn.ReadOnly = true;
            gvresultadoclientes.Columns[2].OptionsColumn.ReadOnly = true;
            gvresultadoclientes.Columns[3].OptionsColumn.ReadOnly = true;
            gvresultadoclientes.Columns[4].OptionsColumn.ReadOnly = true;
        }

        public void IniciarTablas()
        {
            tbl_clientes.Fill(dbSoftwareGTDataSet.Listado_clientes);
        }

        private void gvresultadoclientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id_cliente = int.Parse(gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Id").ToString());
            validarBloqueoCliente.Fill(dbSoftwareGTDataSet.ValidarBloqueoCliente, id_cliente);
            string empresa_bloqueo = (from a in dbSoftwareGTDataSet.ValidarBloqueoCliente
                                      select a.codigo_empresa).SingleOrDefault();

            if (empresa_bloqueo == "F1")
            {
                MessageBox.Show("El cliente seleccionado se encuentra bloqueado en la empresa Pecul, se sugiere pueda contactar con dicha empresa para obtener más información.");
                ventaForm.tbidcliente.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Id").ToString();
                ventaForm.tbnombrecliente.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Nombre").ToString();
                ventaForm.tbnit.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "NIT").ToString();
                ventaForm.tbdireccion.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Direccion").ToString();
                ventaForm.tbidcliente.Enabled = false;
                ventaForm.tbnombrecliente.Enabled = false;
                ventaForm.tbnit.Enabled = false;
                ventaForm.tbdireccion.Enabled = false;
                this.Close();
            }
            else if (empresa_bloqueo == "A1")
            {
                MessageBox.Show("El cliente seleccionado se encuentra bloqueado en esta empresa. No es posible ligarlo a una venta.");
            }
            else if (empresa_bloqueo == null)
            {
                ventaForm.tbidcliente.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Id").ToString();
                ventaForm.tbnombrecliente.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Nombre").ToString();
                ventaForm.tbnit.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "NIT").ToString();
                ventaForm.tbdireccion.Text = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Direccion").ToString();
                ventaForm.tbidcliente.Enabled = false;
                ventaForm.tbnombrecliente.Enabled = false;
                ventaForm.tbnit.Enabled = false;
                ventaForm.tbdireccion.Enabled = false;
                this.Close();
            }
        }

        private void gvresultadoclientes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id_cliente = int.Parse(gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Id").ToString());
            string telefono = gvresultadoclientes.GetRowCellValue(gvresultadoclientes.FocusedRowHandle, "Telefono").ToString();
            (from a in dbMaster.Cliente
             where a.id_cliente == id_cliente
             select a).ToList().ForEach(a => { a.telefono = telefono; });
            ClienteTableAdapter.Update(dbMaster);
            this.ClienteTableAdapter.Fill(this.dbMaster.Cliente);
        }
    }
}