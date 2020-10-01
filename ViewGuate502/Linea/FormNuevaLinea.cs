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

namespace ViewGuate502.Linea
{
    public partial class FormNuevaLinea : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int idlinea;

        bool esNuevo = false;
        bool esEditar = false;
        public FormNuevaLinea()
        {
            InitializeComponent();
        }

        public void mostrarLineas()
        {
            gridControlList.DataSource = ControllerLinea.MostrarLineas();
            //gridView1.Columns[0].Visible = false;
            //gridView1.Columns[1].Visible = false;
            //gridView1.Columns[4].Visible = false;
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
        }
   
        void datosAEditar()
        {
            esEditar = true;
            idlinea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idlinea"));
            textNombre.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombre"));
            memoEditDescripcion.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descripción"));
            spinEditDescuento.Value = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descuento"));
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        void LimpiarEntradas(TextEdit entrada0, MemoEdit entrada1, SpinEdit entrada2)
        {
            entrada0.Text = string.Empty;
            entrada1.Text = string.Empty;
            spinEditDescuento.Value = 0;
        }
        void guardar()
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR EL NOMBRE DE FORMA CORRECTA", "CREACIÓN EN PROCESO");

            }
            else
            {
                rpta = ControllerLinea.GuardarLinea(Configuraciones.Configuraciones.idtienda, textNombre.Text, memoEditDescripcion.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                if (rpta=="OK")
                {
                    alertControl1.Show(this, "LINEA CREADA CORRECTAMENTE", "CREACIÓN EN PROCESO");
                    LimpiarEntradas(textNombre, memoEditDescripcion,spinEditDescuento);
                    textNombre.Focus();
                

                }
                else
                {
                    XtraMessageBox.Show("OCURRIO UN ERROR AL CREAR LA LINEA "+ rpta, "ERROR");
                }

            }
         
        }

      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                guardar();
       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿DESEA CANCELAR EL PROCESO DE CREACIÓN?", "CREACIÓN EN PROCESO", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esNuevo = false;
                mostrarLineas();
                LimpiarEntradas(textNombre, memoEditDescripcion, spinEditDescuento);
                xtraTabControl1.SelectedTabPageIndex = 0;
            }

        }

        private void FormNuevaLinea_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            mostrarLineas();
            xtraTabControl1.SelectedTabPageIndex = 0;
            
        }

        private void FormNuevaLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!esNuevo && !esEditar)
            {
                if (e.KeyChar == 27)
                {

                    this.Close();
                }
            }

            if (esNuevo)
            {
                if (e.KeyChar == 27)
                {

                    if (XtraMessageBox.Show("¿DESEA CANCELAR EL PROCESO DE CREACIÓN?", "CREACIÓN EN PROCESO", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esNuevo = false;
                        LimpiarEntradas(textNombre, memoEditDescripcion, spinEditDescuento);
                        mostrarLineas();
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }


            }

            if (esEditar)
            {
                if (e.KeyChar == 27)
                {

                    if (XtraMessageBox.Show("¿DESEA CANCELAR EL PROCESO DE EDICIÓN?", "EDICIÓN EN PROCESO", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esEditar = false;
                        LimpiarEntradas(txtNombreEditar, txtDescripcionEditar, spinEditDescuentoEditar);
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }


            }


           

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esEditar = true;

            idlinea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idlinea"));
            txtNombreEditar.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombre"));
            txtDescripcionEditar.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descripción"));
            spinEditDescuentoEditar.Value = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descuento"));
            xtraTabControl1.SelectedTabPageIndex = 2;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
      
            xtraTabControl1.SelectedTabPageIndex = 1;
            esNuevo = true;
            textNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditDescuento.Focus();
            }
        }

        private void spinEditDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                memoEditDescripcion.Focus();
            }
        }

        private void memoEditDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿DESEA CANCELAR EL PROCESO DE EDICIÓN?", "EDICIÓN EN PROCESO", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esEditar = false;
                LimpiarEntradas(txtNombreEditar,txtDescripcionEditar,spinEditDescuentoEditar);
                xtraTabControl1.SelectedTabPageIndex = 0;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(txtNombreEditar.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR EL NOMBRE DE FORMA CORRECTA", "EDICIÓN EN PROCESO");

            }
            else
            {
                rpta = ControllerLinea.ActualizarLinea(idlinea, txtNombreEditar.Text, txtDescripcionEditar.Text, Convert.ToDecimal(spinEditDescuentoEditar.EditValue));
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "LINEA ACTUALIZADA CORRECTAMENTE", "EDICIÓN EN PROCESO");
                    LimpiarEntradas(txtNombreEditar, txtDescripcionEditar, spinEditDescuentoEditar);
                    txtNombreEditar.Focus();
                    mostrarLineas();
                    esEditar = false;
                    xtraTabControl1.SelectedTabPageIndex = 0;

                }
                else
                {
                    XtraMessageBox.Show("OCURRIO UN ERROR AL ACTUALIZAR LA LINEA", "ERROR");
                }

            }
        }

        private void txtNombreEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditDescuentoEditar.Focus();
            }
        }

        private void spinEditDescuentoEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcionEditar.Focus();
            }
        }

        private void txtDescripcionEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnActualizar.Focus();
            }
        }
    }
}