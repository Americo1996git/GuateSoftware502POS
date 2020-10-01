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

namespace ViewGuate502.Sublinea
{
    public partial class FormSublinea : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int idsublinea;

        bool esNuevo = false;
        bool esEditar = false;
        public FormSublinea()
        {
            InitializeComponent();
        }

        public void mostrarSubLineas()
        {
            gridControlList.DataSource = ControllerSubLinea.MostrarSubLienasParaElModulo();
           
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
            //gridView1.Columns[0].Visible = false;
            //gridView1.Columns[1].Visible = false;
            //gridView1.Columns[2].Visible = false;
            //gridView1.Columns[6].Visible = false;
        }

        void datosAEditar()
        {
            esEditar = true;
            idsublinea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idsublinea"));
            textAbreviatura.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Abreviatura"));
            memoEditDescripcion.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descripción"));
            lookUpEditLinea.EditValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idlinea"));
            spinEditDescuento.Value = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descuento"));
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        void LimpiarEntradas()
        {
            textAbreviatura.Text = string.Empty;
            memoEditDescripcion.Text = string.Empty;
            spinEditDescuento.Value = 0;
        }

        void guardar()
        {
            bool guardar = true;
            string rpta = "";
            if (lookUpEditLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar la linea", "Creación en proceso");
                guardar = false;
            }
            if (string.IsNullOrWhiteSpace(memoEditDescripcion.Text))
            {
                XtraMessageBox.Show("Debe escribir la descripción de forma correcta", "Creación en proceso");
                guardar = false;

            }

            if(guardar)
            {
                rpta = ControllerSubLinea.GuardarSubLinea(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditLinea.EditValue), memoEditDescripcion.Text, textAbreviatura.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                if (rpta =="OK")
                {
                    alertControl1.Show(this, "Creación de sublinea", "Sublinea creada correctamente");
                    LimpiarEntradas();
                    lookUpEditLinea.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al guardar la sublinea, por favor consulte a su administrador de datos " + rpta, "Error al guardar");
                }

            }

        }

        void actualizar()
        {
            bool actualizar = true;
            string rpta = "";
            if (lookUpEditLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("Debe seleccionar la linea", "Edición en proceso");
                actualizar = false;

            }
            if (string.IsNullOrWhiteSpace(memoEditDescripcion.Text))
            {
                XtraMessageBox.Show("Debe escribir de forma correcta la descripción "+rpta, "Edición en proceso");
                actualizar = false;

            }
            if(actualizar)
            {
                rpta = ControllerSubLinea.ActualizarSubLinea(idsublinea, Convert.ToInt32(lookUpEditLinea.EditValue), memoEditDescripcion.Text, textAbreviatura.Text, Convert.ToDecimal(spinEditDescuento.EditValue));
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "Sublinea actualizada", "Sublinea actualizada correctamente");
                    mostrarSubLineas();
                    LimpiarEntradas();
                    esEditar = false;
                    xtraTabControl1.SelectedTabPageIndex = 0;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al actulizar la sublinea, por favor consulte a su administrador de datos","Error al actulizar");
                }

            }
            xtraTabControl1.SelectedTabPageIndex = 0;
            esEditar = false;
        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        private void FormSublinea_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            mostrarSubLineas();
            mostrarEnComboboxLookUp(lookUpEditLinea, "Nombre", "idlinea", ControllerLinea.MostrarLineas());
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                guardar();
            }
            if (esEditar)
            {
                actualizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {


                if (XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    esNuevo = false;
                    mostrarSubLineas();
                    LimpiarEntradas();
                    xtraTabControl1.SelectedTabPageIndex = 0;
                }

            }

            if (esEditar)
            {


                if (XtraMessageBox.Show("¿Desea cancelar el proceso edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    esEditar = false;
                    LimpiarEntradas();
                    xtraTabControl1.SelectedTabPageIndex = 0;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            datosAEditar();
            btnGuardar.Text = "Actualizar";
            layoutControlGroupProceso.Text = "Editando sublinea";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            datosAEditar();
            btnGuardar.Text = "Actualizar";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            btnGuardar.Text = "Guardar";
            layoutControlGroupProceso.Text = "Nueva sublinea";
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void FormSublinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!esEditar && !esNuevo)
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

                    if (XtraMessageBox.Show("¿Desea cancelar el proceso de creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esNuevo = false;
                        LimpiarEntradas();
                        mostrarSubLineas();
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }
            }

            if (esEditar)
            {
                if (e.KeyChar == 27)
                {

                    if (XtraMessageBox.Show("¿Desea cancelar el proceso edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esEditar = false;
                        LimpiarEntradas();
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }
            }


        }

        private void lookUpEditLinea_KeyDown(object sender, KeyEventArgs e)
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
                textAbreviatura.Focus();
            }
        }

        private void textAbreviatura_KeyDown(object sender, KeyEventArgs e)
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
                btnGuardar.Focus();
            }
        }
    }
}