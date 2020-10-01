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
using MODELOS502;


namespace ViewGuate502.Clientes
{
    public partial class FormCrearClienteRapido : DevExpress.XtraEditors.XtraForm
    {
        public FormCrearClienteRapido()
        {
            InitializeComponent();
        }
        
        void Guardar()
        {
            string rpta = "";

            bool agregar = true;
            DataTable dtCliente = new DataTable();
            DataTable dtValidarBloqueoCliente = new DataTable();

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                agregar = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                agregar = false;
            }

            dtCliente = ControllerVentas.MostrarClientes("", txtNombres.Text, txtApellidos.Text, 1);


            if (dtCliente.Rows.Count > 0)
            {
                if (Convert.ToString(dtCliente.Rows[0]["existe"]).Equals("existe"))
                {
                    XtraMessageBox.Show("EL CLIENTE YA EXISTE, RECTIFIQUE EN EL MODULO DE CLIENTES", Configuraciones.Configuraciones.NombreDelSistema);
                    agregar = false;
                }
            }

            if (agregar)
            {

                MCliente objMCliente = new MCliente();
                objMCliente.idEstadoCivil = 3;
                objMCliente.identificacion = "";
                objMCliente.IdUsuario = Configuraciones.Configuraciones.idusuario;
                objMCliente.Nombres = txtNombres.Text;
                objMCliente.Apellidos = txtApellidos.Text;
                objMCliente.fechaNacimiento = Convert.ToDateTime(DateTime.Now);
                objMCliente.direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) == true ? "__" : txtDireccion.Text;
                objMCliente.email = "";
                objMCliente.empresaLabora = "";
                objMCliente.cargo = "";
                objMCliente.nit = string.IsNullOrWhiteSpace(txtNit.Text) == true ? "__" : txtNit.Text;
                objMCliente.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) == true ? "__" : txtTelefono.Text;
                objMCliente.manejaCuentaBanco = false;
                objMCliente.negocioPropio = false;
                objMCliente.tipoNegocio = "";
                objMCliente.tiempoNegocio = "";
                objMCliente.cantidadHijos = 0;
                objMCliente.cantidadAportesFamilia = 0;
                objMCliente.casaPropia = false;
                objMCliente.tiempoResidir = "";
                objMCliente.trabajaPareja = false;
                objMCliente.trabajoPareja = "";
                objMCliente.descripcion = "";
                objMCliente.RazonSocial = "";
                objMCliente.DireccionFiscal = "";
                objMCliente.IdSubGrupo = 6;
                //objMCliente.ConObservaciones = dtTelefono.Rows.Count > 0 ? true : false;
                objMCliente.ConObservaciones = false;
                objMCliente.EsFiador = false;
                objMCliente.ConTelefonos = false;



                List<MTelefonoCliente> Telefonos = new List<MTelefonoCliente>();
                //foreach (DataRow item in dtTelefono.Rows)
                //{
                //    MTelefonoCliente telefono = new MTelefonoCliente();
                //    telefono.Descripcion = item["descripcion"].ToString();
                //    telefono.Telefono = item["telefono"].ToString();
                //    telefono.Opcion = 1;
                //    telefono.IdTelefon = 0;
                //    Telefonos.Add(telefono);
                //}

                rpta = ControllerCliente.GuardarCliente(objMCliente, Telefonos);


                if (rpta == "OK")
                {
                    //MessageBox.Show("EL CLIENTE SE CREO CORRECTAMENTE", "CREACIÓN EN PROCESO");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("OCURRIO UN ERRO AL TRATAR DE CREAR EL CLIENTE, POR FAVOR CONSULTE A SU ADMINISTRADOR DE DATOS " + rpta, "ERROR AL CREAR");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();  
        }

        private void FormCrearClienteRapido_Load(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(txtNombres,"ESTE CAMPO ES OBLIGATORIO");
            dxErrorProvider1.SetError(txtApellidos, "ESTE CAMPO ES OBLIGATORIO");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearClienteRapido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormCrearClienteRapido_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                Guardar();
            }
        }
    }
}