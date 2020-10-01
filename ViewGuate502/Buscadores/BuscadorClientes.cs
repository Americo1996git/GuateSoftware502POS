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
using DevExpress.XtraGrid.Views.Grid;
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using ViewGuate502.dbMasterDataSetTableAdapters;

namespace ViewGuate502.Buscadores
{
    public partial class BuscadorClientes : DevExpress.XtraEditors.XtraForm
    {
        ClienteTableAdapter ClienteTableAdapter = new ClienteTableAdapter();
        Ventas.VentaForm ventaForm = null;
        Ventas.RealizarVenta vnt = null;
        int tipo_venta = 0;
        dbMasterDataSet dbMaster = new dbMasterDataSet();
        Ventas.Consultas.Proformas Proformas = null;
        public BuscadorClientes(int id_tipo_venta, Ventas.VentaForm ventas, Ventas.Consultas.Proformas prfrms, Ventas.RealizarVenta vts)
        {
            InitializeComponent();
            if (ventas != null)
            {
                ventaForm = ventas;
            }
            if (prfrms != null)
            {
                Proformas = prfrms;
            }
            if (vts != null)
            {
                vnt = vts;
            }
            
            tipo_venta = id_tipo_venta;
        }
        ValidarBloqueoClienteTableAdapter validarBloqueoCliente = new ValidarBloqueoClienteTableAdapter();
        private void BuscandorClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.Listado_clientes' Puede moverla o quitarla según sea necesario.
            this.listado_clientesTableAdapter.Fill(this.dbSoftwareGTDataSet.Listado_clientes);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.Listado_clientes' Puede moverla o quitarla según sea necesario.
            this.listado_clientesTableAdapter.Fill(this.dbSoftwareGTDataSet.Listado_clientes);
            this.ClienteTableAdapter.Fill(this.dbMaster.Cliente);

            this.gvlistadoclientes.BestFitColumns();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            int id_cliente = int.Parse(gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString());
            validarBloqueoCliente.Fill(dbSoftwareGTDataSet.ValidarBloqueoCliente, id_cliente);
            string empresa_bloqueo = (from a in dbSoftwareGTDataSet.ValidarBloqueoCliente
                                      select a.codigo_empresa).SingleOrDefault();

            if (empresa_bloqueo == "F1")
            {
                MessageBox.Show("El cliente seleccionado se encuentra bloqueado en la empresa Pecul, se sugiere pueda contactar con dicha empresa para obtener más información.");
                if (ventaForm != null)
                {
                    ventaForm.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    ventaForm.tbnombrecliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    ventaForm.tbnit.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    ventaForm.tbdireccion.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    ventaForm.tbidcliente.Enabled = false;
                    ventaForm.tbnombrecliente.Enabled = false;
                    ventaForm.tbnit.Enabled = false;
                    ventaForm.tbdireccion.Enabled = false;
                }

                if(Proformas != null)
                {
                    Proformas.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    Proformas.tbcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    Proformas.tbnitcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    Proformas.tbdireccioncliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    Proformas.tbtelefono.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "telefono").ToString();
                    Proformas.tbidcliente.Enabled = false;
                    Proformas.tbcliente.Enabled = false;
                    Proformas.tbnitcliente.Enabled = false;
                    Proformas.tbdireccioncliente.Enabled = false;
                    Proformas.tbtelefono.Enabled = false;
                }
                if(vnt != null)
                {
                    vnt.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    vnt.tbcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    vnt.tbnit.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    vnt.tbdireccion.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    vnt.tbtelefono.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "telefono").ToString();
                    vnt.tbidcliente.Enabled = false;
                    vnt.tbcliente.Enabled = false;
                    vnt.tbnit.Enabled = false;
                    vnt.tbdireccion.Enabled = false;
                    vnt.tbtelefono.Enabled = false;
                }
                
                this.Close();
            }
            else if(empresa_bloqueo == "A1")
            {
                MessageBox.Show("El cliente seleccionado se encuentra bloqueado en esta empresa. No es posible ligarlo a una venta.");
            }
            else if (empresa_bloqueo == null)
            {
                if (ventaForm != null)
                {
                    ventaForm.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    ventaForm.tbnombrecliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    ventaForm.tbnit.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    ventaForm.tbdireccion.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    ventaForm.tbidcliente.Enabled = false;
                    ventaForm.tbnombrecliente.Enabled = false;
                    ventaForm.tbnit.Enabled = false;
                    ventaForm.tbdireccion.Enabled = false;
                }

                if (Proformas != null)
                {
                    Proformas.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    Proformas.tbcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    Proformas.tbnitcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    Proformas.tbdireccioncliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    Proformas.tbtelefono.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "telefono").ToString();
                    Proformas.tbidcliente.Enabled = false;
                    Proformas.tbcliente.Enabled = false;
                    Proformas.tbnitcliente.Enabled = false;
                    Proformas.tbdireccioncliente.Enabled = false;
                    Proformas.tbtelefono.Enabled = false;
                }

                if (vnt != null)
                {
                    vnt.tbidcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString();
                    vnt.tbcliente.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nombre_cliente").ToString();
                    vnt.tbnit.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "nit").ToString();
                    vnt.tbdireccion.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "direccion").ToString();
                    vnt.tbtelefono.Text = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "telefono").ToString();
                    vnt.tbidcliente.Enabled = false;
                    vnt.tbcliente.Enabled = false;
                    vnt.tbnit.Enabled = false;
                    vnt.tbdireccion.Enabled = false;
                    vnt.tbtelefono.Enabled = false;
                }

                this.Close();
            }
        }

        private void gvlistadoclientes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id_cliente = int.Parse(gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "id_cliente").ToString());
            string telefono = gvlistadoclientes.GetRowCellValue(gvlistadoclientes.FocusedRowHandle, "telefono").ToString();
            (from a in dbMaster.Cliente
             where a.id_cliente == id_cliente
             select a).ToList().ForEach(a => { a.telefono = telefono; });
            ClienteTableAdapter.Update(dbMaster);
            this.ClienteTableAdapter.Fill(this.dbMaster.Cliente);
        }
    }
}