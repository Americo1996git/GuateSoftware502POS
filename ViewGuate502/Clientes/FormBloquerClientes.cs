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

namespace ViewGuate502.Clientes
{
    public partial class FormBloquerClientes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_cliente;
        public FormBloquerClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtCliente = new DataTable();
            DataTable dtValidarBloqueoCliente = new DataTable();
            string respuesta_bloqueo_empresa;

            dtCliente = ControllerVentas.MostrarClientes(txtDpi.Text,"","",0);


            if (dtCliente.Rows.Count > 0)
            {
                id_cliente = Convert.ToInt32(dtCliente.Rows[0]["id_cliente"]);
                txtCliente.Text = Convert.ToString(dtCliente.Rows[0]["nombre_cliente"]);
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            string rpta = "";
            bool bloquear = true;
            if (string.IsNullOrWhiteSpace(txtDpi.Text))
            {
                XtraMessageBox.Show("Debe escribir el dpi", "Bloqueo de clientes");
                bloquear = false;
            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                XtraMessageBox.Show("Debe escribir las observaciones", "Bloqueo de clientes");
                bloquear = false;
            }
            if (bloquear)
            {
                rpta = ControllerCliente.BloquerCliente(id_cliente,1,"1","A1");
                if (rpta =="OK")
                {
                    XtraMessageBox.Show("EL cliente se bloqueo correctamente", "Bloqueo de clientes");
                    id_cliente = 0;
                    txtDpi.Text = string.Empty;
                    txtCliente.Text = string.Empty;
                    txtObservaciones.Text = string.Empty;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al bloquear el cliente, por favor consulte a su adminsitrador de datos", "ERROR Bloqueo de clientes");
                }
            }
        }
    }
}