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

namespace ViewGuate502.Marca
{
    public partial class FormNuevaMarca : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int idmarca=0;

        bool esNuevo = false;
        bool esEditar = false;

        public FormNuevaMarca()
        {
            InitializeComponent();
        }

        public void mostrarMarcas()
        {
            gridControlList.DataSource = ControllerMarca.MostrarMarcas();
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
        }

        void datosAEditar()
        {

            esEditar = true;
            idmarca = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idmarca"));
            txtNombreEditar.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nombre"));
            if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "estado")))
            {
                radioGroupActivoEditar.SelectedIndex = 0;
            }
            // lookUpEditLinea.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "linea"));
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        void LimpiarEntradas(TextEdit entrada1, RadioGroup entrada2)
        {
            entrada1.Text = string.Empty;
            entrada2.SelectedIndex = 0;
            //mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerLinea.MostrarLineas());

        }
        void guardar()
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                XtraMessageBox.Show("¿Debe escribir el nombre de forma correcta?", "Creación en proceso");

            }
            else
            {

                rpta = ControllerMarca.GuardarMarca(Configuraciones.Configuraciones.idtienda, textNombre.Text, true);
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "Creación de marca ", "Marca creada correctamente");
                    LimpiarEntradas(textNombre, radioGroupActivo);
                    textNombre.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al crear la marca","Error al crear marca");
                }


            }

        }

        void actualizar()
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(txtNombreEditar.Text))
            {
                XtraMessageBox.Show("¿Debe escribir el nombre de forma correcta?", "Edición en proceso");

            }
            else
            {

                rpta = ControllerMarca.ActualizarMarca(idmarca,txtNombreEditar.Text, radioGroupActivoEditar.SelectedIndex == 0 ? true : false);
                if (rpta == "OK")
                {
                    alertControl1.Show(this, "Edición de marca ", "Marca actualizada correctamente");
                    LimpiarEntradas(txtNombreEditar, radioGroupActivoEditar);
                    txtNombreEditar.Focus();
                    mostrarMarcas();
                    idmarca = 0;
                    esEditar = false;
                    xtraTabControl1.SelectedTabPageIndex = 0;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al actulaizar la marca", "Error al editar marca");
                }


            }

        }

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }

        private void FormNuevaMarca_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            mostrarMarcas();

    
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esNuevo = false;
                LimpiarEntradas(textNombre,radioGroupActivo);
                mostrarMarcas();
                xtraTabControl1.SelectedTabPageIndex = 0;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount < 1)
            {
                XtraMessageBox.Show("No hay datos para editar","Lista de marcas");
            }
            else
            {
                datosAEditar();
            }

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
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void FormNuevaMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupActivo.Focus();
            }
        }

        private void radioGroupActivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }

        private void FormNuevaMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!esNuevo && !esEditar)
                {
                    this.Close();
                }

                if (esNuevo)
                {
                    if (XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esNuevo = false;
                        LimpiarEntradas(textNombre, radioGroupActivo);
                        mostrarMarcas();
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }
                if (esEditar)
                {
                    if (XtraMessageBox.Show("¿Desea cancelar el proceso edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esEditar = false;
                        LimpiarEntradas(txtNombreEditar, radioGroupActivoEditar);
                        idmarca = 0;
                        xtraTabControl1.SelectedTabPageIndex = 0;
                    }
                }
            }

        }

        private void txtNombreEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupActivoEditar.Focus();
            }
        }

        private void radioGroupActivoEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnActualizar.Focus();
            }
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea cancelar el proceso edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esEditar = false;
                LimpiarEntradas(txtNombreEditar, radioGroupActivoEditar);
                idmarca = 0;
                xtraTabControl1.SelectedTabPageIndex = 0;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}