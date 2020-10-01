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
    public partial class FormAgregarCuenta : DevExpress.XtraEditors.XtraForm
    {
        public int id = 0;
        string operacion = "";
        public FormAgregarCuenta(string tipo_operacion)
        {
            InitializeComponent();
            this.Text = tipo_operacion+" CUENTA BANCARIA";
            operacion = tipo_operacion;
        }
        void Grabar()
        {
            bool guardar = true;
            string rpta = "";
            int opcion = 0;
            if (operacion.Equals("AGREGAR"))
            {
                opcion = 0;
            }
            if (operacion.Equals("EDITAR"))
            {
                opcion = 1;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                guardar = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCuenta.Text))
            {
                guardar = false;
            }
            if (guardar)
            {
                rpta = ControllerBancos.AgregarCuentaBancaria(id, txtCodigo.Text, txtNombreCuenta.Text, txtDescripcion.Text, "0", opcion);
                if (rpta == "OK")
                {
                    txtCodigo.Text = string.Empty;
                    txtNombreCuenta.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    if (opcion == 1)
                    {
                        this.Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("OCURRIO UN ERROR EN LA OPERACION " + rpta);
                }
            }
        }

        private void FormAgregarCuenta_Load(object sender, EventArgs e)
        {
            btnGrabar.Text = operacion;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormAgregarCuenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Grabar();
            }
        }
    }
}