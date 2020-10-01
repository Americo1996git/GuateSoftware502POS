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

namespace ViewGuate502.ConfigGenerales
{
    public partial class FormAgregar : DevExpress.XtraEditors.XtraForm
    {
        string tipo_de_crecion = "";
        string tipo_de_operacion = "";
        int id_tabla = 0;

        public FormAgregar(string tipo_creacion, string tipo_operacion)
        {
            InitializeComponent();
            tipo_de_crecion = tipo_creacion;
            tipo_de_operacion = tipo_operacion;
            this.Text = tipo_operacion + " "+tipo_creacion;
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        public void MostrarDatosParaEditar(int id, int id_linea, string nombre, string descripcion, decimal descuento, string abreviatura)
        {
            if (tipo_de_operacion.Equals("Editar") && id_linea > 0)
            {
                mostrarEnComboboxLookUp(lookUpEditLinea, "Nombre", "idlinea", ControllerLinea.MostrarLineas());
            }

            id_tabla = id;
            lookUpEditLinea.EditValue = id_linea;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            spinEditDescuento.Value = descuento;
            txtAbreviatura.Text = abreviatura;
        }

        public void Agregar()
        {

        }
        public void Actualizar()
        {

        }


        private void FormAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(lookUpEditLinea, "Este campo es obligatorio");
            dxErrorProvider1.SetError(txtNombre, "Este campo es obligatorio");
            dxErrorProvider1.SetError(txtAbreviatura, "Este campo es obligatorio");
            btnGuardar.Text = tipo_de_operacion;

            if (tipo_de_crecion.Equals("Linea"))
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemAbreviatura.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtAbreviatura.Text = "0";
              
            }
            if (tipo_de_crecion.Equals("Sub linea"))
            {
                mostrarEnComboboxLookUp(lookUpEditLinea, "Nombre", "idlinea", ControllerLinea.MostrarLineas());
            }
            if (tipo_de_crecion.Equals("Marca"))
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemDescripcion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemAbreviatura.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemDescuento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtAbreviatura.Text = "0";
                this.Height = 180;
            }
            if (tipo_de_crecion.Equals("Bodega"))
            {
                layoutControlItemLinea.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemAbreviatura.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemDescuento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtAbreviatura.Text = "0";
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            bool agregar = true;
            if (tipo_de_crecion.Equals("Sub linea"))
            {
                if (lookUpEditLinea.ItemIndex < 0)
                {
                    agregar = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                agregar = false;
            }
            if (string.IsNullOrWhiteSpace(txtAbreviatura.Text))
            {
                agregar = false;
            }

            if (agregar)
            {
                if (tipo_de_crecion.Equals("Linea"))
                {
                    if (tipo_de_operacion.Equals("Agregar"))
                        rpta = ControllerLinea.GuardarLinea(Configuraciones.Configuraciones.idtienda, txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                    else
                        rpta = ControllerLinea.ActualizarLinea(id_tabla, txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                }
                if (tipo_de_crecion.Equals("Sub linea"))
                {
                    if (tipo_de_operacion.Equals("Agregar"))
                        rpta = ControllerSubLinea.GuardarSubLinea(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditLinea.EditValue), txtDescripcion.Text, txtAbreviatura.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                    else
                        rpta = ControllerSubLinea.ActualizarSubLinea(id_tabla, Convert.ToInt32(lookUpEditLinea.EditValue), txtNombre.Text, txtAbreviatura.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                }
                if (tipo_de_crecion.Equals("Marca"))
                {
                    if (tipo_de_operacion.Equals("Agregar"))
                        rpta = ControllerMarca.GuardarMarca(Configuraciones.Configuraciones.idtienda, txtNombre.Text, true);
                    else
                        rpta = ControllerMarca.ActualizarMarca(id_tabla, txtNombre.Text,true);
                }
                if (tipo_de_crecion.Equals("Bodega"))
                {
                    if (tipo_de_operacion.Equals("Agregar"))
                        rpta = ControllerBodega.GuardarBodega(Configuraciones.Configuraciones.idtienda, txtNombre.Text, txtDescripcion.Text);
                    else
                        rpta = ControllerBodega.ActualizarBodega(Configuraciones.Configuraciones.idtienda, id_tabla, txtNombre.Text, txtDescripcion.Text);
                }

                if (rpta == "OK")
                {
                    if (tipo_de_operacion.Equals("Agregar"))
                    {
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        spinEditDescuento.Value = 0;
                        txtAbreviatura.Text = "";
                        this.lookUpEditLinea.Focus();
                        //this.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}