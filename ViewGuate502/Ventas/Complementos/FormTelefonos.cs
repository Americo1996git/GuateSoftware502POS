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

namespace ViewGuate502.Ventas.Complementos
{
    public partial class FormTelefonos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_cliente=0,id_telefono;
        public int tipo_creacion = 0;
        public FormTelefonos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool grabar = true;
            string rpta = "";
            if (tipo_creacion == 0)
            {
                //if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                //{
                //    XtraMessageBox.Show("Debe escribir la descripción de forma correcta", "Agregando telefonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtDescripcion.Focus();
                //    grabar = false;
                //}

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    XtraMessageBox.Show("Debe escribir el telefono de forma correcta", "Agregando telefonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                    grabar = false;
                }

                if (grabar)
                {
                    rpta = ControllerVentas.AgregarTelefonoCliente(id_cliente, txtDescripcion.Text, txtTelefono.Text);
                    if (rpta == "OK")
                    {
                        gridControl1.DataSource = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                        gridControl1.ForceInitialize();
                        gridView1.BestFitColumns();
                        txtDescripcion.Text = string.Empty;
                        txtTelefono.Text = string.Empty;
                        txtDescripcion.Focus();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un erro al grabar el telefono, por favor consulte a su admistrador de datos", "Error al grabar");

                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    XtraMessageBox.Show("Debe escribir el telefono de forma correcta", "Agregando telefonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                    grabar = false;
                }
                if (grabar)
                {
                    Clientes.FormClientes clientes = Clientes.FormClientes.GetInstacnia();
                    DataRow row = clientes.dtTelefono.NewRow();
                    row["id_cliente"] = id_cliente;
                    row["id_telefono"] = 0;
                    row["descripcion"] = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? " " : txtDescripcion.Text;
                    row["telefono"] = txtTelefono.Text;
                    clientes.dtTelefono.Rows.Add(row);

                    gridView1.BestFitColumns();
                    txtDescripcion.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                    txtDescripcion.Focus();
                }

            }
          
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "descripcion" || e.Column.FieldName == "telefono")
            {
                if (tipo_creacion == 0)
                {
                    bool actualizar = true;
                    string rpta = "";
                    if (string.IsNullOrWhiteSpace(Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "descripcion"))))
                    {
                        XtraMessageBox.Show("Debe escribir la descripción de forma correcta", "Agregando telefonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar = false;
                    }
                    if (string.IsNullOrWhiteSpace(Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "telefono"))))
                    {
                        XtraMessageBox.Show("Debe escribir el telefono de forma correcta", "Agregando telefonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar = false;
                    }
                    if (actualizar)
                    {
                        rpta = ControllerVentas.ActualizarTelefonoCliente(id_cliente, Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "id_telefono")), Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "descripcion")), Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "telefono")));
                        if (rpta == "OK")
                        {
                            gridControl1.DataSource = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                            gridControl1.ForceInitialize();
                            gridView1.BestFitColumns();
                        }
                        else
                        {
                            XtraMessageBox.Show("Ocurrio un erro al actualizar el telefono, por favor consulte a su admistrador de datos", "Error al grabar");

                        }
                    }


                }
            }
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTelefonos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar.Focus();
            }
        }

        private void btnQuitrTelefono_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (tipo_creacion == 0)
                {
                    string rpt = "";
                    rpt = ControllerVentas.EliminarTelefonoCliente(id_cliente, Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_telefono")));
                    if (rpt == "OK")
                    {
                        gridControl1.DataSource = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                        gridControl1.ForceInitialize();
                        gridView1.BestFitColumns();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un erro al quitar el telefono, por favor consulte a su admistrador de datos", "Error al grabar");

                    }
                }
                else
                {
                    Clientes.FormClientes cliente = Clientes.FormClientes.GetInstacnia();
                    int rowIndex = gridView1.FocusedRowHandle;
                    DataRow row = cliente.dtTelefono.Rows[rowIndex];
                    cliente.dtTelefono.Rows.Remove(row);
                }
               
            }
        }

        private void FormTelefonos_Load(object sender, EventArgs e)
        {
            if (tipo_creacion == 0) //si se etan agregando en ventas
            {
                gridControl1.DataSource = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                gridControl1.ForceInitialize();
                gridView1.BestFitColumns();
            }
            if (tipo_creacion == 1)//si se esta creando un nuevo cliente
            {
                Clientes.FormClientes clientes = Clientes.FormClientes.GetInstacnia();
                gridControl1.DataSource = clientes.dtTelefono;
                gridControl1.ForceInitialize();
                gridView1.BestFitColumns();
            }
            if (tipo_creacion == 2)//si se esta editando el cliente
            {
                Clientes.FormClientes clientes = Clientes.FormClientes.GetInstacnia();
                gridControl1.DataSource = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                gridControl1.ForceInitialize();
                gridView1.BestFitColumns();
            }

        }
    }
}