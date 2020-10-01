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
using MODELOS502;
using ControllerSoft502;
namespace ViewGuate502.Clientes
{
    public partial class FormClientes : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dtTelefono;
        public DataTable dtTelefonoEliminacion;
        public int tipo_crecion;
        public int id_cliente;
        bool EsBotonOTecla = false;

        private static FormClientes _Instancia;
        List<Control> controles = new List<Control>();
        public FormClientes()
        {
            InitializeComponent();
        }

        public static FormClientes GetInstacnia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormClientes();
            }
            return _Instancia;
        }
        public void CrearTablaTelefonos()
        {
            dtTelefono = new DataTable();
            dtTelefono.Columns.Add("id_telefono", typeof(int));
            dtTelefono.Columns.Add("id_cliente",typeof(int));
            dtTelefono.Columns.Add("descripcion", typeof(string));
            dtTelefono.Columns.Add("telefono", typeof(string));

            dtTelefonoEliminacion = new DataTable();
            dtTelefonoEliminacion.Columns.Add("id_telefono", typeof(int));
            dtTelefonoEliminacion.Columns.Add("id_cliente", typeof(int));
            dtTelefonoEliminacion.Columns.Add("descripcion", typeof(string));
            dtTelefonoEliminacion.Columns.Add("telefono", typeof(string));
        }

        //____________________________________________________

        //______________________________________________________________________________________________________________________
        //________________________________________________funcion para mostrar los productos en el lookpuedit______________________________________________________________________

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }
        //______________________________________________________________________________________________________________________
        //______________________________________________________________________________________________________________________


        private void FormClientes_Load(object sender, EventArgs e)
        {
            XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

            mostrarEnComboboxLookUp(lookUpEditEstadoCivil, "descripcion", "id_estado_civil", ControllerCliente.MostrarEstadoCivil());
            mostrarEnComboboxLookUp(lookUpEditGrupo, "descripcion", "id_grupo", ControllerCliente.MostrarGrupo());
            CrearTablaTelefonos();

 
            controles.Add(txtNombres);
            controles.Add(txtApellidos);
            controles.Add(txtDireccion);
            controles.Add(txtDescripcion);
            controles.Add(dateEditFechaNacimiento);
            controles.Add(tbtelefono);
            controles.Add(txtInstitucionLabora);
            controles.Add(txtCargoOcupa);
            controles.Add(txtRazonSocial);
            controles.Add(txtDireccionFiscal);
            controles.Add(txtNit);
          

            foreach (Control control in controles)
            {
                dxErrorProvider1.SetError(control, "");

                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    dxErrorProvider1.SetError(control, "Este campo no puede ser vacío");
                }
            }

            if (tipo_crecion == 0)
            {
                btnGrabar.Text = "Grabar";
            }
            else
            {
                btnGrabar.Text = "Actualizar";
                dtTelefonoEliminacion = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                dtTelefono = ControllerVentas.MostrarTelefonoDeCliente(id_cliente);
                mostrarEnComboboxLookUp(tbtelefono, "telefono", "id_telefono", dtTelefono);
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            XtraTabControl1.SelectedTabPageIndex = 1;
            spinEditCantidadHijos.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            XtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void lookUpEditGrupo_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditGrupo.ItemIndex > -1)
            {
                mostrarEnComboboxLookUp(lookUpEditSubGrupo, "descripcion", "id_cliente_subgrupo", ControllerCliente.MostrarSubGrupo(Convert.ToInt32(lookUpEditGrupo.EditValue)));
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool guardar = true;
            bool mostrarMensaje = false;
            string rpta = "";


            foreach (Control control in controles)
            {

                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    if (tipo_crecion == 1)
                    {
                        dxErrorProvider1.SetError(control, "Este campo no puede ser vacío");
                        mostrarMensaje = true;
                    }
                    else
                    {
                        mostrarMensaje = true;
                    }
                  
                }
            }
            if (dtTelefono.Rows.Count == 0)
            {
                mostrarMensaje = true;
            }
            if (mostrarMensaje)
            {
                MessageBox.Show("ALGUNOS CAMPOS REQUERIDOS NO ESTAN BIEN ESCRITOS O ESTAN VACIOS, POR FAVOR RECTIFIQUE", "CREACIÓN EN PROCESO");
                guardar = false;
            }

           

            if (guardar)
            {
                if (tipo_crecion == 0)
                {
                    MCliente objMCliente = new MCliente();
                    objMCliente.idEstadoCivil = lookUpEditEstadoCivil.ItemIndex > -1 ? Convert.ToInt32(lookUpEditEstadoCivil.EditValue) : 3;
                    objMCliente.identificacion = txtDpi.Text;
                    objMCliente.IdUsuario = Configuraciones.Configuraciones.idusuario;
                    objMCliente.Nombres = txtNombres.Text;
                    objMCliente.Apellidos = txtApellidos.Text;
                    objMCliente.fechaNacimiento = Convert.ToDateTime(dateEditFechaNacimiento.EditValue);
                    objMCliente.direccion = txtDireccion.Text;
                    objMCliente.email = string.IsNullOrWhiteSpace(txtEmail.Text) == true ? "" : txtEmail.Text;
                    objMCliente.empresaLabora = string.IsNullOrWhiteSpace(txtInstitucionLabora.Text) == true ? "" : txtInstitucionLabora.Text;
                    objMCliente.cargo = string.IsNullOrWhiteSpace(txtCargoOcupa.Text) == true ? "" : txtCargoOcupa.Text;
                    objMCliente.nit = txtNit.Text;
                    objMCliente.manejaCuentaBanco = radioGroupUsaCuenta.SelectedIndex == 0 ? false : true;
                    objMCliente.negocioPropio = radioGroupTieneNegocio.SelectedIndex == 0 ? false : true;
                    objMCliente.tipoNegocio = radioGroupTieneNegocio.SelectedIndex == 0 ? "" : txtTipoNegocio.Text;
                    objMCliente.tiempoNegocio = radioGroupTieneNegocio.SelectedIndex == 0 ? "" : txtTiempoNegocio.Text;
                    objMCliente.cantidadHijos = Convert.ToInt32(spinEditCantidadHijos.EditValue);
                    objMCliente.cantidadAportesFamilia = Convert.ToDouble(spinEditAportesFamilia.EditValue);
                    objMCliente.casaPropia = radioGroupCasaPropia.SelectedIndex == 0 ? false : true;
                    objMCliente.tiempoResidir = radioGroupCasaPropia.SelectedIndex == 0 ? "" : txtTiempoResidir.Text;
                    objMCliente.trabajaPareja = radioGroupTrabajaPareja.SelectedIndex == 0 ? false : true;
                    objMCliente.trabajoPareja = radioGroupTrabajaPareja.SelectedIndex == 0 ? "" : txtTrabajaPareja.Text;
                    objMCliente.descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) == true ? "" : txtDescripcion.Text;
                    objMCliente.RazonSocial = string.IsNullOrWhiteSpace(txtRazonSocial.Text) == true ? "" : txtRazonSocial.Text;
                    objMCliente.DireccionFiscal = string.IsNullOrWhiteSpace(txtDireccionFiscal.Text) == true ? "" : txtDireccionFiscal.Text;
                    objMCliente.IdSubGrupo = lookUpEditSubGrupo.ItemIndex > -1 ? Convert.ToInt32(lookUpEditSubGrupo.EditValue) : 6;
                    //objMCliente.ConObservaciones = dtTelefono.Rows.Count > 0 ? true : false;
                    objMCliente.ConObservaciones = false;
                    objMCliente.EsFiador = true;
                    objMCliente.ConTelefonos = dtTelefono.Rows.Count > -1 ? true : false;
                    List<MTelefonoCliente> Telefonos = new List<MTelefonoCliente>();
                    foreach (DataRow item in dtTelefono.Rows)
                    {
                        MTelefonoCliente telefono = new MTelefonoCliente();
                        telefono.Descripcion = item["descripcion"].ToString();
                        telefono.Telefono = item["telefono"].ToString();
                        telefono.Opcion = 1;
                        telefono.IdTelefon = 0;
                        Telefonos.Add(telefono);
                    }

                    rpta = ControllerCliente.GuardarCliente(objMCliente, Telefonos);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("EL CLIENTE SE CREO CORRECTAMENTE", "CREACIÓN EN PROCESO");          
                        EsBotonOTecla = true;
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("OCURRIO UN ERRO AL TRATAR DE CREAR EL CLIENTE, POR FAVOR CONSULTE A SU ADMINISTRADOR DE DATOS " + rpta, "ERROR AL CREAR");
                    }
                }
                else
                {
                    MCliente objMCliente = new MCliente();
                    objMCliente.idCliente = id_cliente;
                    objMCliente.idEstadoCivil = lookUpEditEstadoCivil.ItemIndex > -1 ? Convert.ToInt32(lookUpEditEstadoCivil.EditValue) : 3;
                    objMCliente.identificacion = txtDpi.Text;
                    objMCliente.IdUsuario = Configuraciones.Configuraciones.idusuario;
                    objMCliente.Nombres = txtNombres.Text;
                    objMCliente.Apellidos = txtApellidos.Text;
                    objMCliente.fechaNacimiento = Convert.ToDateTime(dateEditFechaNacimiento.EditValue);
                    objMCliente.direccion = txtDireccion.Text;
                    objMCliente.email = string.IsNullOrWhiteSpace(txtEmail.Text) == true ? "" : txtEmail.Text;
                    objMCliente.empresaLabora = string.IsNullOrWhiteSpace(txtInstitucionLabora.Text) == true ? "" : txtInstitucionLabora.Text;
                    objMCliente.cargo = string.IsNullOrWhiteSpace(txtCargoOcupa.Text) == true ? "" : txtCargoOcupa.Text;
                    objMCliente.nit = txtNit.Text;
                    objMCliente.manejaCuentaBanco = radioGroupUsaCuenta.SelectedIndex == 0 ? false : true;
                    objMCliente.negocioPropio = radioGroupTieneNegocio.SelectedIndex == 0 ? false : true;
                    objMCliente.tipoNegocio = radioGroupTieneNegocio.SelectedIndex == 0 ? "" : txtTipoNegocio.Text;
                    objMCliente.tiempoNegocio = radioGroupTieneNegocio.SelectedIndex == 0 ? "" : txtTiempoNegocio.Text;
                    objMCliente.cantidadHijos = Convert.ToInt32(spinEditCantidadHijos.EditValue);
                    objMCliente.cantidadAportesFamilia = Convert.ToDouble(spinEditAportesFamilia.EditValue);
                    objMCliente.casaPropia = radioGroupCasaPropia.SelectedIndex == 0 ? false : true;
                    objMCliente.tiempoResidir = radioGroupCasaPropia.SelectedIndex == 0 ? "" : txtTiempoResidir.Text;
                    objMCliente.trabajaPareja = radioGroupTrabajaPareja.SelectedIndex == 0 ? false : true;
                    objMCliente.trabajoPareja = radioGroupTrabajaPareja.SelectedIndex == 0 ? "" : txtTrabajaPareja.Text;
                    objMCliente.descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) == true ? "" : txtDescripcion.Text;
                    objMCliente.RazonSocial = string.IsNullOrWhiteSpace(txtRazonSocial.Text) == true ? "" : txtRazonSocial.Text;
                    objMCliente.DireccionFiscal = string.IsNullOrWhiteSpace(txtDireccionFiscal.Text) == true ? "" : txtDireccionFiscal.Text;
                    objMCliente.IdSubGrupo = lookUpEditSubGrupo.ItemIndex > -1 ? Convert.ToInt32(lookUpEditSubGrupo.EditValue) : 6;
                    //objMCliente.ConObservaciones = dtTelefono.Rows.Count > 0 ? true : false;
                    objMCliente.ConObservaciones = false;
                    objMCliente.EsFiador = true;
                    objMCliente.ConTelefonos = dtTelefono.Rows.Count > -1 ? true : false;

                    List<MTelefonoCliente> TelefonosEliminacion = new List<MTelefonoCliente>();
                    foreach (DataRow item in dtTelefonoEliminacion.Rows)
                    {
                        MTelefonoCliente telefono = new MTelefonoCliente();
                        telefono.IdTelefon = Convert.ToInt32(item["id_telefono"]);
                        telefono.Descripcion = item["descripcion"].ToString();
                        telefono.Telefono = item["telefono"].ToString();
                        telefono.Opcion = 0;
                        telefono.IdCliente = 0;
                        TelefonosEliminacion.Add(telefono);
                    }

                    List<MTelefonoCliente> TelefonosInsercion = new List<MTelefonoCliente>();
                    foreach (DataRow item in dtTelefono.Rows)
                    {
                        MTelefonoCliente telefono = new MTelefonoCliente();
                        telefono.Descripcion = item["descripcion"].ToString();
                        telefono.Telefono = item["telefono"].ToString();
                        telefono.Opcion = 1;
                        telefono.IdCliente = id_cliente;
                        TelefonosInsercion.Add(telefono);
                    }

                    rpta = ControllerCliente.ActualizarCliente(objMCliente, TelefonosInsercion,TelefonosEliminacion);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("EL CLIENTE SE CREO CORRECTAMENTE", "CREACIÓN EN PROCESO");
                        EsBotonOTecla = true;
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("OCURRIO UN ERRO AL TRATAR DE CREAR EL CLIENTE, POR FAVOR CONSULTE A SU ADMINISTRADOR DE DATOS " + rpta, "ERROR AL CREAR");
                    }
                }
               
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            Ventas.Complementos.FormTelefonos modal = new Ventas.Complementos.FormTelefonos();
            modal.tipo_creacion = 1;
            if (tipo_crecion == 1)
            {
                modal.id_cliente = id_cliente;
            }
            modal.ShowDialog();


            tbtelefono.Properties.DataSource = dtTelefono;
            tbtelefono.Properties.DisplayMember = "telefono";
            tbtelefono.Properties.ValueMember = "id_telefono";

        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EsBotonOTecla)
            {
                e.Cancel = false;
                _Instancia = null;
            }
            else
            {
                if (XtraMessageBox.Show("Desea cancelar el proceso de creación", "Creando cliente", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    e.Cancel = false;
                    _Instancia = null;
                }
                else
                {
                    e.Cancel = true;
                   
                }


            }

        }

        private void radioGroupCasaPropia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupCasaPropia.SelectedIndex == 1)
            {
                dxErrorProvider1.SetError(txtTiempoResidir, "Este campo no puede ser vacío");
                controles.Add(txtTiempoResidir);
            }
            else
            {
                dxErrorProvider1.SetError(txtTiempoResidir, "");
                controles.Remove(txtTiempoResidir);
            }
        }

        private void radioGroupTrabajaPareja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupTrabajaPareja.SelectedIndex == 1)
            {
                dxErrorProvider1.SetError(txtTrabajaPareja, "Este campo no puede ser vacío");
                controles.Add(txtTrabajaPareja);
            }
            else
            {
                dxErrorProvider1.SetError(txtTrabajaPareja, "");
                controles.Remove(txtTrabajaPareja);
            }
        }

        private void radioGroupTieneNegocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupTieneNegocio.SelectedIndex == 1)
            {
                dxErrorProvider1.SetError(txtTipoNegocio, "Este campo no puede ser vacío");
                dxErrorProvider1.SetError(txtTiempoNegocio, "Este campo no puede ser vacío");
                controles.Add(txtTipoNegocio);
                controles.Add(txtTiempoNegocio);
            }
            else
            {
                dxErrorProvider1.SetError(txtTipoNegocio, "");
                dxErrorProvider1.SetError(txtTiempoNegocio, "");
                controles.Remove(txtTipoNegocio);
                controles.Remove(txtTiempoNegocio);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea cancelar el proceso de creación ", "Creando cliente", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                EsBotonOTecla = true;
                this.Close();
            }
        }

        private void FormClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (XtraMessageBox.Show("Desea cancelar la orden de compra", "Generando orden", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    EsBotonOTecla = true;
                    this.Close();
                }
            }
        }

        private void txtDpi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateEditFechaNacimiento.Focus();
            }
        }

        private void dateEditFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregarTelefono.Focus();
            }
        }

        private void btnAgregarTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditEstadoCivil.Focus();
            }
        }

        private void lookUpEditEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditGrupo.Focus();
            }
        }

        private void lookUpEditGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditSubGrupo.Focus();
            }
        }

        private void lookUpEditSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupUsaCuenta.Focus();
            }
        }

        private void radioGroupUsaCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSiguiente.Focus();
            }
        }

        private void spinEditCantidadHijos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditAportesFamilia.Focus();
            }
        }

        private void spinEditAportesFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupCasaPropia.Focus();
            }
        }

        private void radioGroupCasaPropia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioGroupCasaPropia.SelectedIndex == 0)
                {
                    radioGroupTrabajaPareja.Focus();
                }
                else
                {
                    txtTiempoResidir.Focus();
                }

            }
        }

        private void txtTiempoResidir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupTrabajaPareja.Focus();
            }
        }

        private void radioGroupTrabajaPareja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioGroupTrabajaPareja.SelectedIndex == 0)
                {
                    txtInstitucionLabora.Focus();
                }
                else
                {
                    txtTrabajaPareja.Focus();
                }
            }
        }

        private void txtTrabajaPareja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtInstitucionLabora.Focus();
            }
        }

        private void txtInstitucionLabora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCargoOcupa.Focus();
            }
        }

        private void txtCargoOcupa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupTieneNegocio.Focus();
            }
        }

        private void radioGroupTieneNegocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioGroupTieneNegocio.SelectedIndex == 0)
                {
                    txtRazonSocial.Focus();
                }
                else
                {
                    txtTipoNegocio.Focus();
                }
            }
        }

        private void txtTipoNegocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTiempoNegocio.Focus();
            }
        }

        private void txtTiempoNegocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRazonSocial.Focus();
            }
        }

        private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDireccionFiscal.Focus();
            }
        }

        private void txtDireccionFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNit.Focus();
            }
        }

        private void txtNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGrabar.Focus();
            }
        }
    }
}