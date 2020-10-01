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

namespace ViewGuate502.Bancos
{
    public partial class FormListaCuentas : DevExpress.XtraEditors.XtraForm
    {
        public FormListaCuentas()
        {
            InitializeComponent();
        }
        void MostrarCuentas()
        {
            gridControl1.DataSource = ControllerMostrar.CuentasBancarias();
            gridControl1.ForceInitialize();
            gridView1.BestFitColumns();
        }
            

        private void FormListaCuentas_Load(object sender, EventArgs e)
        {
            MostrarCuentas();
        }

        private void FormListaCuentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAgregarCuenta editar = new FormAgregarCuenta("EDITAR");
            editar.id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"id_cuenta_banco"));
            editar.txtCodigo.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "codigo"));
            editar.txtNombreCuenta.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nombre"));
            editar.txtDescripcion.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "descripcion"));
            editar.ShowDialog();
            MostrarCuentas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarCuenta agregar = new FormAgregarCuenta("AGREGAR");
            agregar.ShowDialog();
        }
    }
}