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

namespace ViewGuate502.Bodegas
{
    public partial class FormBodegas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int idbodega=0;

        bool esNuevo = false;
        bool esEditar = false;
        public FormBodegas()
        {
            InitializeComponent();
        }

        public void mostrarBodegas()
        {
            gridControlList.DataSource = ControllerBodega.MostrarBodega(Configuraciones.Configuraciones.idtienda);
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
            //gridView1.Columns[0].Visible = false;
            //gridView1.Columns[1].Visible = false;
        }

        void LimpiearEntradas(TextEdit entrada1, MemoEdit entrada2)
        {
            entrada1.Text = string.Empty;
            entrada2.Text = string.Empty;
        }

        void datosAEditar()
        {
            esEditar = true;
            idbodega = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idbodega"));
            txtNombreEditar.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nombre"));
            memoEditDireccionEditar.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "direccion"));
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 2;
        }
        void guardar()
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                XtraMessageBox.Show("Debe escribir el nombre de forma correcta", "Creación de bodega");

            }
            else
            {

                rpta = ControllerBodega.GuardarBodega(Configuraciones.Configuraciones.idtienda,textNombre.Text, memoEditDireccion.Text);
                if (rpta =="OK")
                {
                    alertControl1.Show(this, "Creación de bodega", "Bodega creada correctamente");
                    LimpiearEntradas(textNombre,memoEditDireccion);
                    textNombre.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear la bodega", "Erro al crear bodega");
                }
            }

        }

        void actualizar()
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(txtNombreEditar.Text))
            {
                XtraMessageBox.Show("Debe escribir el nombre de forma correcta", "Edición en proceso");
            }
            else
            {

                rpta = ControllerBodega.ActualizarBodega(Configuraciones.Configuraciones.idtienda,idbodega, txtNombreEditar.Text, memoEditDireccionEditar.Text);
                if (rpta =="OK")
                {
                    alertControl1.Show(this, "Edición en proceso", "Bodega actualizada correctamente");
                    mostrarBodegas();
                    LimpiearEntradas(txtNombreEditar, memoEditDireccionEditar);
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    esEditar = false;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al crear la bodega", "Error al crear bodega");
                }
            }

        }
        private void FormBodegas_Load(object sender, EventArgs e)
        {
            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            mostrarBodegas();
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea cancelar el proceso de creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esNuevo = false;
                LimpiearEntradas(textNombre, memoEditDireccion);
                mostrarBodegas();
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount < 1)
            {
                XtraMessageBox.Show("No hay datos para editar","Lista de bodegas");
            }
            else
            {
                datosAEditar();
            }

        }

        private void FormBodegas_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void FormBodegas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!esNuevo && !esEditar)
                {
                    this.Close();
                }
                if (esNuevo)
                {

                    if (XtraMessageBox.Show("¿Desea cancelar el proceso de creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esNuevo = false;
                        LimpiearEntradas(textNombre, memoEditDireccion);
                        mostrarBodegas();
                        xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    }

                }

                if (esEditar)
                {


                    if (XtraMessageBox.Show("¿Desea cancelar el proceso de edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        esEditar = false;
                        LimpiearEntradas(txtNombreEditar, memoEditDireccionEditar);
                        xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;

                    }

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea cancelar el proceso de edición?", "Edición en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                esEditar = false;
                LimpiearEntradas(txtNombreEditar, memoEditDireccionEditar);
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;

            }
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                memoEditDireccion.Focus();
            }
        }

        private void memoEditDireccionEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnActualizar.Focus();
            }
        }

        private void txtNombreEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                memoEditDireccionEditar.Focus();
            }
        }

        private void memoEditDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }
    }
}