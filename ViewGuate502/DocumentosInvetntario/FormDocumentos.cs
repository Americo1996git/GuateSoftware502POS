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

namespace ViewGuate502.DocumentosInvetntario
{
    public partial class FormDocumentos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool esNuevo = false;
        bool esEditar = false;
        int iddocumento;

        string operacion = "";
        public FormDocumentos()
        {
            InitializeComponent();
        }

        public void mostrarDocumentos()
        {
            //gridControlList.DataSource = ControllerDocumentosInventario.MostrarDocumentos(Configuraciones.Configuraciones.idtienda);
        }
        void guardar()
        {
            if (textNombre.Text == "")
            {
                XtraMessageBox.Show("¿Desea escribir el nombre?", "Creación en proceso");

            }
            else
            {

                //ControllerDocumentosInventario.guardarDocumento(Configuraciones.Configuraciones.idtienda,textNombre.Text, operacion,textDescripcion.Text);
                alertControl1.Show(this, "Linea", "Liena creada correctamente");
                mostrarDocumentos();
            }

        }

        void actualizar()
        {
            if (textNombre.Text == "" )
            {
                XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creación en proceso");

            }
            else
            {

                //ControllerDocumentosInventario.EditarDocumento(iddocumento,textNombre.Text, operacion, textDescripcion.Text);
                alertControl1.Show(this, "Linea", "Liena actualizda correctamente");
                mostrarDocumentos();
            }
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
            esEditar = false;
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
            if (esNuevo || esEditar)
            {


                if (XtraMessageBox.Show("¿Desea cancelar el proceso creación?", "Creación en proceso", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    esNuevo = false;
                    esEditar = false;
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                }

            }
        }

        private void FormDocumentos_Load(object sender, EventArgs e)
        {

            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            mostrarDocumentos();
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
        }

        private void radioGroupOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupOperacion.SelectedIndex == 0)
            {
                operacion = "suma";
            }
            if (radioGroupOperacion.SelectedIndex == 1)
            {
                operacion = "resta";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esEditar = true;
            iddocumento = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "iddocumento"));
            textNombre.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"nombre"));
            if (Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "operacion")) == "suma")
            {
                radioGroupOperacion.SelectedIndex = 0;
            }
            if (Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "operacion")) == "resta")
            {
                radioGroupOperacion.SelectedIndex = 1;
            }
            textDescripcion.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "descripcion"));
            //datosAEditar();
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
            btnGuardar.Text = "Actualizar";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            btnGuardar.Text = "Guardar";
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }
    }
}